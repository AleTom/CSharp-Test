using RefactoringGeometricalShapes.interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringGeometricalShapes
{
    public class English : IlanguageTranslation
    {
        public string Area => "Area ";

        public string Perimeter => "Perimeter ";

        public string Shape => "shapes";

        public string Empty => "<h1>Empty list of shapes!</h1>";

        public string Heading => "<h1>Shapes report</h1><br/>";
        public CultureInfo NumberFormatter => new CultureInfo("en-US");
        public string translateShape(Type shape, int numberShapes)
        {
            if (shape == typeof(Circle))
                return numberShapes == 1 ? "Circle" : "Circles";
            if (shape == typeof(Square))
                return numberShapes == 1 ? "Square" : "Squares";
            if (shape == typeof(EquilateralTriangle))
                return numberShapes == 1 ? "Triangle" : "Triangles";
            return "Unknown";
        }
    }
}
