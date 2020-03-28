using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppEjercicioFinal.Models
{
    public class Tienda
    {
        public int TiendaID { get; set; }
        public int ProductoID { get; set; }
        public Producto Producto { get; set; }
        public string ValorProducto { get; set; }
        public string UbicacionProducto { get; set; }
    }
}
