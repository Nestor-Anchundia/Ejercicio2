using System;
using System.Collections.Generic;
using System.Text;
using Decorarpaginaweb.interfaces;

namespace Decorarpaginaweb.clases
{
    public abstract class Decoradorpaginaweb : IPaginaweb
    {
        protected IPaginaweb paginaweb;

        public Decoradorpaginaweb(IPaginaweb paginaweb)
        {
            this.paginaweb = paginaweb;

        }

        public abstract string
            getDescripcion();
    }
}