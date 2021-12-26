using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class MenuOperation
    {
        public static int printMenu(String[] moves)
        {
            int move = -1;
            while (move == -1)
            {
                Console.WriteLine("\nAvailable moves:\n0 -- Exit");
                for (int i = 1; i <= moves.Length; i++)
                    Console.WriteLine(i + " -- " + moves[i - 1]);
                Console.Write("Enter your move: ");
                move = readMove(moves.Length);
            }
            if (move == 0)
                Environment.Exit(0);
            return move;
        }

        private static int readMove(int maxValue)
        {
            String moveString = Console.ReadLine();
            int move;
            try
            {
                move = Convert.ToInt32(moveString);
            }
            catch (Exception)
            {
                Console.WriteLine("Encorrect line. Try again.");
                return -1;
            }
            if((move > maxValue)||(move < 0))
            {
                Console.WriteLine("Encorrect line. Try again.");
                return -1;
            }
            return move;
        }
    }
}
