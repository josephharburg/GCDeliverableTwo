using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCDeliverableTwoJH
{
    class Program
    {
        static void Main(string[] args)
        {
            int response;
            bool wrongResponse = true;
            while (wrongResponse)
            {
                Console.WriteLine("Hi! What are you in the mood for this weekend?\n " +
                    "Please select a number!\n" +
                    "1 for Action\n2 for Chilling\n3 for Danger\n4 for Good Food.");
                try
                {
                    response = Convert.ToInt32(Console.ReadLine());
                    switch (response)
                    {
                        case (1):
                            Output(1, "Ok your in a mood for Action! You should go stock car racing");
                            wrongResponse = false;
                            break;
                        case (2):
                            Output(2, "Ok you want to chill? You should go hiking");
                            wrongResponse = false;
                            break;
                        case (3):
                            Output(3, "In a mood for danger? You should go Skydiving");
                            wrongResponse = false;
                            break;
                        case (4):
                            Output(4, "In a mood for good food huh? You should go to Taco Bell");
                            wrongResponse = false;
                            break;
                        default:
                            Console.WriteLine("Please select only a number between 1 and 4\n");
                            continue;
                    }
                }
                catch
                {
                    Console.WriteLine("Im sorry thats not a valid response! Please only enter a number!\n");
                }
                
            }
            Console.WriteLine("Thanks for asking! Bye!");
            
        }
        private static void Output(int mood, string activity)
        {
            bool wrongResponse = true;
            while (wrongResponse)
            {
            Console.WriteLine("How many people will be with you?");
            int numPeople = Convert.ToInt32(Console.ReadLine());
           
                if (numPeople < 1 && numPeople > -1)
                {
                    Console.WriteLine("{0} and travel in your sneakers!", activity);
                    wrongResponse = false;
                }
                else if (numPeople > 1 && numPeople < 5)
                {
                    Console.WriteLine("{0} and travel in a sedan!", activity);
                    wrongResponse = false;
                }
                else if (numPeople > 4 && numPeople < 10)
                {
                    Console.WriteLine("{0} and travel in a volkswagon bus!", activity);
                    wrongResponse = false;
                }
                else if (numPeople > 10)
                {
                    Console.WriteLine("{0} and travel in an airplane!", activity);
                    wrongResponse = false;
                }
                else
                {
                    Console.WriteLine("Thats not a valid response! Try again please");
                }
            }
        }
    }
}
