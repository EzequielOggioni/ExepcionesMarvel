using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PersonajeRepetidoException: Exception
    {

        public PersonajeRepetidoException(string mensaje) : 
            base(mensaje) { }

        public Personaje personaje;
    }
}
