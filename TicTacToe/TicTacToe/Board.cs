using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Board
    {
        static char[,] board;
        bool[,] IsChecked;

        public Board()
        {
            board = new char[3, 3]
            { {'1','2','3'},
              {'4','5','6'},
              {'7','8','9'}
            };

            IsChecked = new bool[3, 3]
            {
                {false,false,false},
                {false,false,false},
                {false,false,false}
            };


        }

        public bool Player1Moves()
        {
            Console.WriteLine("Player 1: choose your field");
            string input = Console.ReadLine();

            int BoxIndex = -1;
            bool isValid = int.TryParse(input, out BoxIndex);


            if (isValid && BoxIndex <= 9 && BoxIndex >= 1)
            {
                if (BoxIndex == 1 && IsChecked[0, 0] == false)
                {
                    board[0, 0] = '0';
                    return true;
                }
                if (BoxIndex == 2 && IsChecked[0, 1] == false)
                {
                    board[0, 1] = '0';
                    return true;
                }
                if (BoxIndex == 3 && IsChecked[0, 2] == false)
                {
                    board[0, 2] = '0';
                    return true;
                }
                if (BoxIndex == 4 && IsChecked[1, 0] == false)
                {
                    board[1, 0] = '0';
                    return true;
                }
                if (BoxIndex == 5 && IsChecked[1, 1] == false)
                {
                    board[1, 1] = '0';
                    return true;
                }
                if (BoxIndex == 6 && IsChecked[1, 2] == false)
                {
                    board[1, 2] = '0';
                    return true;
                }
                if (BoxIndex == 7 && IsChecked[2, 0] == false)
                {
                    board[2, 0] = '0';
                    return true;
                }
                if (BoxIndex == 8 && IsChecked[2, 1] == false)
                {
                    board[2, 1] = '0';
                    return true;
                }
                if (BoxIndex == 9 && IsChecked[2, 2] == false)
                {
                    board[2, 2] = '0';
                    return true;
                }
                else
                {
                    Console.WriteLine("Already Checked");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Not a valid field");
                return false;
            }
        }


        public bool Player2Moves()
        {
            Console.WriteLine("Player 2: choose your field");
            string input = Console.ReadLine();

            int BoxIndex = -1;
            bool isValid = int.TryParse(input, out BoxIndex);


            if (isValid && BoxIndex <= 9 && BoxIndex >= 1)
            {
                if (BoxIndex == 1 && IsChecked[0, 0] == false)
                {
                    board[0, 0] = 'X';
                    return true;
                }
                if (BoxIndex == 2 && IsChecked[0, 1] == false)
                {
                    board[0, 1] = 'X';
                    return true;
                }
                if (BoxIndex == 3 && IsChecked[0, 2] == false)
                {
                    board[0, 2] = 'X';
                    return true;
                }
                if (BoxIndex == 4 && IsChecked[1, 0] == false)
                {
                    board[1, 0] = 'X';
                    return true;
                }
                if (BoxIndex == 5 && IsChecked[1, 1] == false)
                {
                    board[1, 1] = 'X';
                    return true;
                }
                if (BoxIndex == 6 && IsChecked[1, 2] == false)
                {
                    board[1, 2] = 'X';
                    return true;
                }
                if (BoxIndex == 7 && IsChecked[2, 0] == false)
                {
                    board[2, 0] = 'X';
                    return true;
                }
                if (BoxIndex == 8 && IsChecked[2, 1] == false)
                {
                    board[2, 1] = 'X';
                    return true;
                }
                if (BoxIndex == 9 && IsChecked[2, 2] == false)
                {
                    board[2, 2] = 'X';
                    return true;
                }
                else
                {
                    Console.WriteLine("Already Checked");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Not a valid field");
                return false;
            }
        }

        public bool PredictWinners()
        {
            //Rows
            if (board[0, 0] == '0' && board[0, 1] == '0' && board[0, 2] == '0')
            {
                Console.WriteLine("Player 1 won");
                return true;
            }
            if (board[0, 0] == 'X' && board[0, 1] == 'X' && board[0, 2] == 'X')
            {
                Console.WriteLine("Player 2 won");
                return true;
            }

            if (board[1, 0] == '0' && board[1, 1] == '0' && board[1, 2] == '0')
            {
                Console.WriteLine("Player 1 won");
                return true;
            }
            if (board[1, 0] == 'X' && board[1, 1] == 'X' && board[1, 2] == 'X')
            {
                Console.WriteLine("Player 2 won");
                return true;
            }

            if (board[2, 0] == '0' && board[2, 1] == '0' && board[2, 2] == '0')
            {
                Console.WriteLine("Player 1 won");
                return true;
            }
            if (board[2, 0] == 'X' && board[2, 1] == 'X' && board[2, 2] == 'X')
            {
                Console.WriteLine("Player 2 won");
                return true;
            }
            //Columns
            if (board[0, 0] == '0' && board[1, 0] == '0' && board[2, 0] == '0')
            {
                Console.WriteLine("Player 1 won");
                return true;
            }
            if (board[0, 0] == 'X' && board[1, 0] == 'X' && board[2, 0] == 'X')
            {
                Console.WriteLine("Player 2 won");
                return true;
            }
            if (board[0, 1] == '0' && board[1, 1] == '0' && board[2, 1] == '0')
            {
                Console.WriteLine("Player 1 won");
                return true;
            }
            if (board[0, 1] == 'X' && board[1, 1] == 'X' && board[2, 1] == 'X')
            {
                Console.WriteLine("Player 2 won");
                return true;
            }

            if (board[0, 2] == '0' && board[1, 2] == '0' && board[2, 2] == '0')
            {
                Console.WriteLine("Player 1 won");
                return true;
            }
            if (board[0, 2] == 'X' && board[1, 2] == 'X' && board[2, 2] == 'X')
            {
                Console.WriteLine("Player 2 won");
                return true;
            }

            //Diagonals 
            if (board[0, 0] == '0' && board[1, 1] == '0' && board[2, 2] == '0')
            {
                Console.WriteLine("Player 1 won");
                return true;
            }
            if (board[0, 0] == 'X' && board[1, 1] == 'X' && board[2, 2] == 'X')
            {
                Console.WriteLine("Player 2 won");
                return true;
            }

            if (board[2, 0] == '0' && board[1, 1] == '0' && board[0, 2] == '0')
            {
                Console.WriteLine("Player 1 won");
                return true;
            }
            if (board[2, 0] == 'X' && board[1, 1] == 'X' && board[0, 2] == 'X')
            {
                Console.WriteLine("Player 2 won");
                return true;
            }

            return false;

        }

        public  void Display()
        {
            for(int i =0; i<3; i++)
            {
                Console.WriteLine();
                Console.WriteLine("__ __ __");
                Console.WriteLine();
                for (int j= 0; j < 3; j++)
                {
                    Console.Write(board[i, j]);
                    Console.Write(" ");
                    Console.Write("|");
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("__ __ __");
            Console.WriteLine();
        }
    }
}
