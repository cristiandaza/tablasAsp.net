using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppEjercicioFinal.Models
{
    public class Producto
    {
        public int ProductoID { get; set; }
        public string NombreProducto { get; set; }
        public byte CantidadProducto { get; set; }
        public string PrecioProducto { get; set; }
        public ICollection<Tienda> Tiendas { get; set; }
    }
}
