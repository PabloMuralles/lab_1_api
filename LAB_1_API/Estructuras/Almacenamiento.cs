using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB_1_API.Estructuras
{
    public class Almacenamiento
    {
        private static Almacenamiento _instance = null;
        public static Almacenamiento Instance
        {
            get
            {
                if (_instance == null) _instance = new Almacenamiento();
                return _instance;
            }
        }

        public Stack<Peliculas> listado = new Stack<Peliculas>();
        public List<Peliculas> nuevalista = new List<Peliculas>();
        public void llenado_pila(string N, int D, string M)
        {
            listado.Push(new Peliculas
            {
                Name = N,
                Year = D,
                Director = M
            });
        }
        public List<Peliculas> mostrar()
        {
            if (listado.Count > 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    nuevalista.Add(listado.Pop());
                }
            }
            else
            {
                nuevalista = null;
            }
            return nuevalista;
        }
    }
}
