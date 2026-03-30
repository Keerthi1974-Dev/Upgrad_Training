using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp19
{
    internal class BankAccount
    {
        private string _accountNumber;
        private double _balance;


        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        public double Balance
        {
            get { return _balance; }
        }


        public void Deposit(double amount) // deposit method
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid deposit amount");
                return;
            }

            _balance += amount;
            Console.WriteLine("Deposited: " + amount + " and your Current Balance is: " + _balance);
            
        }


        public void Withdraw(double amount) // withdrawn method
        {
            if (amount <= 0)
            {
                Console.WriteLine(" Amount cannot be negative!");
                return;
            }

            if (amount > _balance)
            {
                Console.WriteLine("Insufficient balance ");
                return;
            }

            _balance -= amount;
            Console.WriteLine(" The Withdrawn: " + amount + "  and your Current Balance: " + _balance);
            
        }

    } 






    }
