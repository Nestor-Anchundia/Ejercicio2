using System;
using Decorarpaginaweb.clases;
using Decorarpaginaweb.interfaces;

namespace Decorarpaginaweb
{
    class Program
    {
        static void Main(string[] args)
        {
            Paginaweb normal = new Paginaweb();

            Chat paginawebconchat = new Chat(normal);
            Chat paginawebconchatp = new Chat(paginawebconchat);
            Paginaweb media = new Paginaweb();
            Login paginawebconlogin = new Login(media);
            Paginaweb alta = new Paginaweb();
            Pagoenlinea paginawebconpagoenlinea = new Pagoenlinea(alta);
            Paginaweb premium = new Paginaweb();
            Multiplesideomas paginawebconmultiplesideomas = new Multiplesideomas(premium);
            Console.WriteLine(paginawebconchat.getDescripcion());
            Console.WriteLine(paginawebconlogin.getDescripcion());
            Console.WriteLine(paginawebconpagoenlinea.getDescripcion());
            Console.WriteLine(paginawebconmultiplesideomas.getDescripcion());
        }
    }
}