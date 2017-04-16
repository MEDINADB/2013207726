using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaquetesTuristicos.Entities
{
    public class Hospedaje :ServicioTuristico
    {
        private TipoHospedaje tipohospedaje;
        private CalificacionHospedaje calificacionhospedaje;
        private CategoriaHospedaje categoriahospedaje;
        private ServicioHospedaje serviciohospedaje;

        private String direccion;
        private String nombrehospedaje;

        public TipoServicio tiposervicio { set; get; }

        public Hospedaje(String nombre, String direccion, TipoHospedaje tipohospedaje, CalificacionHospedaje calificacionhospedaje, CategoriaHospedaje categoriahospedaje, ServicioHospedaje serviciohospedaje)
        {
            this.nombrehospedaje = nombre;
            this.direccion = direccion;
            this.tipohospedaje = tipohospedaje;
            this.calificacionhospedaje = calificacionhospedaje;
            this.categoriahospedaje = categoriahospedaje;
            this.serviciohospedaje = serviciohospedaje;
        }

        public TipoHospedaje getTipoHospedaje(){
            return tipohospedaje;
        }

        public CalificacionHospedaje getCalificacion()
        {
            return calificacionhospedaje;
        }

        public CategoriaHospedaje getCategoria()
        {
            return categoriahospedaje;
        }

        public ServicioHospedaje getServicioHospedaje()
        {
            return serviciohospedaje;
        }

        public String getNombreHospedaje(){
            return nombrehospedaje;
        }
    }
}
