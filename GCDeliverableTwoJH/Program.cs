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
                            break;
                        case (2):
                            Output(2, "go hiking");
                            break;
                        case (3):
                            Output(3, "go Skydiving");
                            break;
                        case (4):
                            Output(4, "to Taco Bell");
                            break;
                        default:
                            Console.WriteLine("Please select only a number between 1 and 4");
                            continue;
                    }
                }
                catch
                {
                    Console.WriteLine("Im sorry thats not a valid response! Please only enter a number!");
                }
                wrongResponse = false;
            }
            Console.WriteLine("Thanks for asking! Bye!");
            
        }
        private static void Output(int mood, string activity)
        {
            Console.WriteLine("How many people will be with you?");
            int numPeople = Convert.ToInt32(Console.ReadLine());
            if (numPeople < 1)
            {
                Console.WriteLine("You should {0} in your sneakers!", activity);
            }
            else if (numPeople > 1 && numPeople < 5)
            {
                Console.WriteLine("You should {0} in a sedan!", activity);
            }
            else if (numPeople > 5 && numPeople < 10)
            {
                Console.WriteLine("You should go {0} in a volkswagon bus!", activity);
            }
            else if (numPeople > 10)
            {
                Console.WriteLine("You should go {0} in an airplane!", activity);
            }
        }
    }
}
