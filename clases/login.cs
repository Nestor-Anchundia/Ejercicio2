using System;
using Decorarpaginaweb.interfaces;

namespace Decorarpaginaweb.clases
{
    public class Login : Decoradorpaginaweb
    {
        public Login(IPaginaweb paginaweb) : base(paginaweb)
        {
        }

        public override string getDescripcion()
        {
            return this.paginaweb.getDescripcion() + "Login\n";
        }
    }
}