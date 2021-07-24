using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenMiguelChoez.Entities
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public int NumeroCreditos { get; set; }
        public List<Empleado> Participantes { get; set; }

        public Institucion Institucion { get; set; }
    }

    public class Institucion
    {
        public int InstitucionId { get; set; }
        public string Nombre { get; set; }
    }
}
