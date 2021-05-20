using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AgregarBichitoException:Exception
    {
        public AgregarBichitoException(string mensaje, Exception innerE):base(mensaje, innerE)
        {
            

        }
    }
}
