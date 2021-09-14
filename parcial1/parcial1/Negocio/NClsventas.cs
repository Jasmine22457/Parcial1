using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using parcial1.Entidades;
namespace parcial1.Negocio
{
    class NClsventas
    {
        public string Cobro(venta prod)
        {

            double precio = prod.Precio * prod.Cantidad;

            if (prod.Precio > 50)
            {
                double total = precio - (precio * 0.20);

                Console.WriteLine("su pago con descuento sera de : " + total + " el precio original sin descuento es de : " + precio);


            }
            else
                Console.WriteLine("su pago no aplica descuento " + precio);

            return "";

        }
     
            
   
    }
}
