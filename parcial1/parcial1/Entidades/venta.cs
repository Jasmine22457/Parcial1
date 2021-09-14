using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial1.Entidades
{
    class venta
    {
        
        private string nombre_producto;
        private string drescripcion_de_producto;
        private int id_producto;
        private double precio;
        private int cantidad;

        public int Id_producto { get => id_producto; set => id_producto = value; }
        public string Nombre_producto { get => nombre_producto; set => nombre_producto = value; }
        public string Drescripcion_de_producto { get => drescripcion_de_producto; set => drescripcion_de_producto = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
       

        

        public venta()
        {
        }

        public venta(string nombre_producto, string drescripcion_de_producto, int id_producto, double precio, int cantidad)
        {
            this.nombre_producto = nombre_producto;
            this.drescripcion_de_producto = drescripcion_de_producto;
            this.id_producto = id_producto;
            this.precio = precio;
            this.cantidad = cantidad;

        }
        public override string ToString()
        {
            return "su producto es : " + nombre_producto +
                "\n descripcion del producto : " + drescripcion_de_producto +
                "\n la id de prodcuto es :  " + id_producto +
                "\n el precio del producto es: " + precio +
                "\n la cantidad de productos que llevara es : " + Cantidad;
        }
    }   
    
}   
