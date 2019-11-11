using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            int Cash = 5000;
            int BitcoinBalance = 0;
            decimal EtheriumBalance = 0;
            decimal LitecoinBalance = 0;

            int Bitcoin = 7480;
            decimal Etherium = 586.15m;
            decimal Litecoin = 119.04m;

            Console.WriteLine("Cash Account: " + Cash);
            Console.WriteLine("Bitcoin Account: " + BitcoinBalance);
            Console.WriteLine("Etherium Account: " + EtheriumBalance);
            Console.WriteLine("Litecoin Account: " + LitecoinBalance);

            Console.WriteLine("Purchase Digital currency: a\nSell digital currency: b\nView all accounts: c\nTansfer between digital currency type: d");
            ConsoleKey userChoice = Console.ReadKey(true).Key;
            Console.Clear();

            switch (userChoice)
            {
                case ConsoleKey.A:
                    Console.WriteLine("Purchase Bitcoin: a\nPurchase Etherium: b\nPurchase Litecoin: c\nBack: d");
                    ConsoleKey userChoice2 = Console.ReadKey(true).Key;
                    Console.Clear();
                    Console.WriteLine("How much?");
                    string input = Console.ReadLine();
                    decimal amount = decimal.Parse(input);
                    switch (userChoice2)
                    {
                        case ConsoleKey.A:
                            if (Cash < (Bitcoin * amount))
                            {
                                Console.WriteLine("Insufficient Funds");
                            }
                            else
                            {
                                decimal newBalance = Cash - (Bitcoin * amount);
                                Console.WriteLine($"You now have {newBalance:c} left in your account.\nYou have {BitcoinBalance + amount} Bitcoin in your account.");
                            }
                            break;
                        case ConsoleKey.B:
                            if (Cash < (Etherium * amount))
                            {
                                Console.WriteLine("Insufficient Funds");
                            }
                            else
                            {
                                decimal newBalance = Cash - (Etherium * amount);
                                Console.WriteLine($"You now have {newBalance:c} left in your account.\nYou have {EtheriumBalance + amount} in your account.");
                            }
                            break;
                        case ConsoleKey.C:
                            if (Cash < (Litecoin * amount))
                            {
                                Console.WriteLine("Insufficient Funds");
                            }
                            else
                            {
                                decimal newBalance = Cash - (Litecoin * amount);
                                Console.WriteLine($"You now have {newBalance:c} left in your account.\nYou have {Litecoin + amount} in your account.");
                            }
                            break;

                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }


        }
    }
}
