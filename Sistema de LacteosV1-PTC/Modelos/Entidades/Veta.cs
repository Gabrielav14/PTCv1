using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class Veta
    {
        private int idUsuario;
        private int idCliente;
        private DateTime fecha;
        private string tipoPago;

        public Veta()
        {
        }

        public Veta(int idUsuario, int idCliente, DateTime fecha, string tipoPago)
        {
            this.idUsuario = idUsuario;
            this.idCliente = idCliente;
            this.fecha = fecha;
            this.tipoPago = tipoPago;
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string TipoPago { get => tipoPago; set => tipoPago = value; }
    }
}
