using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingShapeAreaCop
{
    internal class TriangleArea: Area
    {
        
        public double Side_z { get; set; }


        public override double AreaCalculation()
        {

            if (Math.Sqrt(Side_x * Side_x + Side_y * Side_y) == Side_z)
            {
                return (Side_x * Side_y) / 2;
            }
            else if (Math.Sqrt(Side_z * Side_z + Side_y * Side_y) == Side_x)
            {
                return (Side_z * Side_y) / 2;
            }
            else if (Math.Sqrt(Side_x * Side_x + Side_z * Side_z) == Side_y)
            {
                return (Side_x * Side_z) / 2;
            }
            else
            {
                double p = (Side_x + Side_y + Side_z) / 2;
                return Math.Sqrt(p * (p - Side_x) * (p - Side_y) * (p - Side_z));
            }
        }
    }
}
