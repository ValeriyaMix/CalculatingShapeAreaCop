using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingShapeAreaCop
{
    internal class TrapezoidArea: Area
    {
        public double Side_h { get; set; }
        public override double AreaCalculation()
        {
            return (Side_x + Side_y) / Side_h;
        }
    }
}
