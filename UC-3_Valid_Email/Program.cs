﻿using System;

namespace UC_3_Valid_Email
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pattern pat = new Pattern();
            Console.WriteLine("Enter the Email Id: ");
            string email = Console.ReadLine();
            bool id = pat.Validate_Email(email);
            Console.WriteLine(id);
            if (id)
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
