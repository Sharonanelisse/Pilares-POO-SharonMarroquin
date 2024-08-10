using System;

namespace POO_Vehiculos
{
    abstract class Vehiculo
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public int anio;
        public double kilometraje { get; set; }

        public double Kilometraje
        {
            get { return kilometraje; }
            set { kilometraje = value; }
        }

        public Vehiculo(string marca, string modelo, int año, double kilometraje)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.anio = año;
            this.kilometraje = kilometraje;
        }
        public abstract void Encender();
        public abstract void Apagar();
        public abstract void Conducir(double km);
    }
}