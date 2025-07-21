using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class Compra
    {
        private int idCompra;
        private DateTime fecha;
        private decimal totalPago;
        private string tipoPago;
        private int id_Cliente;

        public Compra()
        {
        }

        public Compra(int idCompra, DateTime fecha, decimal totalPago)
        {
            this.idCompra = idCompra;
            this.fecha = fecha;
            this.totalPago = totalPago;
        }

        public Compra(int idCompra, DateTime fecha, decimal totalPago, string tipoPago, int id_Cliente) : this(idCompra, fecha, totalPago)
        {
            this.tipoPago = tipoPago;
            this.id_Cliente = id_Cliente;
        }

        public int IdCompra { get => idCompra; set => idCompra = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public decimal TotalPago { get => totalPago; set => totalPago = value; }
        public string TipoPago { get => tipoPago; set => tipoPago = value; }
        public int Id_Cliente { get => id_Cliente; set => id_Cliente = value; }
    }
}
