using System.ComponentModel.Design;
using System.Runtime.Intrinsics.X86;

Console.WriteLine("========== ATM =========");
int pin = 1234;
float balance = 22000;
Console.WriteLine("Enter the pin...");
int upin = Convert.ToInt32(Console.ReadLine);
if (upin == pin)
{
    Console.WriteLine("Login Successfull");
    Console.WriteLine("---------------------------");
    Console.WriteLine("Balance  :  " + balance);
    Console.WriteLine("----------------------")


}
else
{
    Console.WriteLine("Invalid pin");
}



