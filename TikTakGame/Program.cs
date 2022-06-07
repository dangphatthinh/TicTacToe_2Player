using System;

namespace TikTakGame
{
    class Program
    {
        private static char c;
        private static int player;
        Random random = new Random();

        static void Main(string[] args)
        {
            int[] arr = new int[9];
            for (int i = 0; i < 9; i++)
            {
                 arr[i] = 32;
            }

            Console.WriteLine("Welcome to Tic Tac Toe Game ^^");
            Console.WriteLine("PLAYER1 ({0}) vs PLAYER2 ({1})", 'X', 'O');
            Console.WriteLine("Press any key to start the game");
            Console.ReadKey();
            Console.Clear();
            
            for (int i = 0; i < 9; i++)
            {
                if (i % 2 == 0){
                    c = 'X';
                    player = 1;
                }
                else{
                    c = 'O';
                    player = 2;
                }
                if (i == 0) { PrintMatrix(arr); } 

                RET:  Console.Write("PLAYER{0}({1}) Choose your step (1-9): ", player,c);
                int step = int.Parse(Console.ReadLine());
                if (arr[step-1] == 'X'|| arr[step-1]=='O')
                {
                    Console.WriteLine("Your step has already exist, Please try another step");
                    goto RET;
                }
                arr[step - 1] = c;
                Console.Clear();
                PrintMatrix(arr);

                if (Win(arr, c) == 1) { return; };                    
                if (i == 8) { 
                    Console.WriteLine("PLAYER1 HOA PLAYER2");
                    return;
                }
            }
        }

        static void PrintMatrix(int[] arr)
        {
             Console.WriteLine("   {0}   |   {1}   |  {2}   ", (char)arr[0], (char)arr[1], (char)arr[2]);
             Console.WriteLine("-------*-------*------");
             Console.WriteLine("   {0}   |   {1}   |  {2}   ", (char)arr[3], (char)arr[4], (char)arr[5]);
             Console.WriteLine("-------*-------*------");
             Console.WriteLine("   {0}   |   {1}   |  {2}   ", (char)arr[6], (char)arr[7], (char)arr[8]);
            
        }

        static int Win(int[] arr, char c)
        {
            if ((arr[0] == arr[1] && arr[0] == arr[2] && arr[0] == c)||
                (arr[3] == arr[4] && arr[3] == arr[5] && arr[3] == c)||
                (arr[6] == arr[7] && arr[6] == arr[8] && arr[6] == c)||
                (arr[0] == arr[3] && arr[0] == arr[6] && arr[0] == c)||
                (arr[1] == arr[4] && arr[1] == arr[7] && arr[1] == c)||
                (arr[2] == arr[5] && arr[2] == arr[8] && arr[2] == c)||
                (arr[0] == arr[4] && arr[0] == arr[8] && arr[0] == c)||
                (arr[2] == arr[4] && arr[2] == arr[6] && arr[2] == c))
            {
                if (c == 'X'){
                    Console.WriteLine("PLAYER1 WIN");
                }
                else { 
                    Console.WriteLine("PLAYER2 WIN");
                }
                return 1;
            }
            else { return 0; }           
        }
    }
}
