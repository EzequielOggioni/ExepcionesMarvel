using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class ExesoDePersonajesException: Exception
    {
        public ExesoDePersonajesException(string mensaje):base(mensaje)
        {

        }
    }
}
