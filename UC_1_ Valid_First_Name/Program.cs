using System;

namespace UC_1__Valid_First_Name
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pattern pat = new Pattern();
            Console.WriteLine("Enter the First Name: ");
            string firstname = Console.ReadLine();
            bool name = pat.Validate_FirstName(firstname);
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
