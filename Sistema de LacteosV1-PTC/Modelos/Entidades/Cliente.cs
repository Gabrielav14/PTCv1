using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class Cliente
    {
        private int idCliente;
        private string nombreCliente;
        private string apellido;
        private string correoElectronicoClien;
        private string dui;
        private string direccion;
        private string telefono;

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string CorreoElectronicoClien { get => correoElectronicoClien; set => correoElectronicoClien = value; }
        public string Dui { get => dui; set => dui = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        public Cliente()
        {
        }

        public Cliente(int idCliente, string nombreCliente, string apellido)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellido = apellido;
        }

        public Cliente(int idCliente, string nombreCliente, string apellido, string correoElectronicoClien, string dui, string direccion, string telefono) : this(idCliente, nombreCliente, apellido)
        {
            this.correoElectronicoClien = correoElectronicoClien;
            this.dui = dui;
            this.direccion = direccion;
            this.telefono = telefono;
        }
    }
}
