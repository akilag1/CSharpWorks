using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Average Calculator");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Please Enter the score and press enter to submit. After done entering scores enter -1 to get the average.");
            Console.WriteLine("-----------------------------");
            int sum = 0;
            int counter = 0;
            while (true)
            {
                Console.Write("Score: ");
                string scoreEnter = Console.ReadLine();
                bool userEnter = int.TryParse(scoreEnter, out int score);
                if (userEnter)
                {
                    if (score == -1)
                    {
                        float avearge = ((float)sum /counter);
                        Console.WriteLine("Average: {0}",avearge);
                        Console.ReadKey();
                        break;
                    }
                    else if(score>=0 && score <= 20)
                    {
                        sum = sum + score;
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine("The numbers entered should only be between 0 and 20. Press enter to retry");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Only numbers are allowed. Press enter to try again");
                    Console.ReadKey();
                }
            }
        }
    }
}
