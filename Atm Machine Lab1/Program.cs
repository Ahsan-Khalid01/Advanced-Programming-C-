
using System.Transactions;

public class ATM
{
    static void Heading()
    {

        Console.WriteLine("===============================");
        Console.WriteLine("|       ---: ATM :---         |\n===============================");
    }
    static void Exit()
    {
        Console.Clear();
        Heading();
        Console.WriteLine("Thank you for using ATM.");
        ending();
        Environment.Exit(0);
    }
    static void ending() { Console.WriteLine("\n==============================="); }
    static void Main()
    {
        string pin = "1234";
        Double bal = 25000.0;

        Heading();
        Console.WriteLine(" Start ATM\n\n Press Enter To Contiue");
        ending();
        Console.ReadLine();
        Console.Clear();
        Heading();
        Console.WriteLine(" Insert Card\n\n Press Enter to Continue");
        ending();
        Console.ReadLine();
        Console.Clear();
        Heading();
        Console.WriteLine(" Enter Pin....");
        ending();
        string upin = Console.ReadLine() ?? "";
        
        if (upin != pin)
        {
            Console.Clear();
            Heading();
            Console.WriteLine(" Invalid Pin");
            Console.WriteLine("\n Press Enter To Try Again");
            ending();
            Console.ReadLine();
            Console.Clear();
            Main();
            
        }
        else if (pin == upin)
        {
            Console.Clear();
            Heading();
            menu();

            void menu()
            {
                int ch1;
                Console.WriteLine(" 1 > Balance\n 2 > WithDraw\n 3 > Transfer\n 4> Change Pin");
                ending();
                int ch = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Heading();

                if (ch == 1)
                {
                    Console.WriteLine(" Balance : " + bal);
                    Console.WriteLine("\n 1 > Back\n 2 > Exit");
                    ending();
                    ch1 = Convert.ToInt32(Console.ReadLine());
                    if (ch1 == 1) { Console.Clear(); Heading(); menu(); }
                    else if (ch1 == 2) { Exit(); }
                    
                   

                }
                else if (ch == 2)
                {
                    Console.Clear();
                    Heading();
                    Console.WriteLine(" Enter Amount ");
                    ending();
                    double amt = Convert.ToDouble(Console.ReadLine());
                    if (amt <= bal)
                    {
                        Console.Clear(); Heading(); Console.WriteLine(" RS : " + amt + "    WithDraw Successfully");
                        Console.WriteLine("\n Remaining Balance is  RS : " + (bal - amt));
                        Console.WriteLine("\n 1 > Back\n 2 > Exit");
                        ending();
                        ch1 = Convert.ToInt32(Console.ReadLine());
                        if (ch1 == 1)
                        { 
                            Console.Clear(); Heading(); menu();
                        }
                        else if (ch1 == 2)
                        { 
                            Exit();
                        }
                    }
                    else if (amt > bal) 
                    { 
                        Console.Clear(); Heading();
                        Console.WriteLine(" InSufficient Balance ");
                        Console.WriteLine("\n 1 > Back\n 2 > Exit");
                        ending();
                        ch1 = Convert.ToInt32(Console.ReadLine());
                        if (ch1 == 1) 
                        { 
                            Console.Clear(); Heading(); menu();
                        }
                        else if (ch1 == 2) 
                        { 
                            Exit();
                        }
                    }
                    else {
                        Console.Clear(); Heading();
                        Console.WriteLine("Invalid Amount");
                        Console.WriteLine("\n 1 > Back\n 2 > Exit");
                        ending();
                        ch1 = Convert.ToInt32(Console.ReadLine());
                        if (ch1 == 1)
                        {
                            Console.Clear(); Heading(); menu();
                        }
                        else if (ch1 == 2)
                        {
                            Exit(); ending();
                        }
                        
                    }

                }

                else if (ch == 3) 
                { 
                    Console.Clear(); Heading();
                    Console.WriteLine(" Enter 14 digit Account Number\n ");
                    ending();
                    String accNo=Console.ReadLine()?? "";
                    if (accNo.Length == 14)
                    {
                        Console.Clear(); Heading();
                        Console.WriteLine(" Enter Amount");
                        ending();
                        Double amount = Convert.ToDouble(Console.ReadLine());
                        if (amount <= bal)
                        {
                            Console.Clear(); Heading();
                            Console.WriteLine(" RS : " + amount + "   Transfer SuccessFully \n To "+accNo);
                            Console.WriteLine("\n New Account Balance is  : " + (bal - amount));
                            Console.WriteLine("\n 1 > Back\n 2 > Exit");
                                ending(); 
                            ch1 = Convert.ToInt32(Console.ReadLine());
                            if (ch1 == 1)
                            { 
                                Console.Clear(); Heading(); menu();
                            }
                            else if (ch1 == 2) 
                            {
                                Exit(); ending();
                            }

                        }
                    }
                    else if (accNo.Length > 14 || accNo.Length < 14)
                    {
                        Console.Clear(); Heading();
                        Console.WriteLine(" Account Number Must be 14 Digit ");
                        Console.WriteLine("\n 1 > Back\n 2 > Exit"); ending();
                        ch1 = Convert.ToInt32(Console.ReadLine());
                        if (ch1 == 1) 
                        {
                            Console.Clear(); Heading(); menu(); 
                        }
                        else if (ch1 == 2)
                        {
                            Exit(); ending();
                        }


                    }
             
                
                }else if(ch == 4)
                {
                    Console.Clear(); Heading();
                    Console.WriteLine(" Enter Old Pin "); ending(); 
                    string opin = Console.ReadLine() ?? "";
                    if(opin == pin)
                    {
                        Console.Clear(); Heading();

                        Console.WriteLine(" Enter New Pin " );
                        string newpin1 = Console.ReadLine() ?? "";
                        Console.WriteLine(" Re Enter New Pin "); ending();
                        string newpin2 = Console.ReadLine() ?? "";

                        if (newpin1 == newpin2)
                        {
                            Console.Clear(); Heading(); Console.WriteLine(" Pin Changed SuccessFully  ");
                            Console.WriteLine("\n 1 > Back\n 2 > Exit"); ending();
                            ch1 = Convert.ToInt32(Console.ReadLine());
                            if (ch1 == 1) 
                            {
                                Console.Clear(); Heading(); menu();
                            }
                            else if (ch1 == 2) 
                            { 
                                Exit(); ending();
                            }


                        }else 
                        {
                            Console.Clear(); Heading();
                            Console.WriteLine(" Pin MisMatch ");
                            Console.WriteLine("\n 1 > Back\n 2 > Exit"); ending();
                            ch1 = Convert.ToInt32(Console.ReadLine());
                            if (ch1 == 1)
                            {
                                Console.Clear(); Heading(); menu();
                            }
                            else if (ch1 == 2)
                            { 
                                Exit(); ending(); 
                            }
                        }

                    }else
                    {
                        Console.Clear(); Heading();
                        Console.WriteLine(" InValid Pin ");
                        Console.WriteLine("\n 1 > Back\n 2 > Exit"); ending();
                        ch1 = Convert.ToInt32(Console.ReadLine());
                        if (ch1 == 1)
                        {
                            Console.Clear(); Heading(); menu();
                        }
                        else if (ch1 == 2)
                        { Exit(); ending(); }

                    }



                }
               
            }






            }

        }
    }
