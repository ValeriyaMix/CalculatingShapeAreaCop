using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CalculatingShapeAreaCop
{
    public class UserChoiceManagement: UserInput
    {
        Area objArea = null;
        UserInput objInput = new UserInput();
        


        public static double IsPositive(string number)
        {
            string inputRegex = @"(^([0-9]+\.?[0-9]*|\.[0-9]+)$)";
            Regex re = new Regex(inputRegex);


            if (re.IsMatch(number) == false)
            {
                Console.WriteLine("The value cannot be negative");
                while (re.IsMatch(number) == false)
                {
                    Console.WriteLine("Please insert a positive value" +
                        " otherwise I cannot calculate the area");
                    number = Console.ReadLine();
                }
                return Convert.ToDouble(number);
            }
            else
            {
                return Convert.ToDouble(number);
            }
        }

        public void Calculate()
        {
            int userChoice = objInput.GetUserChoice();

            if (userChoice == 1)
            {
                objArea = ChoosenCircle();
            }
            else if (userChoice == 2)
            {
                objArea = ChoosenTriangle();
            }
            else if (userChoice == 3)
            {
                Console.WriteLine("What kind of shape whould you like to" +
                    " calculate the area of?");
                string answer = Console.ReadLine().ToLower();
                string rightAnswer = objInput.CheckUserInput(answer);
                switch (rightAnswer)
                {
                    case "rectangle":
                        objArea = ChoosenSquareRectangle();
                        break;
                    case "square":
                        objArea = ChoosenSquareRectangle();
                        break;
                    case "trapezoid":
                        objArea = ChoosenTrapezoid();
                        break;
                    default:
                        Console.WriteLine("I can't calculate the area of that shape");
                        break;
                }
            }

            Console.WriteLine($"The area of the shape is {Math.Round(objArea.AreaCalculation(), 3)}");

        }

        public CircleArea ChoosenCircle()
        {
            Console.WriteLine("Please insert the value of the radius" +
                    " of a circle");
            double radius = IsPositive(Console.ReadLine().ToLower());
            CircleArea area = new CircleArea();
            area.Side_x = radius;   
           
            return area;
        }

        TriangleArea ChoosenTriangle()
        {
            Console.WriteLine("Please insert a value of" +
                    " the first side of a triangle");
            double x = IsPositive(Console.ReadLine());
            Console.WriteLine("Please insert a value of" +
                    " the second side of a triangle");
            double y = IsPositive(Console.ReadLine());
            Console.WriteLine("Please insert a value of" +
                    " the third side of a triangle");
            double z = IsPositive(Console.ReadLine());
            TriangleArea area = new TriangleArea();
            area.Side_x = x;
            area.Side_y = y;
            area.Side_z = z;
            return area;
        }

        Area ChoosenSquareRectangle()
        {
            Console.WriteLine("Please insert a value of the first side");
            double x = IsPositive(Console.ReadLine());
            Console.WriteLine("Please insert a value of the second side");
            double y = IsPositive(Console.ReadLine());
            Area area = new Area();
            area.Side_y = y;
            area.Side_x = x;
            return area;
        }

        TrapezoidArea ChoosenTrapezoid()
        {
            Console.WriteLine("Please insert a value of a smaller base" +
                        " of a trapezoid");
            double x = IsPositive(Console.ReadLine());
            Console.WriteLine("Please insert a value of a larger base" +
                        " of a trapezoid");
            double y = IsPositive(Console.ReadLine());
            Console.WriteLine("Please insert a value of a height" +
                        " of a trapezoid");
            double h = IsPositive(Console.ReadLine());
            TrapezoidArea area = new TrapezoidArea();
            area.Side_x = x;
            area.Side_y = y;
            area.Side_h = h;
            return area;
        }

    }
}
