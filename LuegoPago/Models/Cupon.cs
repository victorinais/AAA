using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuegoPago.Models
{
    public class Cupon
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public DateOnly FechaInicio { get; set; }
        public DateOnly FechaFin { get; set; }

    }
}