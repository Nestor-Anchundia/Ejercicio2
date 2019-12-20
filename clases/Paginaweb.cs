using System;
using Decorarpaginaweb.interfaces;

namespace Decorarpaginaweb.clases
{
    public class Paginaweb : IPaginaweb
    {
        public string getDescripcion()
        {
            return "Tecnologia\nOpciones\n";
        }
    }
}