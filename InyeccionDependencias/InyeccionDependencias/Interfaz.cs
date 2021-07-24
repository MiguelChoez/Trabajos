using InyeccionDependencias.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencias
{
    public interface IStock
    {
        string disponibleStock(Producto producto);
    }
}
