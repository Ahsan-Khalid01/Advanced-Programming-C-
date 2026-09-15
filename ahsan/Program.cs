using System.ComponentModel.Design;
using System.Runtime.Intrinsics.X86;

public class A {
    public static void Main(string[] args) {

        Console.WriteLine("========== ATM =========");
        double pin = 1234;
        float balance = 22000;
        Console.WriteLine("Enter the pin...");
        double upin = Convert.ToInt32(Console.ReadLine());
        if (upin == pin)
        {
            Console.WriteLine("Login Successfull");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Balance  :  " + balance);
            Console.WriteLine("----------------------");
        

}
        else
        {
            Console.WriteLine("Invalid pin");
        }

    }
}



