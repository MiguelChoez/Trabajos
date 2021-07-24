using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenMiguelChoez.Entities
{
    public class Conyuge
    {
        public int ConyugeId { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        [NotMapped]
        public string NombreCompleto { get { return $"{Nombre} {Apellido}"; } }


        [ForeignKey("Empleado")]
        [DisplayName("Empleado")]

        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }

    }
}
