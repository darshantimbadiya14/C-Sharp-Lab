/* 
  Definition 03
        Create a class “Account” containing accountNo, and balance as an instance variable .
        Derive the Account class into two classes named “Savings” and “Current”. The“Savings” 
        class should contain instance variable named interest Rate, and the “Current” class 
        should contain an instance variable called overdraft Limit. Define appropriate methods 
        for all the classes to enable functionalities to check balance, deposit, and withdraw amounts 
        in Savings and Current accounts. (Use the concept of Abstract class) 
*/

using System;

class Program
{
    static void Main(string[] args)
    {
     
        Console.WriteLine("---- Savings Account ----");
        Savings s = new Savings();
        s.GetAccountData();
        s.Deposit(500);
        s.Withdraw(300);
        s.CheckBalance();

        Console.WriteLine("\n---- Current Account ----");
        Current c = new Current();
        c.GetAccountData();
        c.Deposit(1000);
        c.Withdraw(1500);
        c.CheckBalance();

        Console.ReadLine();
    }
}