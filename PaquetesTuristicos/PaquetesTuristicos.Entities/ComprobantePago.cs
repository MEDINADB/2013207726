using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaquetesTuristicos.Entities
{
    public class ComprobantePago
    {
        private String nroComprobante;
        private TipoComprobante tipoComprobante;

        public ComprobantePago(String nroComprobante, TipoComprobante tipoComprobante)
        {
            this.nroComprobante = nroComprobante;
            this.tipoComprobante = tipoComprobante;
        }

        public String getNroComprobante()
        {
            return nroComprobante;
        }

        public TipoComprobante getTipoComprobante()
        {
            return tipoComprobante;
        }
    }
}
