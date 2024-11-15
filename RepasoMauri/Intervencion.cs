using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorio
{
    public class Intervencion
    {
        private int codigo;
        private string descripcion;
        private string especialidad;
        public float costo;

        public Intervencion(int codigo, string descripcion, string especialidad)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.especialidad = especialidad;
            costo = 10000;
        }

        public virtual float CalcularCosto(Medico medico, Paciente paciente)
        {
                if (medico.getDisponibilidad())
                {
                    if (medico.getEspecialidad() == getEspecialidad())
                    {
                        return getCosto() - getCosto() * paciente.getCobertura();
                    } else
                    {
                        throw new Exception("El medico no es de la especialidad requerida");
                    }
                } else
                {
                    throw new Exception("El medico no esta disponible");
                }
            } 
        public int getCodigo()
        {
            return codigo;
        }

        public virtual float getCosto()
        {
            return costo;
        }

        public string getDescripcion()
        {
            return descripcion;
        }

        public string getEspecialidad()
        {
            return especialidad;
        }
    }
}