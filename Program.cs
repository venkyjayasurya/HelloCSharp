using System;

namespace HelloCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            Console.WriteLine("Hello C Sharp");
            Console.WriteLine(number);

            //datatypes
            byte num=2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Venkatesh";
            bool isWorking = false;

            //for dynamic datatype allocation
            var randomDatatype = "Jayasurya";

            Console.WriteLine(num);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            Console.WriteLine(randomDatatype);
        }
    }
}
