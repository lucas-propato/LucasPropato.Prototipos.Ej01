using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasPropato.Prototipos.Ej01
{
    internal class Ejercicio01Model
    {
        /// <summary>
        /// Este método debe validar que persona sea un objeto bien formado y, en caso contrario, devolver un mensaje de error.
        /// </summary>
        /// <param name="persona"></param>
        /// <returns></returns>

        internal string Validar(Persona persona)
        {
            string error = persona.Validar();
            if(error != null)
            {
                return error;
            }

            // otras validaciones...
            
            return null; // null indica todo OK. (usar para que no se rompa en git y poder seguir trabajando y que compile)
        }
    }
}
