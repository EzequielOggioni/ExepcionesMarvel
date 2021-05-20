using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Marvel
    {
        private static List<Personaje> personajes;
        private static int cantidadPersonajes;
        public static string guardarAlgo;
        static Marvel()
        {
            personajes = new List<Personaje>();
            cantidadPersonajes = 0;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="AgregarBichitoException"></exception>
        public static Personaje AgregarBichito
        {
            set
            {
                guardarAlgo = "";
                try
                {
                    personajes = personajes + value;
                    //Si hay exepcion no se ejecuta lo demas hasta llegar al catch
                    cantidadPersonajes++;

                }
                catch (PersonajeRepetidoException objetoDeExceptionCapturada)
                {
                    //escribir en el log el error;
                    throw new AgregarBichitoException("No se pudo agregar", objetoDeExceptionCapturada);

                }
                catch (ExesoDePersonajesException objetoDeExceptionCapturada)
                {
                    throw new AgregarBichitoException("No se pudo agregar", objetoDeExceptionCapturada);
                }
                finally
                {
                    guardarAlgo = "Esto tiene que estar si o si";
                }

                guardarAlgo += "llegué al final";


            }
        }

        public static string Mostrar()
        {
            string salida = "";
            foreach (var item in personajes)
            {
                salida = item.ToString();
            }
            return salida;
        }

    }
}
