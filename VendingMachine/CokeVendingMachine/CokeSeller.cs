using System;
using System.Collections.Generic;
using System.Text;

namespace CokeVendingMachine
{
    public static class CokeSeller
    {
        private static int valueReceived = 0;
        private static int DimeCoin = 10;
        private static int QuarterCoin = 25;

        public static Coke Seller()
        {
            Console.WriteLine("Hi! I'm a Coke vending machine. Try me. \n\n");

            Console.WriteLine("Enter the number 1, to insert a $0.10 coin.");
            Console.WriteLine("Enter the number 2, to insert a $0.25 coin. \n");

            valueReceived = 0;

            while (valueReceived < 45)
            {
                Console.WriteLine("Please, give me a coin");
                int.TryParse(Console.ReadLine(), out int input);

                switch(input)
                {
                    case 1:
                        ReceiveCoin(DimeCoin);
                        break;
                    case 2:
                        ReceiveCoin(QuarterCoin);
                        break;
                    default:
                        RejectCoin();
                        break;
                };
                
            }

            Console.WriteLine("Congrats! You bought a coke");
            return new Coke();
        }

        private static void ReceiveCoin(int Value)
        {
            valueReceived += Value;
            Console.WriteLine("\nReceived $" + Value + ". Total Received: $" + valueReceived);
        }

        private static void RejectCoin()
        {
            Console.WriteLine("\nSorry! $0.10 or $0.25 coins only.");
        }
    }
}
