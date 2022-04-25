using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace RefactoringGeometricalShapes.interfaces
{
    public interface IlanguageTranslation
    {
        String translateShape(Type shape, int numberShapes);
        String Area { get; }
        String Perimeter { get; }
        String Shape { get; }
        String Empty { get; }
        String Heading { get; }
        CultureInfo NumberFormatter { get; }
    }
}
