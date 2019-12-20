using System;
using Decorarpaginaweb.interfaces;

namespace Decorarpaginaweb.clases
{
    public class Pagoenlinea : Decoradorpaginaweb
    {
        public Pagoenlinea(IPaginaweb paginaweb) : base(paginaweb)
        {
        }

        public override string getDescripcion()
        {
            return this.paginaweb.getDescripcion() + "Pagoenlinea\n";
        }
    }
}