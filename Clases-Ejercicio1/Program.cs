using System;
using ClaseVehiculos.MisClases;
namespace ClaseVehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo vehiculo1 = new Auto("MT-512", enumColores.AZUL, "4517825", enumEstados.APAGADO, "4" , enumEstadoGiro.NINGUNO);
            Vehiculo vehiculo2 = new Moto("MT-52", enumColores.AZUL, "34343", enumEstados.APAGADO, "4000", enumEstadoGiro.NINGUNO);
        }
    }
}
