using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorio
{
    public class Paciente
    {
        private string DNI;
        private string nombreCompleto;
        private string telefono;
        private List<string> intervenciones;
        private float descuento;

        public Paciente (string DNI, string nombreCompleto, string telefono)
        {
            this.DNI = DNI;
            this.nombreCompleto = nombreCompleto;
            this.telefono = telefono;
            intervenciones = new List<string>();
            descuento = 0;
        }

        public string getDNI()
        {
            return DNI;
        }

        public string getNombreCompleto()
        {
            return nombreCompleto;
        }
        public string getTelefono()
        {
            return telefono;
        }

        public virtual float getCobertura()
        {
            return descuento;
        }
    }
}
