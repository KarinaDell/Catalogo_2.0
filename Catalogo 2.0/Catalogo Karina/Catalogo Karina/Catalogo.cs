using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo_Karina
{
    class Catalogo
    {
        private Producto[] productos = new Producto[15];
        int c = 0;

        public void Agregar(Producto producto)
        {
            if(c != 14)
            {
                productos[c++] = producto;
                metodoOrdenar();
            }
        }

        public string Buscar(int _codigo)
        {
            string s = "";
            //int L = 0, R = c, m = c / 2;
            
            //if (m < _codigo)
            //{
            //    L = m + 1;
            //}
            //else if(m > _codigo)
            //{
            //    R = m - 1;
            //}
            //else
            //{
            //    s += productos[m].ToString();
            //    return s;
            //}

            for (int i = 0; i < 14; i++)
                if (productos[i] != null)
                    if (_codigo == productos[i].Codigo)
                        s += productos[i].ToString();
            return s;
        }

        public void Eliminar(int _codigo)
        {
            int posicion = 0;
            for (int i = 0; i < 14; i++)
                if (productos[i] != null)
                    if (_codigo == productos[i].Codigo) {
                        posicion = i;
                        break;
                    }
            for (int j = posicion; j < 14; j++)
                productos[j] = productos[j + 1];
            productos[14] = null;
            c--;
        }

        public string listar()
        {
            string s = "";
            for (int i = 0; i < 14; i++)
                if (productos[i] != null)
                    s += productos[i].ToString()+Environment.NewLine;
            return s;
        }

        public void metodoOrdenar()
        {
            Producto t;
            for (int a = 1; a < c; a++)
                for (int b = c - 1; b >= a; b--)
                {
                    if (productos[b - 1].Codigo > productos[b].Codigo)
                    {
                        t = productos[b - 1];
                        productos[b - 1] = productos[b];
                        productos[b] = t;
                    }
                }
        }
    }
}
