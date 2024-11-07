using System;

namespace ComposicionEjemplo
{
    
    public class Motor
    {
        public int CaballosDeFuerza { get; set; }
        public string Tipo { get; set; }

        public Motor(int caballosDeFuerza, string tipo)
        {
            CaballosDeFuerza = caballosDeFuerza;
            Tipo = tipo;
        }

        public void Encender()
        {
            Console.WriteLine("El motor está encendido.");
        }

        public void Apagar()
        {
            Console.WriteLine("El motor está apagado.");
        }
    }

    
    public class Coche
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        private Motor motor; 

        public Coche(string marca, string modelo, int caballosDeFuerza, string tipoMotor)
        {
            Marca = marca;
            Modelo = modelo;
            motor = new Motor(caballosDeFuerza, tipoMotor);
        }

        public void Arrancar()
        {
            motor.Encender();
            Console.WriteLine($"El coche {Marca} {Modelo} está arrancado.");
        }

        public void Detener()
        {
            motor.Apagar();
            Console.WriteLine($"El coche {Marca} {Modelo} está detenido.");
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Coche: {Marca} {Modelo}, Motor: {motor.Tipo} con {motor.CaballosDeFuerza} HP.");
        }
    }    
}