using System;

namespace POO_Vehiculos
{
    internal class Auto : Vehiculo

    {
        public int NumeroDePuertas { get; set; }
        public Auto(string marca, string modelo, int anio, double kilometraje, int numeroDePuertas) : base(marca, modelo, anio, kilometraje)
        {
            this.NumeroDePuertas = numeroDePuertas;
        }

        public override void Encender()
        {
            Console.WriteLine($"El auto {marca}, que es un {modelo} está encendido.");
        }

        public override void Apagar()
        {
            Console.WriteLine($"El auto {marca} está apagado.");
        }

        public override void Conducir(double km)
        {
            Kilometraje += km;
            Console.WriteLine($"El auto {marca}, de modelo {modelo} ha conducido {km} kilómetros.");
        }
    }
}