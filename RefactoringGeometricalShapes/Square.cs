using RefactoringGeometricalShapes.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringGeometricalShapes
{
    public class Square : ShapeBase, Ishape, Igeometric
    {
        public Square(int width) : base(width) { }
        public double getArea()
        {
            return _width * _width;
        }

        public double getPerimeter()
        {
            return 4 * _width;
        }
    }
}
