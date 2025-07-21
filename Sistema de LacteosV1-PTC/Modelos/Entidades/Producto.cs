using Modelos.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class Producto
    {

        private int idProducto;
        private string nombreProducto;
        private decimal peso;
        private decimal precioUnitario;
        private int cantidadDisponible;
        private DateTime fechaEntrada;
        private DateTime fechaVencimiento;
        private int id_Categoria;
        private int id_Proveedor;
        private int id_UnidadMedida;

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public decimal Peso { get => peso; set => peso = value; }
        public decimal PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        public int CantidadDisponible { get => cantidadDisponible; set => cantidadDisponible = value; }
        public DateTime FechaEntrada { get => fechaEntrada; set => fechaEntrada = value; }
        public DateTime FechaVencimiento { get => fechaVencimiento; set => fechaVencimiento = value; }
        public int Id_Categoria { get => id_Categoria; set => id_Categoria = value; }
        public int Id_Proveedor { get => id_Proveedor; set => id_Proveedor = value; }
        public int Id_UnidadMedida { get => id_UnidadMedida; set => id_UnidadMedida = value; }
    }
}
