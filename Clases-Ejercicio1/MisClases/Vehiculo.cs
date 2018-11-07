using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseVehiculos.MisClases
{
    class Vehiculo
    {
        // ATRIBUTOS
        public string placa;
        public enumColores color;
        private string nroSerie;
        public enumEstados estado;
        public enumEstadoGiro estadoGiro;

        //CONSTRUCTOR
        //public Vehiculo(string placa="", enumColores color=enumColores.AMARILLO, string nroSerie="MT-452", enumEstados estado=enumEstados.APAGADO)
        public Vehiculo(string placa, enumColores color, string nroSerie, enumEstados estado, enumEstadoGiro estadoGiro)
        {
            this.placa = placa;
            this.color = enumColores.AMARILLO;
            this.nroSerie = nroSerie;
            this.estado = enumEstados.APAGADO;
            this.estadoGiro = enumEstadoGiro.NINGUNO;
        }

    // METODOS
        //public string Placa() { }
        public string Encender()
        {
            estado = enumEstados.ENCENDIDO;
            return $"Vehiculo {estado}";
        }
        public string frenar()
        {
            estado = enumEstados.APAGADO;
            return $"Vehiculo {estado}";
        }
        public string Girar(enumDirecciones direccion)
        {
            //estadoGiro = ;
            return $"Vehiculo girando a la {direccion}";
        }
    }
}
