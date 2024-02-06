
namespace EjercicioHerencia
{
    internal class PlantaComestible : Plantas
    {
        public bool EsVenenosa { get; set; }
        public bool TieneSemillas { get; set; }
        public bool TieneFlores { get; set; }

        public void Imprimir()
        {
            Console.WriteLine($"-------------------------------------------------");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Tipo: {Tipo}");
            Console.WriteLine($"Tamano: {Tamano}");
            Console.WriteLine($"Familia: {Familia}");
            Console.WriteLine($"EsVenenosa: {(EsVenenosa ? "Si" : "No")}");
            Console.WriteLine($"TieneSemillas: {(TieneSemillas ? "Si" : "No")}");
            Console.WriteLine($"TieneFlores: {(TieneFlores ? "Si" : "No")}");
        }
    }
}
