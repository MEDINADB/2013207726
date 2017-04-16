using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaquetesTuristicos.Entities
{
    public class Cliente:Persona
    {
        private String dni;
        private String nombre;
        private String telefono;
        public Cliente(String dni, String nombre, String telefono)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.telefono = telefono;
        }

        public String getNombre()
        {
            return nombre;
        }
    }
}
