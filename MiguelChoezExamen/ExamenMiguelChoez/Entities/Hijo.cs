using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenMiguelChoez.Entities
{
    public class Hijo
    {
        public int HijoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Nacimiento { get; set; }
        public Empleado Ancestro { get; set; }

        [NotMapped]
        public string NombreCompleto { get { return $"{Nombre} {Apellido}"; } }

        [NotMapped]
        public double Edad { get { return DateTime.Now.Subtract(Nacimiento).TotalDays / 365; } }
        [NotMapped]
        public bool EsCarga { get { return Edad < 18; } }

    }
}
