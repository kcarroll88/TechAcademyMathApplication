using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechAcademyMathApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Feed me a number!");
            int numFifty = 50;
            int numTwo = Convert.ToInt32(Console.ReadLine());
            long totalOne = numFifty * numTwo;
            Console.WriteLine("Your number times 50 is: " + totalOne + "!");

            Console.WriteLine("Feed me another number!");
            int numThree = Convert.ToInt32(Console.ReadLine());
            int numTwentyFive = 25;
            int totalTwo = numThree + numTwentyFive;
            Console.WriteLine("Your number plus 25 is: " + totalTwo + "!");

            Console.WriteLine("Again please!");
            int numFour = Convert.ToInt32(Console.ReadLine());
            double numTweleveFive = 12.5;
            int totalThree = numFour / Convert.ToInt32(numTweleveFive);
            Console.WriteLine("Your number divided by 12.5 is: " + totalThree + "!");

            Console.WriteLine("I'm having fun. Do it again!");
            int numFive = Convert.ToInt32(Console.ReadLine());
            bool greaterThan = numFive > numFifty;
            Console.WriteLine("Is your number greater than 50? " + greaterThan);

            Console.WriteLine("Ok OK! One last time!");
            int numSix = Convert.ToInt32(Console.ReadLine());
            int numSeven = 7;
            int totalRemainder = numSix % numSeven;
            Console.WriteLine("The remainder of your number is: " + totalRemainder);
            Console.Read();
        }
    }
}
