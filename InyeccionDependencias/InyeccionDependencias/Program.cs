using System;
using Unity;

namespace InyeccionDependencias
{
    class Program
    {
        
        static StockManage stockManage;
        static void Main(string[] args)
        {
            Init();

            Console.WriteLine("Comprobando stock");
            Console.WriteLine(stockManage.MakeStock(new Entidades.Producto { NombreProducto = "  Disco DSS 960 GB  ",  PrecioProducto   =   128 }));
            Console.WriteLine(stockManage.MakeStock(new Entidades.Producto { NombreProducto = "  Teclado Genius usb",  PrecioProducto   =   12.50 }));



        }
        static void Init()
        {
            var container = new UnityContainer();
            container.RegisterType<IStock, Stock>();
            stockManage = container.Resolve<StockManage>();
        }
        
    }
}
