using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaquetesTuristicos.Entities
{
    public class CreateVentas
    {
        public List<VentaPaquete> listaVentas = new List<VentaPaquete>();


        public List<VentaPaquete>  generarVentas()
        {

            Cliente cliente1 = new Cliente("10231232", "Esteban Gomero", "921371232");
            Cliente cliente2 = new Cliente("70645312", "Jose Ramos", "992312277");
            Cliente cliente3 = new Cliente("70254262", "Carlos Rojas", "957142631");
            Cliente cliente4 = new Cliente("10231888", "Gabriel Monje", "999777212");

            Empleado empleado = new Empleado("", "Jose Reategui", "982612492");

            Transporte transporte1 = new Transporte("2017-04-01", "Lima", "Tarapoto", CategoriaTransporte.VIP,TipoTransporte.Bus);
            Transporte transporte2 = new Transporte("2017-04-02", "Lima", "Cuzco", CategoriaTransporte.VIP, TipoTransporte.Avion);
            Transporte transporte3 = new Transporte("2017-04-03", "Lima", "Arequipa", CategoriaTransporte.VIP, TipoTransporte.Bus);
            Transporte transporte4 = new Transporte("2017-04-04", "Lima", "Buenos Aires", CategoriaTransporte.Basico, TipoTransporte.Avion);

            Hospedaje hospedaje1 = new Hospedaje("Polo Cusco Suites", "Av. los Ruiseñores 213 - Cuzco", TipoHospedaje.Hotel, CalificacionHospedaje.E2, CategoriaHospedaje.VIP, ServicioHospedaje.RoomService);
            Hospedaje hospedaje2 = new Hospedaje("Hotel Arcangel", "Av. Trapiche central 666 - Tarapoto", TipoHospedaje.Hotel, CalificacionHospedaje.E3, CategoriaHospedaje.Normal, ServicioHospedaje.Lavanderia);
            Hospedaje hospedaje3 = new Hospedaje("Solar de Arequipa", "Av. Cayma 128 - Arequipa", TipoHospedaje.Backpacker, CalificacionHospedaje.E4, CategoriaHospedaje.Normal, ServicioHospedaje.Lavanderia);
            Hospedaje hospedaje4 = new Hospedaje("San Lorenzo", "Av. alvear 721 - Buenos Aires", TipoHospedaje.Hostal, CalificacionHospedaje.E2, CategoriaHospedaje.Normal, ServicioHospedaje.Planchado);

            Alimentacion alimentacion1 = new Alimentacion(CategoriaAlimentacion.VIP, 200);
            Alimentacion alimentacion2 = new Alimentacion(CategoriaAlimentacion.Normal, 150);
            Alimentacion alimentacion3 = new Alimentacion(CategoriaAlimentacion.Vegetariano, 250);

            
            ServicioTuristico servicio1 = transporte1;
            Paquete paquete1 = new Paquete(cliente1, servicio1, TipoServicio.Transporte);

            ServicioTuristico servicio2 = hospedaje1;
            Paquete paquete2 = new Paquete(cliente1, servicio2, TipoServicio.Hospedaje);

            ServicioTuristico servicio3 = alimentacion1;
            Paquete paquete3 = new Paquete(cliente1, servicio3, TipoServicio.Alimentacion);

            List<Paquete> listapaquete1 = new List<Paquete>();
            listapaquete1.Add(paquete1);
            listapaquete1.Add(paquete2);
            listapaquete1.Add(paquete3);
            ComprobantePago comprobante1 = new ComprobantePago("321231",TipoComprobante.Boleta);
            VentaPaquete ventapaquete1 = new VentaPaquete(cliente1, empleado, listapaquete1, MedioPago.Contado, comprobante1);

            ServicioTuristico servicio4 = transporte2;
            Paquete paquete4 = new Paquete(cliente2, servicio4, TipoServicio.Transporte);

            ServicioTuristico servicio5 = hospedaje2;
            Paquete paquete5 = new Paquete(cliente2, servicio5, TipoServicio.Hospedaje);

            List<Paquete> listapaquete2 = new List<Paquete>();
            listapaquete2.Add(paquete4);
            listapaquete2.Add(paquete5);
            ComprobantePago comprobante2 = new ComprobantePago("321232", TipoComprobante.Factura);
            VentaPaquete ventapaquete2 = new VentaPaquete(cliente2, empleado, listapaquete2, MedioPago.Contado, comprobante2);

            ServicioTuristico servicio6 = hospedaje3;
            Paquete paquete6 = new Paquete(cliente3, servicio6, TipoServicio.Hospedaje);

            ServicioTuristico servicio7 = alimentacion3;
            Paquete paquete7 = new Paquete(cliente3, servicio7, TipoServicio.Alimentacion);

            List<Paquete> listapaquete3 = new List<Paquete>();
            listapaquete3.Add(paquete6);
            listapaquete3.Add(paquete7);
            ComprobantePago comprobante3 = new ComprobantePago("321233", TipoComprobante.Factura);
            VentaPaquete ventapaquete3 = new VentaPaquete(cliente3, empleado, listapaquete3, MedioPago.Contado, comprobante3);

            ServicioTuristico servicio8 = hospedaje4;
            Paquete paquete8 = new Paquete(cliente4, hospedaje4, TipoServicio.Hospedaje);

            ServicioTuristico servicio9 = alimentacion2;
            Paquete paquete9 = new Paquete(cliente4, alimentacion2, TipoServicio.Alimentacion);

            ServicioTuristico servicio10 = transporte4;
            Paquete paquete10 = new Paquete(cliente4, transporte4, TipoServicio.Transporte);

            List<Paquete> listapaquete4 = new List<Paquete>();
            listapaquete4.Add(paquete8);
            listapaquete4.Add(paquete9);
            listapaquete4.Add(paquete10);
            ComprobantePago comprobante4 = new ComprobantePago("321234", TipoComprobante.Boleta);
            VentaPaquete ventapaquete4 = new VentaPaquete(cliente4, empleado, listapaquete4, MedioPago.Credito, comprobante4);


            listaVentas.Add(ventapaquete1);
            listaVentas.Add(ventapaquete2);
            listaVentas.Add(ventapaquete3);
            listaVentas.Add(ventapaquete4);

            return listaVentas;
        }
    }
}
