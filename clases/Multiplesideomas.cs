using System;
using Decorarpaginaweb.interfaces;

namespace Decorarpaginaweb.clases
{
    public class Multiplesideomas : Decoradorpaginaweb
    {
        public Multiplesideomas(IPaginaweb paginaweb) : base(paginaweb)
        {
        }

        public override string getDescripcion()
        {
            return this.paginaweb.getDescripcion() + "Multiplesideomas\n";
        }
    }
}