using System;

class Account
{
    protected int account_no;
    protected double balance;

 
    public void get_account()
    {
        Console.Write("Enter Account Number: ");
        account_no = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Balance: ");
        balance = Convert.ToDouble(Console.ReadLine());
    }
    public void display()
    {
        Console.WriteLine("Account Number: " + account_no);
        Console.WriteLine("Balance: " + balance);
    }
}
