using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo_Karina
{
    class Producto
    {
        private int _codigo;
        private string _nombre;
        private int _cantidad;
        private double _costo;

        public Producto(int _codigo, string _nombre, int _cantidad, double _costo)
        {
            this._cantidad = _cantidad;
            this._codigo = _codigo;
            this._costo = _costo;
            this._nombre = _nombre;
        }

        public int Codigo => _codigo;


        public override string ToString()
        {
            return "Codigo: " + _codigo + " *** "  + "Nombre: " + _nombre + " *** " + "Cantidad: " + _cantidad + " *** " + "Costo: $" + _costo;
        }


    }
}
