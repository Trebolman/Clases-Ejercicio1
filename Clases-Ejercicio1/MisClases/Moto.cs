using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseVehiculos.MisClases
{
    class Moto:Vehiculo
    {
        protected string cilindrada;
        
        //CONSTRUCTOR
        public Moto(string placa, enumColores color, string nroSerie, enumEstados estado, string cilindrada, enumEstadoGiro estadoGiro)
        :base(placa, color, nroSerie, estado, estadoGiro){
            this.cilindrada = cilindrada;
        }
    }
}
