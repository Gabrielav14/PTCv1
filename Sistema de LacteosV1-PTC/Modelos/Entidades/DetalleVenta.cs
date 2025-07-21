using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class DetalleVenta
    {
      private int idDetalleVenta;
        private int id_Compra;
        private int id_Usuario;

        public int IdDetalleVenta { get => idDetalleVenta; set => idDetalleVenta = value; }
        public int Id_Compra { get => id_Compra; set => id_Compra = value; }
        public int Id_Usuario { get => id_Usuario; set => id_Usuario = value; }
    }
}
