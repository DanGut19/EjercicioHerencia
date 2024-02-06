using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EjercicioHerencia
{
    internal class PlantaNoComestible : Plantas
    {
        public bool EsVenenosa { get; set; }
        public bool TieneSemilla { get; set; }
        public bool TieneFlores { get; set; }

        public void Imprimir()
        {
            Console.WriteLine($"-------------------------------------------------");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Tipo: {Tipo}");
            Console.WriteLine($"Tamano: {Tamano}");
            Console.WriteLine($"Familia: {Familia}");
            Console.WriteLine($"EsVenenosa: {(EsVenenosa ? "Si" : "No")}");
            Console.WriteLine($"TieneSemillas: {(TieneSemilla ? "Si" : "No")}");
            Console.WriteLine($"TieneFlores: {(TieneFlores ? "Si" : "No")}");
        }
    }
}
