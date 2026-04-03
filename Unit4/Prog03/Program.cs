class Program
{
    static void Main(string[] args)
    {
        Saving s = new Saving();

        s.get_data();

        Console.WriteLine("\n--- Account Details ---");
        s.show();

        s.deposit();
        s.withdraw();

        Console.WriteLine("\n--- Updated Details ---");
        s.show();
    }
}