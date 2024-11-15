using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorio
{
    public class AltaComplejidad : Intervencion 
    {
        private float adicional;

        public AltaComplejidad (int codigo, string descripcion, string especialidad) : base (codigo, descripcion, especialidad)
        {
            costo = 20000;
            adicional = 5000;
        }

        public override float CalcularCosto(Medico medico, Paciente paciente)
        {
            {
                if (medico.getDisponibilidad())
                {
                    if (medico.getEspecialidad() == getEspecialidad())
                    {
                        return getCosto() - getCosto() * paciente.getCobertura();
                    }
                    else
                    {
                        throw new Exception("El medico no es de la especialidad requerida");
                    }
                }
                else
                {
                    throw new Exception("El medico no esta disponible");
                }
            }
        }

        public override float getCosto()
        {
            return base.getCosto() + getAdicional();
        }
        public float getAdicional()
        {
            return adicional;
        }
    }
}
