using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingShapeAreaCop
{
    internal class Area
    {
        public double Side_x { get; set; }
        public double Side_y { get; set; }

        public virtual double AreaCalculation()
        {
            return Side_x * Side_y;
        }
    }
}
