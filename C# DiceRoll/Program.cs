using System;

namespace DiceRoll // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Main(string[] args)
        {

            int RollDice(){ // returns the sum of dice rolls
                Random r = new Random();
                int d1 = r.Next(1, 7);
                int d2 = r.Next(1, 7);
                Console.WriteLine(d1 + "," + d2 + " (sum: " + (d1 + d2) + ")");
                return d1 + d2;
            }

            string input = "";
            do{
                Console.WriteLine("Dice Roll Simulator Menu");
                Console.WriteLine("1. Roll Dice Once");
                Console.WriteLine("2. Roll Dice 5 Times");
                Console.WriteLine("3. Roll Dice 'n' times");
                Console.WriteLine("4. Roll Dice until Snake Eyes");
                Console.WriteLine("5. Exit");
                input = Console.ReadLine();
                if(input == "1"){
                    RollDice();
                }else if(input == "2"){
                    RollDice();
                    RollDice();
                    RollDice();
                    RollDice();
                    RollDice();
                }else if(input == "3"){
                    Console.WriteLine("How many rolls would you like?");
                    string input2 = Console.ReadLine();
                    for(int i = 0; i < Int32.Parse(input2); i++){
                        RollDice();
                    }
                }else if(input == "4"){
                    int result = RollDice();
                    int rollCount = 1;
                    while(result != 2){
                        result = RollDice();
                        rollCount++;
                    }
                    Console.WriteLine("SNAKE EYES! It took " + rollCount + " rolls to get snake eyes.");
                }
            }while(input != "5");
        }
    }
}