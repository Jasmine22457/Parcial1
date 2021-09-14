using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using parcial1.Negocio;
using parcial1.Entidades;

namespace parcial1
{
    class Program
    {
        static void Main(string[] args)
        {

            ClsUsuario clsusuario = new ClsUsuario();
            Usuario usu = new Usuario();

            Console.WriteLine("por favor ingrese su nombre de usuario: ");
            String usuario  = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Por favor ingrese su contraseña :  ");
            int contraseña = Convert.ToInt32(Console.ReadLine());
            Usuario conts = new Usuario(usuario, contraseña );

            Console.WriteLine(clsusuario.ACCESO(conts));

            if (clsusuario.y == 1)
            {
                NClsventas nClsventas = new NClsventas();
                int venta  = 1;

                while (venta  == 1)
                {
                    Console.WriteLine("Ingrese el nombre del producto: ");
                    string nombre = (Console.ReadLine());


                    Console.WriteLine("Ingrese la descripcion que contiene el producto: ");
                    string descripcion_de_Producto =(Console.ReadLine());

                    Console.WriteLine("por favor ingrese el id del producto ");

                    int id = Convert.ToInt32(Console.ReadLine());
                    
                   
                    Console.WriteLine("Ingreser el precio del  producto: ");
                    double precio = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Ingrese el numero de productos que desea llevar : ");
                    int cantidad = Convert.ToInt32(Console.ReadLine());

                    venta prod = new venta(nombre, descripcion_de_Producto, id, precio, cantidad);
                    Console.WriteLine(nClsventas.Cobro(prod));
                }





            }
        }
    }
}
