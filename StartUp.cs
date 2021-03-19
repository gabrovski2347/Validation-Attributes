using System;

namespace ValidationAttributes
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var person = new Person(null, 3);

            bool isvalidentity = Validator.IsValid(person);

            Console.WriteLine(isvalidentity);
        }
    }
}
