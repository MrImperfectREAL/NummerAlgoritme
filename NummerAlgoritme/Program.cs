using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace NummerAlgoritme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool check = false;
            Random rand = new Random();
            int randomTall = rand.Next(1, 50);
            Console.WriteLine("Programmet har lagd et tall mellom 1-50. Gjett hvilket det er.");
            int guess = 0;

            while (check == false)
            { 
                int input = Convert.ToInt32(Console.ReadLine());
                guess++;

                if (input > randomTall) 
                {
                    Console.WriteLine("Tallet er for stort");
                }
                else if (input < randomTall)
                {
                    Console.WriteLine("Tallet er for lite");
                }
                else
                {
                    Console.WriteLine("Korrekt!");
                    check = true; 
                }
            }
            Console.WriteLine("Du brukte " + guess + " gjettinger på å komme fram til svaret");
            Console.ReadLine();
        }
    }
}
