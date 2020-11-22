using System;
using System.Threading;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
        star: Board br = new Board();
            br.Display();
            
            while(true)
            {
                bool isMoved = true;
                bool gotWinner = false;
                
                while(isMoved)
                {
                    isMoved = br.Player1Moves();
                    isMoved = !isMoved;
                }
                Console.Clear();
                br.Display();
                
                gotWinner = br.PredictWinners();
                
                if(gotWinner == true)
                {
                    Console.Clear();
                    br.Display();
                    br.PredictWinners();
                    Console.WriteLine("Do you want to Reset the game Enetr Yes/No");
                    string input = Console.ReadLine();
                    if (input == "Yes") goto star;
                    else break;
                }

                isMoved = true;
                while (isMoved)
                {
                    isMoved = br.Player2Moves();
                    isMoved = !isMoved;
                }
                Console.Clear();
                br.Display();

                gotWinner = br.PredictWinners();

                if (gotWinner == true)
                {
                    Console.Clear();
                    br.Display();
                    br.PredictWinners();
                    Console.WriteLine("Do you want to Reset the game Enetr Yes/No");
                    string input = Console.ReadLine();
                    if (input == "Yes") goto star;
                    else break;
                }
            }

          
        }
    }
}
