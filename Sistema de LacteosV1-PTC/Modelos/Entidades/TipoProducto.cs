using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class TipoProducto
    {
        private int idTipo;
        private string nombreTipo;

        public TipoProducto()
        {
        }

        public TipoProducto(int idTipo, string nombreTipo)
        {
            this.idTipo = idTipo;
            this.nombreTipo = nombreTipo;
        }

        public int IdTipo { get => idTipo; set => idTipo = value; }
        public string NombreTipo { get => nombreTipo; set => nombreTipo = value; }
    }
}
