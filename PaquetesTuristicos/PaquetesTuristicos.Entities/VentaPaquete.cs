using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaquetesTuristicos.Entities
{
    public class VentaPaquete
    {
        public List<Paquete> listapaquetes = new List<Paquete>();
        public Cliente cliente { set; get; }
        public Empleado empleado { set; get; }
        public MedioPago mediopago { set; get; }
        public ComprobantePago comprobantepago { set; get; }

        public void agregarVenta(Paquete paquete)
        {
            listapaquetes.Add(paquete);
        }

        public VentaPaquete(Cliente cliente, Empleado empleado, List<Paquete> listapaquetes, MedioPago mediopago, ComprobantePago comprobantepago)
        {
            this.cliente = cliente;
            this.empleado = empleado;
            this.listapaquetes = listapaquetes;
            this.comprobantepago = comprobantepago;
            this.mediopago = mediopago;
        }


    }
}
