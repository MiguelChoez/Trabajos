using ExamenMiguelChoez.Data;
using ExamenMiguelChoez.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenMiguelChoez.Controllers
{
    public class ConsultasController : Controller
    {
        readonly ApplicationDbContext _context;
        public ConsultasController(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }
        public IEnumerable<Departamento> Departamentos()
        {
            return _context.Departamentos;
        }
        //public IEnumerable<EmpleadoSimple> Empleados()
        //{
        //    IQueryable<Empleado> consulta = _context.Empleados.Include(e => e.CursosTomados);

        //    //Select(i=>i.Institucion.Nombre)); //como traigo la institucion

        //    List<Empleado> empleados = consulta.ToList();
        //    return empleados.Select(e => EmpleadoSimple.Convertir(e));
        //}
        //public IEnumerable<EmpleadoSimple> EmpleadosPaginados(int pagina, int tamano)
        //{
        //    var salto = (pagina - 1) * tamano;
        //    var empleados = _context.Empleados.Skip(salto).Take(tamano).ToList();
        //    return empleados.Select(e => EmpleadoSimple.Convertir(e));
        //}
    
    }
}
