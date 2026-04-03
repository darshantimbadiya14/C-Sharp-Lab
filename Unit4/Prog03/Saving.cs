class Saving : Account
{
    double interest_rate;

    public void get_data()
    {
        get_account();

        Console.Write("Enter Interest Rate: ");
        interest_rate = Convert.ToDouble(Console.ReadLine());
    }
    public void show()
    {
        display();
        Console.WriteLine("Interest Rate: " + interest_rate + "%");
    }
    public void deposit()
    {
        double amt;
        Console.Write("Enter amount to deposit: ");
        amt = Convert.ToDouble(Console.ReadLine());

        balance += amt;
        Console.WriteLine("Amount Deposited Successfully!");
    }

    public void withdraw()
    {
        double amt;
        Console.Write("Enter amount to withdraw: ");
        amt = Convert.ToDouble(Console.ReadLine());

        if (amt <= balance)
        {
            balance -= amt;
            Console.WriteLine("Withdrawal Successful!");
        }
        else
        {
            Console.WriteLine("Insufficient Balance!");
        }
    }
}
