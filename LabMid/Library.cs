using System;
using System.Collections.Generic;
using System.Text;

namespace LabMid
{
    internal class Library
    {

        public Book[] books = new Book[5];

        public Book this[int index]
        {
            set
            {
                books[index] = value;

            }
            get
            {
                return books[index];
            }

        }

        public Book this[string title]
        {
            get
            {
                for (int i = 0; i < 5; i++)
                {
                    if (books[i] != null && books[i].title == title)
                    {
                        return books[i];
                    }
                }

                throw new ArgumentOutOfRangeException("book not found");
            }
        }



        public void AddBooks()
        {
            for (int i = 0; i < 5; i++)
            {
                bool valid = false;

                while (!valid)
                {
                    try
                    {
                        Book b = new Book();

                        Console.WriteLine("Enter Book " + (i + 1));

                        Console.Write("Titlee: ");
                        b.title = Console.ReadLine();

                        Console.Write("Authorrr: ");
                        b.author = Console.ReadLine();

                        Console.Write("Priceee: ");
                        b.price = double.Parse(Console.ReadLine());

                        Console.Write("Copies: ");
                        b.copies = int.Parse(Console.ReadLine());

                        if (b.copies < 0)
                        {
                            throw new ArgumentOutOfRangeException

                              ("....Copies cannot be negative.....");
                        }


                        books[i] = b;
                        valid = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter a vald number for Price nddd Copies.");
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        Console.WriteLine("Input attempt finished.");
                    }
                }
            }



        }

        }
    }
