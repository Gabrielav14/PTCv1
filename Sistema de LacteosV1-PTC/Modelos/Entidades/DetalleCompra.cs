using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class DetalleCompra
    {
        private int idDetalleCompra;
        private int cantidad;
        private int id_Compra;
        private int id_Producto;

        public DetalleCompra()
        {
        }

        public DetalleCompra(int idDetalleCompra, int cantidad)
        {
            this.IdDetalleCompra = idDetalleCompra;
            this.Cantidad = cantidad;
        }

        public DetalleCompra(int idDetalleCompra, int cantidad, int id_Compra, int id_Producto) : this(idDetalleCompra, cantidad)
        {
            this.Id_Compra = id_Compra;
            this.Id_Producto = id_Producto;
        }

        public int IdDetalleCompra { get => idDetalleCompra; set => idDetalleCompra = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Id_Compra { get => id_Compra; set => id_Compra = value; }
        public int Id_Producto { get => id_Producto; set => id_Producto = value; }
    }
}
