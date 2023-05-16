using System;
using System.Collections.Generic;
using System.Text;

namespace LinqExercise
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public string ID { get; set; }
        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}, Email: {2}", Name, Age, Email);
        }
    }
}
