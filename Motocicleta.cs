using System;

namespace POO_Vehiculos
{
    internal class Motocicleta : Vehiculo

    {
        public string MotoTipo { get; set; }
        public Motocicleta(string marca, string modelo, int anio, double kilometraje, string motoTipo) : base(marca, modelo, anio, kilometraje)
        {
            this.MotoTipo = motoTipo;
        }

        public override void Encender()
        {
            Console.WriteLine($"La moto {marca}, que es un {modelo} está encendida.");
        }

        public override void Apagar()
        {
            Console.WriteLine($"La moto {marca} está apagada.");
        }

        public override void Conducir(double km)
        {
            Kilometraje += km;
            Console.WriteLine($"La moto marca {marca} de modelo {modelo} ha conducido {km} kilómetros.");
        }
    }
}