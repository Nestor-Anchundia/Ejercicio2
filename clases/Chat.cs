using System;
using Decorarpaginaweb.interfaces;

namespace Decorarpaginaweb.clases
{
    public class Chat : Decoradorpaginaweb
    {
        public Chat(IPaginaweb paginaweb) : base(paginaweb)
        {
        }

        public override string getDescripcion()
        {
            return this.paginaweb.getDescripcion() + "Chat\n";
        }
    }
}