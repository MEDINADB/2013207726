using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaquetesTuristicos.Entities
{
    public class Alimentacion: ServicioTuristico
    {
        private CategoriaAlimentacion categoriaalimentacion;
        private double costo;
        public TipoServicio tiposervicio { set; get; }

        public Alimentacion(CategoriaAlimentacion categoria, double costo)
        {
            this.categoriaalimentacion = categoria;
            this.costo = costo;
        }

        public CategoriaAlimentacion getCategoriaAlimentacion(){
            return categoriaalimentacion;
        }

        public double getCosto()
        {
            return costo;
        }

    }
}
