using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorio
{
    public class Medico
    {
        private string nombreCompleto;
        private string matriculaProfesional;
        private string especialidad;
        private bool disponible;

        public Medico(string nombreCompleto, string matriculaProfesional, string especialidad, bool disponible)
        {
            this.nombreCompleto = nombreCompleto;
            this.matriculaProfesional = matriculaProfesional;
            this.especialidad = especialidad;
            this.disponible = disponible;
        }

        public string getNombreCompleto()
        {
            return nombreCompleto;
        }

        public string getMatriculaProfesional()
        {
            return matriculaProfesional;
        }

        public string getEspecialidad()
        {
            return especialidad;
        }

        public bool getDisponibilidad()
        {
            return disponible;
        }
    }
}
