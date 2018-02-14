using System;
using System.Collections.Generic;
using System.Text;

namespace Nim
{
    class PlayersTurn
    {
        public static string PlayersPileChoice;
        public static int PlayersAmountChoice;

        public static void Turn(Player Player, SetPiles Piles)
        {
            Console.Write(Player.Name + " choose a pile: ");
            PlayersPileChoice = Console.ReadLine();
            PlayersPileChoice = PlayersPileChoice.ToUpper();

            if (PlayersPileChoice == "A")
                {
                Console.Write("How many to remove from pile A: ");
                PlayersAmountChoice = Convert.ToInt32(Console.ReadLine());
                if (PlayersAmountChoice > 0)
                {
                    if (PlayersAmountChoice > Piles.StackA)
                    {
                        Console.WriteLine("There is not that many left. Please choose again.");
                        Turn(Player, Piles);
                    }
                    else
                    {
                        Piles.StackA = Piles.StackA - PlayersAmountChoice;
                        Console.WriteLine("A: " + Piles.StackA + "   B: " + Piles.StackB + "   C: " + Piles.StackC);
                    }
                }
                else
                {
                    Console.WriteLine("Please select a positive Integer");
                    Turn(Player, Piles);
                }
                }
            else if(PlayersPileChoice =="B")
            {
                Console.Write("How many to remove from pile B: ");
                PlayersAmountChoice = Convert.ToInt32(Console.ReadLine());
                if (PlayersAmountChoice > 0)
                {
                    if (PlayersAmountChoice > Piles.StackB)
                    {
                        Console.WriteLine("There is not that many left. Please choose again.");
                        Turn(Player, Piles);
                    }
                    else
                    {
                        Piles.StackB = Piles.StackB - PlayersAmountChoice;
                        Console.WriteLine("A: " + Piles.StackA + "   B: " + Piles.StackB + "   C: " + Piles.StackC);
                    }
                }
                else
                {
                    Console.WriteLine("Please select a positive Integer");
                    Turn(Player, Piles);
                }
            }
            else if(PlayersPileChoice == "C")
            {
                Console.Write("How many to remove from pile C: ");
                PlayersAmountChoice = Convert.ToInt32(Console.ReadLine());
                if (PlayersAmountChoice > 0)
                {
                    if (PlayersAmountChoice > Piles.StackC)
                    {
                        Console.WriteLine("There is not that many left. Please choose again.");
                        Turn(Player, Piles);
                    }
                    else
                    {
                        Piles.StackC = Piles.StackC - PlayersAmountChoice;
                        Console.WriteLine("A: " + Piles.StackA + "   B: " + Piles.StackB + "   C: " + Piles.StackC);
                    }
                }
                else
                {
                    Console.WriteLine("Please select a positive Integer");
                    Turn(Player, Piles);
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid amount");
                Turn(Player, Piles);
            }
        }
    }
}

