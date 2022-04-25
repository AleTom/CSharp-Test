using RefactoringGeometricalShapes.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace RefactoringGeometricalShapes
{
    public class DefaultLanguage : IlanguageTranslation
    {
        public string Area => "Oppervlakte ";

        public string Perimeter => "Omtrek ";

        public string Shape => "vormen";

        public string Empty => "<h1>Lege lijst van vormen!</h1>";

        public string Heading => "<h1>Samenvatting vormen</h1><br/>";

        public CultureInfo NumberFormatter => new CultureInfo("nl-NL");

        public string translateShape(Type shape, int numberShapes)
        {
            if(shape == typeof(Circle))
                return numberShapes == 1 ? "Cirkel" : "Cirkels";
            if (shape == typeof(Square))
                return numberShapes == 1 ? "Vierkant" : "Vierkanten";
            if(shape == typeof(EquilateralTriangle))
                return numberShapes == 1 ? "Driehoek" : "Driehoeken";
            return "Onbekend";
        }
    }
}
