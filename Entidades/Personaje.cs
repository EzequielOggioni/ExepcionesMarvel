using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Personaje
    {

        protected string nombre;

        public Personaje(string nombre)
        {
            this.nombre = nombre;
        }

        public static List<Personaje> operator +(List<Personaje> personajes, Personaje personaje)
        {
            if(personaje.nombre == "Octavio")
            {
                throw new Exception("No es un personaje valido para este parcial");            }

            if (personajes.Count == 2)
            {
                ExesoDePersonajesException miException = new ExesoDePersonajesException("Ya hay " + personajes.Count + " en la lista");
                throw miException;
            }

            if (personajes == personaje)
            {
                PersonajeRepetidoException personajeRepetidoException = new PersonajeRepetidoException(personaje.nombre + " se encuentra repetido ");
                personajeRepetidoException.personaje = personaje;
                throw personajeRepetidoException;
            }
            else
            {
                personajes.Add(personaje);
            }

            return personajes;
        }

        public static bool operator ==(List<Personaje> listaPersonaje, Personaje personaje)
        {
            foreach (Personaje p in listaPersonaje)
            {
                if (p.nombre == personaje.nombre && p.GetType() == personaje.GetType())
                {
                    return true;
                }
            }

            return false;
        }
        public static bool operator !=(List<Personaje> listaPersonaje, Personaje personaje)
        {
            return !(listaPersonaje == personaje);
        }

        public override string ToString()
        {
            return "new sb nombre: " + this.nombre ;
        }



    }
}
