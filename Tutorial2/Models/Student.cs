using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Tutorial2.Models
{
    public class Student
    {
        [XmlAttribute(attributeName: "university")]
        public DateTime created_at { get; set; }
        public string author { get; set; }

        [XmlAttribute(attributeName: "students")]
        [XmlElement(elementName: "student")]

        public string IndexNumber { get; set; }
        [XmlElement(elementName:"fname")]
    
        public string FirstName { get; set; }

        private string _lastName;
        public string birthdate { get; set; }
        public string email { get; set; }
        public string mothersname { get; set; }
        public string fatherssname { get; set; }

        [XmlAttribute(attributeName: "studies")]
        [XmlElement(elementName: "name")]
        public string name { get; set; }
        public string mode { get; set; }

        public string LastName { 
            get { return _lastName; } 
            set
            {
                _lastName = value ?? throw new ArgumentException();
            } 
        }

    }
}
