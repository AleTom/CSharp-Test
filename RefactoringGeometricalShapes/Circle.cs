using RefactoringGeometricalShapes.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringGeometricalShapes
{
    public class Circle : ShapeBase, Ishape, Igeometric
    {
        public Circle(int width) : base(width) { }
        public double getArea()
        {
            return Math.PI * (_width / 2) * (_width / 2);
        }

        public double getPerimeter()
        {
            return Math.PI * _width;
        }
    }
}
