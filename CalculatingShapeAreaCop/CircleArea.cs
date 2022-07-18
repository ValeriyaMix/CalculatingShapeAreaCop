using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingShapeAreaCop
{
    internal class CircleArea: Area
    {
        

        public override double AreaCalculation()
        {
            return Math.PI * Math.Pow(Side_x, 2);
        }
    }
}
