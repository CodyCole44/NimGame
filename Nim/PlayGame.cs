using System;
using System.Collections.Generic;
using System.Text;

namespace Nim
{
    class PlayGame
    {

        public static void GamePlay()
        {
            Player playerOne = new Player();
            Player playerTwo = new Player();
            bool PlayerOnesTurn = true;
            bool OneIsWinner = false;
            bool TwoIsWinner = false;
            var Piles = new SetPiles();


            Console.Write("Player 1, enter your name: ");
            playerOne.Name = Console.ReadLine();

            Console.Write("Player 2, enter your name: ");
            playerTwo.Name = Console.ReadLine();
            Console.WriteLine("");
            
            Console.WriteLine(playerOne.Name + playerTwo.Name);
            Console.WriteLine("A: " + Piles.StackA + "   B: " + Piles.StackB + "   C: " + Piles.StackC);

            while (OneIsWinner == false && TwoIsWinner == false)
            {
                if (PlayerOnesTurn == true)
                {

                    PlayersTurn.Turn(playerOne, Piles);
                    if(Piles.StackA == 0 && Piles.StackB == 0 && Piles.StackC == 0)
                    {
                        TwoIsWinner = true;
                    }
                    PlayerOnesTurn = false;

                }
                else if(PlayerOnesTurn == false)
                {
                    PlayersTurn.Turn(playerTwo, Piles);
                    if (Piles.StackA == 0 && Piles.StackB == 0 && Piles.StackC == 0)
                    {
                        OneIsWinner = true;
                    }
                    PlayerOnesTurn = true;
                }
                else
                {
                    Console.WriteLine("Please select a valid option");
                }
              
            }
            if(OneIsWinner == true)
            {
                Console.WriteLine(playerOne.Name + " there are no counters left, so you win!");
            }
            else if(TwoIsWinner == true)
            {
                Console.WriteLine(playerTwo.Name + " there are no counters left, so you win!");
            }
        }
    }  
            



        
    }
