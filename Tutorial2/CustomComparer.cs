using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Tutorial2.Models;

namespace Tutorial2
{

    public class CustomComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {

            return StringComparer
                        .InvariantCultureIgnoreCase
                        .Equals($"{x.IndexNumber} {x.email} {x.FirstName} {x.LastName} {x.birthdate}{x.created_at} {x.author}{x.mothersname }{x.fatherssname}{x.name}{x.mode}",
                                $"{y.IndexNumber} {y.email} {y.FirstName} {y.LastName} {y.birthdate}{y.created_at} {y.author}{y.mothersname }{y.fatherssname}{y.name}{y.mode}");
        }

        public int GetHashCode(Student obj)
        {
            return StringComparer.
                    CurrentCultureIgnoreCase
                    .GetHashCode($"{obj.IndexNumber} {obj.email} {obj.FirstName} {obj.LastName} {obj.birthdate}{obj.created_at} {obj.author}{obj.mothersname }{obj.fatherssname}{obj.name}{obj.mode}");
        }
    }
}
