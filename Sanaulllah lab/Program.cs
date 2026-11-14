class Program
{
    static void Main()
    {
        Console.WriteLine("==ATM==");
        Console.WriteLine("ENTERPIN");
        String pin = Console.ReadLine() ?? "";
        if (pin.Length == 5)
        {
            Console.WriteLine("TRUE");
        }
        else
        {
            Console.WriteLine("FALSE");
        }
    }
}
