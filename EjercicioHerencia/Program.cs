// See https://aka.ms/new-console-template for more information
using EjercicioHerencia;

Console.WriteLine("Hello, World!");

PlantaComestible plantaComestible = new PlantaComestible();
plantaComestible.Nombre = "Sandia";
plantaComestible.Tipo = "Planta Anual";
plantaComestible.Tamano = "Grande";
plantaComestible.Familia = "Cucurbitaceae";
plantaComestible.EsVenenosa = false;
plantaComestible.TieneSemillas = true;
plantaComestible.TieneFlores = false;
plantaComestible.Imprimir();


PlantaNoComestible plantaNoComestible = new PlantaNoComestible();
plantaComestible.Nombre = "Azucenas";
plantaComestible.Tipo = "Lilium Candidum";
plantaComestible.Tamano = "Mediano";
plantaComestible.Familia = "Liliaceas";
plantaComestible.EsVenenosa = true;
plantaComestible.TieneSemillas = false;
plantaComestible.TieneFlores = true;
plantaComestible.Imprimir();
