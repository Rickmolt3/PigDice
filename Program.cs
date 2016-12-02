using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDice
{
    class Program
    {
        /// <summary>
        /// entry point to the code
        /// </summary>
        /// <param name="args"></param>

     
        static void Main(string[] args)
        {
            //first method to run in the program
            initialize();
            gameTime();
            

        }
        static void initialize()
        {
            Console.WriteLine("Hello player 1 please write your name below (max two players).");
            string userNameGlobal = Console.ReadLine();
            Console.WriteLine("Hello player 2 please write your name below (max two players).");
            string userNameGlobal2 = Console.ReadLine();
            Console.WriteLine("Hello " + userNameGlobal + " and "+ userNameGlobal2 + " welcome to pig dice!");
            Console.WriteLine("Every time you roll you will have the opportunity to hold and keep your score");
            Console.WriteLine("If you happen to roll a 1 all the points you scored in the turn will be wiped away");
            Console.WriteLine("The first player to get to 50 wins the game");
            Console.WriteLine("Press the any key to begin and have a good time and good luck");
            Console.ReadKey();
            Console.Clear();
        }
        static void gameTime()
        {
            int totalScore1 = 0;
            int rollNumber = 0;
            string userInput;
            



            //start of loop
            do
            {
                
                Console.WriteLine("Player 1 do you want to 'roll' the dice or 'hold' the dice and save your score");
                userInput = Console.ReadLine();

                if (userInput == "hold")
                {
                    Console.WriteLine("Your score has been saved for the next round");
                    //need to save global score here
                    gameTimePlayer2();

                }

                Random diceRoll = new Random();
                int diceNumber = diceRoll.Next(1, 7);

                if (diceNumber == 1)
                {
                    Console.WriteLine("Sorry you roled a one your score is reset.");
                    Console.ReadKey();
                    Console.Clear();
                    gameTimePlayer2();
                }
                else if (diceNumber != 1)
                {
                    rollNumber++;
                    int newTotalScore = totalScore1 + diceNumber;
                    totalScore1 = newTotalScore;
                    Console.WriteLine("You rolled a " + diceNumber + " and your total score is " + totalScore1 + " and your roll number is " + rollNumber);
                    
                    if (totalScore1 >= 50)
                    {
                        Console.WriteLine("------------------------------------------------------------");
                        Console.WriteLine("Congratulations player 1 won the game in " + rollNumber + " rolls");
                        Console.WriteLine("------------------------------------------------------------");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }

                }


                              
            }
            while (userInput == "roll");
            //end of loop
            

           
           
        }
        static void gameTimePlayer2()
        {
            int totalScore2 = 0;
            int rollNumber = 0;
            string userInput;




            //start of loop
            do
            {
                Console.WriteLine("Player 2 do you want to 'roll' the dice or 'hold' the dice and save your score");
                

                userInput = Console.ReadLine();

                if (userInput == "hold")
                {
                    Console.WriteLine("Your score has been saved for the next round");
                    //need to save global score here
                    gameTime();

                }

                Random diceRoll = new Random();
                int diceNumber = diceRoll.Next(1, 7);

                if (diceNumber == 1)
                {
                    Console.WriteLine("Sorry you roled a one your score is reset.");
                    totalScore2 = 0;
                    Console.ReadKey();
                    Console.Clear();
                    gameTime();
                }
                else if (diceNumber != 1)
                {
                    rollNumber++;
                    int newTotalScore = totalScore2 + diceNumber;
                    totalScore2 = newTotalScore;
                    Console.WriteLine("You rolled a " + diceNumber + " and your total score is " + totalScore2 + " and your roll number is " + rollNumber);
                    

                    if (totalScore2 >= 50)
                    {
                        Console.WriteLine("------------------------------------------------------------");
                        Console.WriteLine("Congratulations player 2 you won the game in " + rollNumber + " rolls");
                        Console.WriteLine("------------------------------------------------------------");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }

                }



            }
            while (userInput == "roll");
            //end of loop

        }

    }

}