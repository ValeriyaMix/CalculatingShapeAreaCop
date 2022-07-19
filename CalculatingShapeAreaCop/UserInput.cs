using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CalculatingShapeAreaCop
{
    public class UserInput
    {
        public string[] shapeTypes = { "square", "rectangle", "trapezoid",
            "parallelogram" };
        public int CheckUserChoice(string choice)
        {
            string strRegex = @"([1-4])";
            Regex re = new Regex(strRegex);

            if (re.IsMatch(choice))
            {
                return Convert.ToInt32(choice);
            }
            else
            {
                Console.WriteLine("You put the wrong value");
                while (re.IsMatch(choice) == false)
                {
                    Console.WriteLine("Please insert a whole number" +
                        " from the range 1-4 otherwise it will not work");
                    choice = Console.ReadLine();
                }
                return Convert.ToInt32(choice);
            }
        }

        public string CheckUserInput(string inputShape)
        {
            if (shapeTypes.Contains(inputShape))
            {
                return inputShape;
            }
            else
            {
                Console.WriteLine("You put the wrong shape name, try again");
                while (shapeTypes.Contains(inputShape) == false)
                {
                    Console.WriteLine("Please insert a shape name without typos" +
                        " or additional symbols");
                    inputShape = Console.ReadLine();
                }
                return inputShape;
            }

        }
        public int GetUserChoice()
        {
            Console.WriteLine("Please type a number to choose a shape\n" +
                "for a circle type 1\n" +
                "for a triangle type 2\n" +
                "for a different shape type 3\n" +
                "if you do not know the name of the shape then type 4");
            string input = Console.ReadLine();
            int checked_input = CheckUserChoice(input);
            return checked_input;
        }
    }
}
