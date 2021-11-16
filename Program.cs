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

            Console.WriteLine("{0} {1}", num, firstName);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            const float Pi = 3.14f;
            //Pi = 1;

            float f = 1.0f;
            int i = (int)f;

            string s = "1234";
            int i = Convert.ToInt32(s);
            int j = int.Parse(s);


        }
    }
}
