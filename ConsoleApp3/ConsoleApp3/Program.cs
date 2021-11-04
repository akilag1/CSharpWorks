using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static int highScore=50;
        static string name="Amila";

        static void Main(string[] args)
        {
            chkScore(10, "Anura");
            Console.WriteLine("\n");
            chkScore(100, "Kasuni");
            Console.WriteLine("\n");
            chkScore(80, "Aruni");
        }

        static void chkScore(int newScore, string newName)
        {
            if (newScore > highScore)
            {
                highScore = newScore;
                name = newName;
                Console.WriteLine("New HighScoren is " + newScore);
                Console.WriteLine("New highscore holder is " + newName);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("The old highscore of " + highScore + " could not be broken and is still held by " + name);
                Console.ReadKey();
            }
        }
    }
}
