using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringGeometricalShapes.interfaces
{
    public interface IshapesContainer
    {
        String prettyPrint(List<Ishape> shapes, IlanguageTranslation userLanguage);
    }
}
