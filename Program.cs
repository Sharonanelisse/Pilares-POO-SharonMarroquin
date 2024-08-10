using System;

namespace POO_Vehiculos;

internal class Program
{
    static void Main()
    {
        Auto Toyota = new Auto("Toyota", "Hailux", 2024, 20000, 4);
        Toyota.Encender();
        Toyota.Conducir(20);
        Toyota.Apagar();


        Motocicleta Ducati = new Motocicleta("Ducati", "Monster", 2023, 41000, "Moto Deportiva");
        Ducati.Encender();
        Ducati.Conducir(15);
        Ducati.Apagar();

        Camion RenaultTruck = new Camion("Renault", "Trucks E-Tech T", 2020, 75100, 44);
        RenaultTruck.Encender();
        RenaultTruck.Conducir(30);
        RenaultTruck.Apagar();

    }
}