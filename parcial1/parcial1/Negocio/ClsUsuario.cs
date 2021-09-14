using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using parcial1.Entidades;

namespace parcial1.Negocio
{
    class ClsUsuario
    {
        public string Contraseña { get; private set; }

        string usuario = "Rocio";
        int contraseña = 123;
        public int y = 1;

       public string ACCESO(Usuario conts)
        {
            if (conts.Nombre == usuario && conts.Contraseña == contraseña)
            {
                
                return "Has iniciado sesion correctamente";

            }

            else
                y = 2;
            return "No has iniciado sesion  correcta";

        }
            
            

    }
                

 }

           
   
    

