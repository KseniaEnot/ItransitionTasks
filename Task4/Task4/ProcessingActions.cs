using System;

namespace Task4
{
    public class ProcessingActions
    {
        public static void Main(String[] args)
        {
            if ((args.Length < 3) || (args.Length % 2 == 0)) //bez povtoreni!!!
            {
                Console.WriteLine("Encorrect line. Try again.");
                return;
            }
            Random random = new Random();
            int systMove = random.Next(args.Length);
            EncryptionHandler crypto = new EncryptionHandler();
            byte[] hmac = crypto.GetHmac(systMove);
            Console.Write("HMAC: ");
            foreach (var item in hmac)
                Console.Write(item.ToString("X2"));
            //Console.WriteLine();
            int userMove = MenuOperation.printMenu(args)-1;
            Console.WriteLine($"Your move: {args[userMove]}");
            Console.WriteLine($"Computer move: {args[systMove]}");
            switch (Jury.DeterminingWinner(systMove,userMove,args.Length))
            {
                case 1:Console.WriteLine("\nYou WIN!");  break;
                case -1: Console.WriteLine("\nYou LOSE :( !"); break;
                case 0: Console.WriteLine("\nDRAW!"); break;
            }
            Console.WriteLine("HMAC key: ");
            crypto.PrintKey();
        }

    }
}
