using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BackEnd_ejemplo1.Models;

namespace BackEnd_ejemplo1.Services
{
    public class PeliculaService
    {
        public List<Pelicula> ObtenerPelicula()
        {
            var pelicula1 = new Models.Pelicula()
            {
                Titulo = "Superman",
                Duracion = 150,
                Pais = "USA",
                Publicacion = new DateTime(2011, 12, 11)
            };
            var pelicula2 = new Models.Pelicula()
            {
                Titulo = "Spiderman",
                Duracion = 180,
                Pais = "USA",
                Publicacion = new DateTime(2015, 05, 02)
            };
            return new List<Pelicula> { pelicula1,pelicula2};
        }
    }
}