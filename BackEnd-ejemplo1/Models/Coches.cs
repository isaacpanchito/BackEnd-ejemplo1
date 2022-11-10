using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace BackEnd_ejemplo1.Models
{
    public class Coches
    {
        public string IdCoche { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Propietario { get; set; }
        public Coches(string idCoche, string marca, string modelo, string propietario)
        {
            this.IdCoche = idCoche;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Propietario = propietario;
        }

    }
}