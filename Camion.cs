using System;

namespace POO_Vehiculos
{
    internal class Camion : Vehiculo

    {

        public int CapacidadDeCarga { get; set; }
        public Camion(string marca, string modelo, int anio, double kilometraje, int capacidadDeCarga) : base(marca, modelo, anio, kilometraje)
        {
            this.CapacidadDeCarga = capacidadDeCarga;
        }

        public override void Encender()
        {
            Console.WriteLine($"El camion de marca {marca} está encendida.");
        }

        public override void Apagar()
        {
            Console.WriteLine($"El camion de marca {marca} y modelo {modelo} esta apagado");
        }

        public override void Conducir(double km)
        {
            Kilometraje += km;
            Console.WriteLine($"El camion de marca {marca} y modelo {modelo} ha conducido {km} kilómetros.");
        }
    }
}