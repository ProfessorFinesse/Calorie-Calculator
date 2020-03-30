using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to the calorie calculator");
            Console.Write("\nEnter your age: ");
            double age = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nEnter your height in inches: ");
            double height = Convert.ToDouble(Console.ReadLine());
            height = height * 2.54;
            Console.Write("\nEnter your current weight in pounds: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            weight = weight / 2.205;

            double bmrweight = (10 * weight);
            double bmrheight = (6.25 * height);
            double bmrage = (5 * age);
            double BMR =  bmrweight + bmrheight - bmrage + 5;
            Console.WriteLine("\nWhat is your activity level: Sedentary[0], Active[1], Very Active[2] ?");
            int actlvl = Convert.ToInt32(Console.ReadLine());

            int sed = 0;
            int act = 1;
            int vact = 2;

            bool zero = Convert.ToBoolean(sed);
            bool one = Convert.ToBoolean(act);
            bool two = Convert.ToBoolean(vact);
            bool actlvlbool = Convert.ToBoolean(actlvl);

            if (actlvlbool = zero)
            {
                int TDEESED = Convert.ToInt32(BMR * 1.2);
                Console.Write($"Your TDEE is {TDEESED} ");
                Console.ReadLine();
            }
           else if (actlvlbool = one)
            {
                int TDEEACT = Convert.ToInt32(BMR * 1.4);
                Console.Write($"Your TDEE is {TDEEACT} ");
                Console.ReadLine();
            }
            else if (actlvlbool = two)
            {
                int TDEEVACT = Convert.ToInt32(BMR * 1.6);
                Console.Write($"Your TDEE is {TDEEVACT} ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nYou have made a mistake. You dumb.");
                Console.WriteLine("\nPress any key to exit");
                Console.ReadKey();
            }
            


          

           

            


            
        }
    }
}
