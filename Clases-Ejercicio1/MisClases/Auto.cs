using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseVehiculos.MisClases
{
    class Auto : Vehiculo
    {
        protected string NroPuertas;

        //CONSTRUCTOR
        public Auto(string placa, enumColores color, string nroSerie, enumEstados estado, string NroPuertas, enumEstadoGiro estadoGiro)
        : base(placa, color, nroSerie, estado, estadoGiro)
        {
            this.NroPuertas = NroPuertas;
        }
    }
}
