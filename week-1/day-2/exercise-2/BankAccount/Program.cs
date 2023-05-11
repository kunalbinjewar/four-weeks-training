﻿// See https://aka.ms/new-console-template for more information
using System;

public abstract class BankAccount
{
    public string AccountNumber { get; set; }
    public decimal Balance { get; set; }

    public virtual void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public virtual void Withdraw(decimal amount)
    {
        Balance -= amount;
    }
}

public class SavingsAccount : BankAccount
{
    public decimal InterestRate { get; set; }

    public override void Withdraw(decimal amount)
    {
        if (amount > Balance)
        {
            throw new ArgumentException("Insufficient balance");
        }
        Balance -= amount;
    }

    public decimal CalculateInterest()
    {
        return Balance * InterestRate;
    }
}

public static class Program
{
    public static void Main()
    {
        SavingsAccount savingsAccount = new SavingsAccount();
        savingsAccount.AccountNumber = "1234567890";
        savingsAccount.Balance = 1000; S
        savingsAccount.InterestRate = 0.05m;

        savingsAccount.Deposit(500);
        savingsAccount.Withdraw(200);
        decimal interest = savingsAccount.CalculateInterest();

        Console.WriteLine("Account Number: " + savingsAccount.AccountNumber);
        Console.WriteLine("Balance: " + savingsAccount.Balance);
        Console.WriteLine("Interest: " + interest);
    }
}