using System;
using System.Collections.Generic;
using System.Text;

namespace TikTokToeGame
{
    internal class TikTokToe
    {
        private int[,] Board = new int[3, 3];
        private int player;
        private bool hasWin;
        public TikTokToe()
        {
            this.hasWin = false;
            this.player = 0;

            int value = 1;
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    Board[i, j] = value;
                    value++;

                }
            }
        }


        public int GetPlayer()
        {
            return this.player;
        }
        public Boolean GetHasWin()
        {
            return this.hasWin;
        }



        public void printBoard()
        {
            //Console.WriteLine("-----------------------");

            for (int i = 0; i < Board.GetLength(0); i++)
            {
                Console.WriteLine("----------------------");
                Console.Write("|");
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    Console.Write("".PadLeft(3) + Board[i, j] + "  |");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------");
        }


        public void playerTurn()
        {
            int possition = Convert.ToInt32(Console.ReadLine());
            if (possition == -2)
            {
                Console.WriteLine("Game End");
            }

            Console.WriteLine($".......Turn of PLayer   {this.player}"+" ........");
            Console.WriteLine("Enter The Possition");
           // int possition = Convert.ToInt32(Console.ReadLine());
             
            //if(possition == -2)
            //{
            //    Console.WriteLine("Game End");
            //}

            if (possition >= 1 && possition <= 9)
            {

                int row = (possition - 1) / 3;
                int col = (possition - 1) % 3;

                if (this.Board[row, col] != 0 && this.Board[row, col] != -1)
                {

                    this.Board[row, col] = this.player;

                    this.checkWinner();
                    this.printBoard();
                    

                    if (!this.hasWin)
                    {
                        if (this.player == 0)
                        {
                            this.player = -1;
                        }
                        else
                        {
                            this.player = 0;
                        }

                        //this.printBoard();
                        //this.checkWinner();
                    }

                }
                else
                {
                    Console.WriteLine("Possiton Already Occupied");

                }

            }

            else
            {
                Console.WriteLine("Invalid Input");
            }

        }











































        public void checkWinner()
        {
            //rows
            if (this.Board[0, 0] == 0 && this.Board[0, 1] == 0 && this.Board[0, 2] == 0 || this.Board[0, 0] == -1 && this.Board[0, 1] == -1 && this.Board[0, 2] == -1)
            {
                this.hasWin = true;
            }

            if (this.Board[1, 0] == 0 && this.Board[1, 1] == 0 && this.Board[1, 2] == 0 || this.Board[1, 0] == -1 && this.Board[1, 1] == -1 && this.Board[1, 2] == -1)
            {
                this.hasWin = true;
            }

            if (this.Board[2, 0] == 0 && this.Board[2, 1] == 0 && this.Board[2, 2] == 0 || this.Board[2, 0] == -1 && this.Board[2, 1] == -1 && this.Board[2, 2] == -1)
            {
                this.hasWin = true;
            }


            //colmn

            if (this.Board[0, 0] == 0 && this.Board[1, 0] == 0 && this.Board[2, 0] == 0 || this.Board[0, 0] == -1 && this.Board[1, 0] == -1 && this.Board[2, 0] == -1)
            {
                this.hasWin = true;
            }

            if (this.Board[0, 1] == 0 && this.Board[1, 1] == 0 && this.Board[2, 1] == 0 || this.Board[0, 1] == -1 && this.Board[1, 1] == -1 && this.Board[2, 1] == -1)
            {
                this.hasWin = true;
            }

            if (this.Board[0, 2] == 0 && this.Board[1, 2] == 0 && this.Board[2, 2] == 0 || this.Board[0, 2] == -1 && this.Board[1, 2] == -1 && this.Board[2, 2] == -1)
            {
                this.hasWin = true;
            }


            //daignal

            if (this.Board[0, 0] == 0 && this.Board[1, 1] == 0 && this.Board[2, 2] == 0 || this.Board[0, 0] == -1 && this.Board[1, 1] == -1 && this.Board[2, 2] == -1)
            {
                this.hasWin = true;
            }

            if (this.Board[0, 2] == 0 && this.Board[1, 1] == 0 && this.Board[2, 0] == 0 || this.Board[0, 2] == -1 && this.Board[1, 1] == -1 && this.Board[2, 0] == -1)
            {
                this.hasWin = true;
            }

           


        }



    }
}
