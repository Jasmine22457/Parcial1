using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial1.Entidades
{
    class Usuario
    {
        private string nombre;
        private int contraseña;

        public Usuario(string nombre, int contraseña)
        {
            this.Nombre = nombre;
            this.Contraseña = contraseña;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Contraseña { get => contraseña; set => contraseña = value; }
    }
}