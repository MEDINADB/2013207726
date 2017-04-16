using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaquetesTuristicos.Entities
{
    public class Transporte : ServicioTuristico
    {
        private CategoriaTransporte categoriatransporte;
        private String origen;
        private String destino;
        private String fecha_viaje;
        public TipoServicio tiposervicio { set; get; }
        private TipoTransporte tipotransporte;

        public Transporte(String fecha_viaje, String origen, String destino, CategoriaTransporte categoriatransporte, TipoTransporte tipotransporte)
        {
            this.fecha_viaje = fecha_viaje;
            this.origen = origen;
            this.destino = destino;
            this.categoriatransporte = categoriatransporte;
            this.tipotransporte = tipotransporte;
        }

        public TipoTransporte getTipotransporte()
        {
            return tipotransporte;
        }

        public String getOrigen(){
            return origen;
        }

        public String getDestino(){
            return destino;
        }

        public CategoriaTransporte getCategoriaTransporte() { 
            return categoriatransporte; 
        }

        public String getFecha_viaje()
        {
            return fecha_viaje;
        }

    }
}
