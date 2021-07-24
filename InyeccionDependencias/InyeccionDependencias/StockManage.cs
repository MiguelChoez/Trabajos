using InyeccionDependencias.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencias
{
    class StockManage
    {
        IStock stock;
        public StockManage(IStock Stock)
        {
            stock = Stock;
        }
        public string MakeStock(Producto producto)
        {
            return stock.disponibleStock(producto);
        }
    
    }
}
