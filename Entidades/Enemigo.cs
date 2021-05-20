using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Enemigo: Personaje
    {

        public Enemigo(string nombre) : base(nombre)
        {

        }

        public override string ToString()
        {
            return base.ToString(); 
        }

    }
}
