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
                    "1 for Action\n2 for chilling\n3 for danger\n4 for good food.");
                try
                {
                    response = Convert.ToInt32(Console.ReadLine());
                    switch (response)
                    {
                        case (1):
                            Output(1, "go stock car racing");
                            wrongResponse = false;
                            break;
                        case (2):
                            Output(2, "go hiking");
                            wrongResponse = false;
                            break;
                        case (3):
                            Output(3, "go Skydiving");
                            wrongResponse = false;
                            break;
                        case (4):
                            Output(4, "to Taco Bell");
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
            Console.WriteLine("How many people will be with you?");
            int numPeople = Convert.ToInt32(Console.ReadLine());
            while (wrongResponse)
            {
                if (numPeople < 1 && numPeople > -1)
                {
                    Console.WriteLine("You should {0} in your sneakers!", activity);
                    wrongResponse = false;
                }
                else if (numPeople > 1 && numPeople < 5)
                {
                    Console.WriteLine("You should {0} in a sedan!", activity);
                    wrongResponse = false;
                }
                else if (numPeople > 4 && numPeople < 10)
                {
                    Console.WriteLine("You should go {0} in a volkswagon bus!", activity);
                    wrongResponse = false;
                }
                else if (numPeople > 10)
                {
                    Console.WriteLine("You should go {0} in an airplane!", activity);
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
