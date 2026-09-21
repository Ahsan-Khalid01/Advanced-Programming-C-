using System;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
namespace LAB3;


public class A
{

    private string? name ;
    private string? fname;
    public static void menu()
    {
        Console.WriteLine("=====================\n 1 > Setter Getter\n 2 > Exception Handling\n 3 > Indexer");

    }

    public void SetName(string name) 
    { 
        this.name = name;
        //this.fname = fname;

    }
    public void SetFname(string fname)
    {
        this.fname = fname;
    }
    public string Getname()
    {
        return name!;
       
    }
    public string GetFname()
    {
        return fname!;

    }



    public static void Main(string[] args)
    {
        menu();
     Console.WriteLine(" Enter Choice");
      int ch = Convert.ToInt32(Console.ReadLine());
        switch (ch)
        {


            case 1:
                A obj = new A();
                obj.SetName("Ahsan ");
                obj.SetFname("Khalid");
                Console.WriteLine("Value Set\n Press Enter To Print ");
               
                Console.ReadLine();
                Console.WriteLine("Name  : " + obj.fname  + "Father Name : "+obj.fname);
                break;
            case 2 :

                break;

            case 3:

                break;
        }
                

                
        
        

    }




}

