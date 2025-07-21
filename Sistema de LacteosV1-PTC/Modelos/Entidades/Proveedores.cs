using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class Proveedores
    {
        private int idProveedor;
        private string nombreProveedor;
        private string nombreEmpresa;
        private string telefono;
        private string correoElectronico;
        private DateTime fechaIngreso;

        public Proveedores()
        {
        }

        public Proveedores(int idProveedor, string nombreProveedor, string nombreEmpresa, string telefono, string correoElectronico, DateTime fechaIngreso)
        {
            this.idProveedor = idProveedor;
            this.nombreProveedor = nombreProveedor;
            this.nombreEmpresa = nombreEmpresa;
            this.telefono = telefono;
            this.correoElectronico = correoElectronico;
            this.fechaIngreso = fechaIngreso;
        }

        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public string NombreProveedor { get => nombreProveedor; set => nombreProveedor = value; }
        public string NombreEmpresa { get => nombreEmpresa; set => nombreEmpresa = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    }
}
