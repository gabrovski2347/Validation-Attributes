using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes
{
    using Attributes;

    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        [MyRequiredAttribute]
        public string Name { get; private set; }

        [MyRangeAttribute(12,90)]
        public int Age { get; private set; }
    }
}
