using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaquetesTuristicos.Entities
{
    public class Imprimir
    {

        public void ImprimirVenta(VentaPaquete ventapaquete)

        {
            Cliente cliente = ventapaquete.cliente;
            List<Paquete> Listapaquetes = ventapaquete.listapaquetes;

            Console.WriteLine("Cliente: " + cliente.getNombre());
            Console.WriteLine("TipoComprobante: " + ventapaquete.comprobantepago.getTipoComprobante() + "     NroComprobante: " + ventapaquete.comprobantepago.getNroComprobante());
            Console.WriteLine("Cantidad de Paquetes Comprados: " + Listapaquetes.Count);
            Console.WriteLine();
            for (int i = 0; i < Listapaquetes.Count; i++)
            {
                //Paquete paquete = Listapaquetes[i];
                Paquete paquete = Listapaquetes[i];
                ServicioTuristico servicio = (ServicioTuristico)paquete.servicioTuristico;

                Console.WriteLine("Paquete Nro " + (i + 1) + "    Servicio: " + servicio.tiposervicio);
                if (servicio.tiposervicio == TipoServicio.Alimentacion)
                {
                    Alimentacion alimentacion = (Alimentacion)servicio;
                    Console.WriteLine("Categoria: "+alimentacion.getCategoriaAlimentacion() +"    Costo: "+alimentacion.getCosto() );
                    Console.WriteLine();
                }
                else if (servicio.tiposervicio == TipoServicio.Hospedaje)
                {
                    Hospedaje hospedaje = (Hospedaje)servicio;
                    Console.WriteLine("Nombre: "+hospedaje.getNombreHospedaje()+"  Categoria: "+hospedaje.getCategoria() +"  Tipo: "+hospedaje.getTipoHospedaje() +"  Calificacion: "+hospedaje.getCalificacion());
                    Console.WriteLine();

                }
                else if (servicio.tiposervicio == TipoServicio.Transporte)
                {
                    Transporte transporte = (Transporte)servicio;
                    Console.WriteLine("Categoria: " + transporte.getCategoriaTransporte()+"   Tipo: "+transporte.getTipotransporte() + " Origen: " + transporte.getOrigen()+ "   Destino: "+transporte.getDestino());
                    Console.WriteLine();

                }
            }
        }
    }
}
