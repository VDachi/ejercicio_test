using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_list
{
    class Gato
    {
        private int id;
        private string nombre;
        private string color;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Color { get => color; set => color = value; }

        public Gato() {
            id = 0;
            Nombre = "";
            Color = "";
        }
    }
}
