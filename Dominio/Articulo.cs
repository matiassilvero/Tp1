using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_1
{
    public class Articulo 
    {
        public int ID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public string ImgURL { get; set; }
        public SqlMoney Precio { get; set; }
        //public string Precio { get; set; } el String entra en conflicto con el tipo de dato de SQL

    }
}
