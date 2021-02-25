using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boutique_Virtual
{
    class DatosProducto
    {
        public int codigo;
        public string producto;
        public string talla;
        public double valor;

        public DatosProducto(int codigo, string producto, string talla, double valor)
        {
            this.codigo = codigo;
            this.producto = producto;
            this.talla = talla;
            this.valor = valor;
        }

        public override string ToString()
        {
            return producto+" talla "+talla+" $" + valor;
        }

    }
}
