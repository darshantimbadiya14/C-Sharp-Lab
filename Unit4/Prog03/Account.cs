﻿using System;

public abstract class Account
{
    public int accountNo;
    public double balance;

    public void GetAccountData()
    {
        Console.Write("Enter Account Number: ");
        accountNo = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Balance: ");
        balance = Convert.ToDouble(Console.ReadLine());
    }

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine("Deposited: " + amount);
    }

    public abstract void Withdraw(double amount);

    public void CheckBalance()
    {
        Console.WriteLine("Balance: " + balance);
    }
}