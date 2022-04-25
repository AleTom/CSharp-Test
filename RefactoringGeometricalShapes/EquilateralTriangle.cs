using RefactoringGeometricalShapes.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringGeometricalShapes
{
    public class EquilateralTriangle : ShapeBase, Ishape, Igeometric
    {
        public EquilateralTriangle(int width) : base(width) { }
        public double getArea()
        {
            return (Math.Sqrt(3) / 4) * _width * _width;
        }

        public double getPerimeter()
        {
            return 3 * _width;
        }
    }
}
