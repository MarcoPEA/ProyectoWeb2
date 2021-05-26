using System;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Models
{
    public class Pedidos
    {
        public int IdPedido { get; set; }
        public int IdUsuario { get; set; }
        public int IdProducto { get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
      
    }
}