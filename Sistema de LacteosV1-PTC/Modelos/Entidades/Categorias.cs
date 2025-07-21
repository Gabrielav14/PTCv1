using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class Categorias
    {
        private int idCategoria;
        private string nombreCategoria;
        private int id_Tipo;

        public Categorias()
        {
        }

        public Categorias(int idCategoria, string nombreCategoria, int id_Tipo)
        {
            this.idCategoria = idCategoria;
            this.nombreCategoria = nombreCategoria;
            this.id_Tipo = id_Tipo;
        }

        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string NombreCategoria { get => nombreCategoria; set => nombreCategoria = value; }
        public int Id_Tipo { get => id_Tipo; set => id_Tipo = value; }
    }
}
