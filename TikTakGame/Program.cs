using System;

namespace TikTakGame
{
    class Program
    {
        private static char c;
        private static int player;
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = 32;
                }
            }

            Console.WriteLine("Welcome to Tic Tac Toe Game ^^");
            Console.WriteLine("PLAYER1 ({0}) vs PLAYER2 ({1})", 'X', 'O');
            
            
            for (int i = 0; i < 9; i++)
            {
                if (i % 2 == 0)
                {
                    c = 'X';
                    player = 1;
                }
                else
                {
                    c = 'O';
                    player = 2;
                }
                Console.Write("PLAYER{0} Choose your step (1-9): ",player);
                int step = int.Parse(Console.ReadLine());
                switch (step)
                {
                    case 1:
                        arr[0, 0] = c;
                        break;
                    case 2:
                        arr[0, 1] = c;
                        break;
                    case 3:
                        arr[0, 2] = c;
                        break;
                    case 4:
                        arr[1, 0] = c;
                        break;
                    case 5:
                        arr[1, 1] = c;
                        break;
                    case 6:
                        arr[1, 2] = c;
                        break;
                    case 7:
                        arr[2, 0] = c;
                        break;
                    case 8:
                        arr[2, 1] = c;
                        break;
                    case 9:
                        arr[2, 2] = c;
                        break;

                }
                PrintMatrix(arr);
                if (Win(arr, c)==1)
                {
                    break;
                }
                
            }

        }

        static void PrintMatrix(int[,] arr)
        {
             Console.WriteLine("   {0}   |   {1}   |  {2}   ", (char)arr[0,0], (char)arr[0, 1], (char)arr[0, 2]);
             Console.WriteLine("-------*-------*------");
             Console.WriteLine("   {0}   |   {1}   |  {2}   ", (char)arr[1, 0], (char)arr[1, 1], (char)arr[1, 2]);
             Console.WriteLine("-------*-------*------");
             Console.WriteLine("   {0}   |   {1}   |  {2}   ", (char)arr[2, 0], (char)arr[2, 1], (char)arr[2, 2]);
            
        }

        static int Win(int[,] arr,char c)
        {
            if((arr[0,0]==arr[0,1]&& arr[0, 0] == arr[0, 2]&& arr[0, 0] == c)||
                (arr[1, 0] == arr[1, 1] && arr[1, 0] == arr[1, 2] && arr[1, 0] == c)||
                    (arr[2, 0] == arr[2, 1] && arr[2, 0] == arr[2, 2] && arr[2, 0] == c))
            {
                Console.WriteLine("PLAYER1 WIN");
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
