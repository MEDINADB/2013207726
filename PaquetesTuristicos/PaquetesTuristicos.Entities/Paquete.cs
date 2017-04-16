using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaquetesTuristicos.Entities
{
    public class Paquete
    {
        //public List<ServicioTuristico> listaServicios = new List<ServicioTuristico>();

        public ServicioTuristico servicioTuristico { set; get; }
        public Cliente cliente { set; get; }
        public TipoServicio tiposervicio { set; get; }

        public Paquete(Cliente cliente, ServicioTuristico servicio,TipoServicio tiposervicio)
        {
            this.cliente = cliente;
            servicio.tiposervicio = tiposervicio;
            this.servicioTuristico = servicio;
        }


    }
}
