using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Tutorial2.Models;

namespace Tutorial2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var path = @"Data\dane.csv";

         
            var fi = new FileInfo(path);
            var listOfStudents = new HashSet<Student>(new CustomComparer());
            using (var stream = new StreamReader(fi.OpenRead()))
            {
                string line = null;
                
                while ((line = stream.ReadLine()) != null)
                {
                    string[] columns = line.Split(',');

                    Console.WriteLine(line);
                }
            }

           


            var parsedDate = DateTime.Parse("2000-02-12");
     
            var str = string.Empty;                      
                     
            if (string.IsNullOrEmpty(str)) { }
       
            if (string.IsNullOrWhiteSpace(str)) { }

            String Author = "Bohdan Kvetka";
            
            var st1 = new Student
            {
                created_at = DateTime.Now,
                author = Author,
                IndexNumber = "s1234",              
                FirstName = "eeeee",
                LastName = "Brown",
                birthdate = "3113133131",
                email = "test@test.com",
                mothersname = "wewwww",
                fatherssname = "fffffffffffff",
                name = "eff",
                mode = "ddewefwefwefewfwe"
            };

            var st2 = new Student
            {
                created_at = DateTime.Now,
                author = Author,
                IndexNumber = "s1234",
                FirstName = "Bob2",
                LastName = "eBrown2",
                birthdate = "e3113133131",
                email = "etest@test.com",
                mothersname = "ewewwww",
                fatherssname = "efffffffffffff",
                name = "eeff",
                mode = "ddewefwefwefewfwe"
            };

          

            listOfStudents.Add(st1); listOfStudents.Add(st2);

            if (listOfStudents.Contains(st1))
            {
                Console.WriteLine("element exists in the set");
            }

          
            if (!listOfStudents.Add(st1))
            {
                //Duplicate was found
                //Write the info to the log.txt
                using var sw = new StreamWriter(@"log.txt");
                sw.WriteLine($"element with the first name {st1.FirstName} was not added to the set");
            }

            //Serialize the data to the xml file
            var writer = new FileStream(@"result1.xml", FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(HashSet<Student>));

            serializer.Serialize(writer, listOfStudents);

        }
    }
}
