using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Bank
    {
        private string Name;
        private int month;
        private double balance;
        private double procent;

        private string[] coments = new string[100];
        private int comentsIndex;

        public Bank(string UserName = "User", int UserMonth = 0, double UserBalance = 0.0, double UserProcent = 0.0)
        {
            Name = UserName;
            month = UserMonth;
            balance = UserBalance;
            procent = UserProcent;

            Print();
            ShowComment();
        }

        public double FinalBalance()
        {
            return ((balance * (procent / 100) / 365 * 30) * month) + balance;
        }

        public void Print()
        {
            Console.WriteLine($"Account Name: {Name}");
            Console.WriteLine($"Start balance: {balance}");
            Console.WriteLine($"Procent: {procent}");
            Console.WriteLine($"Months: {month}");
            Console.WriteLine($"Final balance: {FinalBalance()} \n");
        }

        public void AddComment(string coment)
        {
            if (comentsIndex < 100)
            {
                coments[comentsIndex] = coment;
                comentsIndex++;
                Console.WriteLine($"{Name} add comments: {coment}");
            }
            else
            {
                Console.WriteLine("Archive is full");
            }
        }

        public void ShowComment()
        {
            Console.WriteLine($"Comments form {Name}: ");
            for (int i = 0; i < comentsIndex; i++)
            {
                Console.WriteLine(coments[i]);
            }
        }
    }
}
