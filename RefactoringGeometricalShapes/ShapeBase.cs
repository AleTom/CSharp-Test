using RefactoringGeometricalShapes.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringGeometricalShapes
{
    public class ShapeBase : Igeometric
    {
        protected double _width;

        public ShapeBase(int width) 
        {
            _width = width;
        }

        public double getWidth()
        {
            return _width;
        }
    }
}
