using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Xml;

namespace Theory_Assignment_1
{
    internal class WorkingClass
    {
        int choice;
        ArrayList  Names = new ArrayList();

        public void Menu()
        {
            Console.WriteLine("╔══════════════════════════════════════╗");
            Console.WriteLine("║".PadRight(10) + "STUDENT MANAGEMENT".PadRight(29) + "║");
            Console.WriteLine("╠══════════════════════════════════════╣");
            Console.WriteLine("║ 1 :  Add Name".PadRight(39) + "║");
            Console.WriteLine("║ 2 :  Display Names".PadRight(39) + "║");
            Console.WriteLine("║ 3 :  Remove Name".PadRight(39) + "║");
            Console.WriteLine("║ 4 :  Exit".PadRight(39) + "║");
            Console.WriteLine("╚══════════════════════════════════════╝");

        }

        public void A()
        {
            Console.WriteLine("Select Option");
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the Name...");
                        string? input = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(input))
                        {
                            Console.WriteLine(" -----------------------------------");
                            Console.WriteLine("  ---: Input cannot be Empty :---");
                            Console.WriteLine(" -----------------------------------");

                        }
                        else
                        {
                            bool flag = true;
                            foreach (string n in Names)
                            {
                                // Console.WriteLine(" Reach in Loop");
                                if (string.Equals(input, n?.ToString(), StringComparison.OrdinalIgnoreCase))
                                {
                                    // Console.WriteLine("Name Already Exist");
                                    flag = false;
                                    break;
                                }

                            }
                            if (flag)
                            {
                                Names.Add(input);
                                Console.WriteLine(" -----------------------------------");
                                Console.WriteLine(" ---: " + input + "  Added :---   ");
                                Console.WriteLine("-----------------------------------");
                            }
                            else
                            {
                                Console.WriteLine("-----------------------------------");
                                Console.WriteLine(" ---: " + input + "  Already Exist ---: ");
                                Console.WriteLine("-----------------------------------");
                            }
                        }
                        break;

                    case 2:
                        int totalLength = 0;
                        if (Names.Count == 0)
                        {
                            Console.WriteLine("---------------------------------");
                            Console.WriteLine("   ---: List is Empty  ---: ");
                            Console.WriteLine("---------------------------------");
                        }
                        else
                        {
                            Console.WriteLine("╔═══════════════════════╗");
                            foreach (object list in Names)
                            {
                                //Console.WriteLine("╔═══════════════════════╗");
                                Console.WriteLine("║ * " + list.ToString().PadRight(20) + "║");
                                //Console.WriteLine("╚═══════════════════════╝");
                                totalLength += list.ToString().Length;

                            }
                            Console.WriteLine("╠═══════════════════════╣");
                            double average=(double)totalLength / Names.Count;
                          //  Console.WriteLine("╚═══════════════════════╝");
                            average = Math.Round(average, 2);
                            Console.WriteLine("║ Average Length  " +average+ "║".PadLeft(4) );
                            Console.WriteLine("╚═══════════════════════╝");
                        }
                        break;

                    case 3:
                        string? foundname=null;
                        Console.WriteLine("Enter the Name to be Removed");
                        string? name= Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(name))
                        {
                            Console.WriteLine("-----------------------------------");
                            Console.WriteLine(" ---: Input cannot be Empty :---");
                            Console.WriteLine("-----------------------------------");

                        }
                        bool flag1= true;
                        foreach (string nam in Names)
                        {
                          //  Console.WriteLine("Reach in Loop");
                            if (string.Equals(name, nam?.ToString(),StringComparison.OrdinalIgnoreCase))
                            {
                                // Console.WriteLine("Name Already Exist");
                                 foundname = nam;
                                flag1 = false;
                                break;
                            }

                        }
                        if (flag1)
                        {
                            // Names.Add(name);
                            Console.WriteLine("-----------------------------------");
                            Console.WriteLine(" ---: "+name + " Cannot Find :---");
                            Console.WriteLine("-----------------------------------");
                        }
                        else
                        {
                            Console.WriteLine("-----------------------------------");
                            Names.Remove(foundname);
                            Console.WriteLine("---: "+ name + " Removed :---");
                            Console.WriteLine("-----------------------------------");
                        }


                        break;

                    case 4:
                        Console.WriteLine("--------------------------");
                        Console.WriteLine("    ---: GOOD BYE :---");
                        Console.WriteLine("--------------------------");

                        break;

                }
            }

        }
       
        public void run()
        {
            do
            {
                Menu();
                A();
                Console.WriteLine("Press Enter to Continue");
                Console.ReadLine();
                Console.Clear();
            }while (choice !=4);
        }
            
    }
}
