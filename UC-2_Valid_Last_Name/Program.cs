using System;

namespace UC_2_Valid_Last_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pattern pat = new Pattern();
            Console.WriteLine("Enter the Last Name: ");
            string lastname = Console.ReadLine();
            bool name = pat.Validate_LastName(lastname);
            Console.WriteLine(name);
            if (name)
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
