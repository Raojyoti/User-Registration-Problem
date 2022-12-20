using System;

namespace UC_4_Mobile_Format
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pattern pat = new Pattern();
            Console.WriteLine("Enter the Phone Number: ");
            string phonenumber = Console.ReadLine();
            bool num = pat.Validate_PhoneNumber(phonenumber);
            Console.WriteLine(num);
            if (num)
            {
                Console.WriteLine("correct match");
            }
            else
            {
                Console.WriteLine("Wrong match");
            }
        }
    }
}
