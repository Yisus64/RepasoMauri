using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorio
{
    public class ConObraSocial : Paciente
    {
        private string nombreObra;
        private float cobertura;
        public ConObraSocial(string DNI, string nombreCompleto, string telefono, string nombreObra, float cobertura) : base(DNI, nombreCompleto, telefono)
        {
            this.nombreObra = nombreObra;
            this.cobertura = cobertura;
        }

        public string getNombreObra()
        {
            return nombreObra;
        }

        public override float getCobertura()
        {
            return cobertura;
        }
    }
}
