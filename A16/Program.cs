﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace A16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount a1 = new BankAccount("Eva", 123);
           

            Console.WriteLine($"details of account 1 :\nAccount holder name :{a1.A_name}\nAccount number : {a1.A_no}");
            Console.WriteLine("Enter the Amount you want to deposit ");
            a1.Deposit(double.Parse(Console.ReadLine()));
            Console.WriteLine("Enter how much amount you want to with draw");
            a1.Withdraw(double.Parse(Console.ReadLine()));

            BankAccount a2 = new BankAccount("Alen", 321);


            Console.WriteLine($"\n\n\n\ndetails of account 2 :\nAccount holder name :{a2.A_name}\nAccount number : {a2.A_no}");
            Console.WriteLine("Enter the Amount you want to deposit ");
            a2.Deposit(double.Parse(Console.ReadLine()));
            Console.WriteLine("Enter how much amount you want to with draw");
            a2.Withdraw(double.Parse(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
