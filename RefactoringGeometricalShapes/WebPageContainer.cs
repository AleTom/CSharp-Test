using RefactoringGeometricalShapes.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringGeometricalShapes
{
    public class WebPageContainer : IshapesContainer
    {
        public string prettyPrint(List<Ishape> shapes, IlanguageTranslation userLanguage)
        {
            String returnString = "";

            // test list is empty
            if (shapes.Count == 0)
            {
                returnString = userLanguage.Empty;
            }
            else
            {
                //we have shapes
                //header
                returnString += userLanguage.Heading;

                int numberSquares = 0;
                int numberCircles = 0;
                int numberTriangles = 0;

                double areaSquares = 0;
                double areaCircles = 0;
                double areaTriangles = 0;

                double perimeterSquares = 0;
                double perimeterCircles = 0;
                double perimeterTriangles = 0;

                //compute numbers
                for (int i = 0; i < shapes.Count; i++)
                {
                    if (shapes[i] is Square)
                    {
                        numberSquares++;
                        areaSquares += shapes[i].getArea();
                        perimeterSquares += shapes[i].getPerimeter();
                    }
                    if (shapes[i] is Circle)
                    {
                        numberCircles++;
                        areaCircles += shapes[i].getArea();
                        perimeterCircles += shapes[i].getPerimeter();
                    }
                    if (shapes[i] is EquilateralTriangle)
                    {
                        numberTriangles++;
                        areaTriangles += shapes[i].getArea();
                        perimeterTriangles += shapes[i].getPerimeter();
                    }
                }

                //let`s print this
                returnString += getLine(numberSquares, Math.Round(areaSquares,2), Math.Round(perimeterSquares,2), typeof(Square), userLanguage);
                returnString += getLine(numberCircles, Math.Round(areaCircles,2), Math.Round(perimeterCircles,2), typeof(Circle), userLanguage);
                returnString += getLine(numberTriangles, Math.Round(areaTriangles,2), Math.Round(perimeterTriangles,2), typeof(EquilateralTriangle), userLanguage);

                //footer
                returnString += "TOTAL:<br/>";
                returnString += numberCircles + numberSquares + numberTriangles + " " + userLanguage.Shape + " ";
                returnString += userLanguage.Perimeter +
                                Math.Round(perimeterCircles + perimeterSquares + perimeterTriangles, 2).ToString(userLanguage.NumberFormatter.NumberFormat) + " ";
                returnString += userLanguage.Area +
                                Math.Round(areaCircles + areaSquares + areaTriangles, 2).ToString(userLanguage.NumberFormatter.NumberFormat);
            }


            return returnString;
        }

        private String getLine(int numberShapes, double area, double perimeter, Type type, IlanguageTranslation userLanguage)
        {
            if (numberShapes > 0)
            {
                return numberShapes + " " + userLanguage.translateShape(type, numberShapes) + " " + userLanguage.Area + area.ToString(userLanguage.NumberFormatter.NumberFormat) +
                       " " + userLanguage.Perimeter + perimeter.ToString(userLanguage.NumberFormatter.NumberFormat) + "<br/>";
            }
            return "";
        }
    }
}
