
using System.Runtime.CompilerServices;
using TikTokToeGame;
public class MainClass
{
    public static void Main(string[] args)
    {
        TikTokToe obj = new TikTokToe();
        Console.WriteLine("For Exit Press -2...");
        Console.WriteLine("Press any key to Start");
        int op = Convert.ToInt32(Console.ReadLine());

        while (op != -2)
        {
            obj.printBoard();

            while (!obj.GetHasWin())
            {
                obj.playerTurn();
            }
            Console.WriteLine($"{obj.GetPlayer()} Is The Game Winner ");
        }
        Console.WriteLine("Game End");

        }
    }