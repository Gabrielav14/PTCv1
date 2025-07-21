using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class UnidadMedida
    {
        private int idUnidadMedida;
        private string nombreUnidad;

        public UnidadMedida()
        {
        }

        public UnidadMedida(int idUnidadMedida, string nombreUnidad)
        {
            this.idUnidadMedida = idUnidadMedida;
            this.nombreUnidad = nombreUnidad;
        }

        public int IdUnidadMedida { get => idUnidadMedida; set => idUnidadMedida = value; }
        public string NombreUnidad { get => nombreUnidad; set => nombreUnidad = value; }
    }
}
