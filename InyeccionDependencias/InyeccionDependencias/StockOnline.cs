using InyeccionDependencias.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencias
{
    class StockOnline : IStock
    {
        public string disponibleStock(Producto producto)
        {
            return $"el producto {producto.NombreProducto} en la tienda online esta disponible y tiene el precio de: {producto.PrecioProducto}";
        }
    }
}
