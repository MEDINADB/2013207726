using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaquetesTuristicos.Entities
{
    public class Empleado :Persona
    {
        private String dni;
        private String nombre;
        private String cargo;

        public Empleado(String dni, String nombre, String cargo)
        {
            this.dni=dni;
            this.nombre = nombre;
            this.cargo = cargo;
        }

        public String getNombre(){
            return nombre;  
        }
    }
}
