﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("Please entre the First Name");
            //    String Firstname = Console.ReadLine();
            //    Console.WriteLine("Please entre the Last Name");
            //    String Lastname = Console.ReadLine();
            //    Console.WriteLine("Full Name : {0} {1}", Firstname, Lastname);
            //    Console.ReadLine();
            Console.WriteLine("Please entre the number");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 10)
            {
                Console.WriteLine("TEN");
            }
            else if(input ==20)
            {
                Console.WriteLine("Twenty");
            }
            else
            {
                Console.WriteLine("Not Equql");
            }
            Console.ReadLine();

        }
       
    }
}
