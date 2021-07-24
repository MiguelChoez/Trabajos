using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenMiguelChoez.Entities
{
    public class Departamento
    {
        public int DepartamentoId { get; set; }
        public string Nombre { get; set; }
        public float Presupuesto { get; set; }
        public List<Empleado> Empleados { get; set; }
    }
}
