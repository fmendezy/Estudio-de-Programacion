using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public static class PeliculaController
    {
        public static string Create(Pelicula p)
        {
            var res = PeliculaCollection.ListadoPeliculas.Find(x => x.Nombre == p.Nombre);
            if (res != null)
                return "Pelicula existente";

            PeliculaEntity entity = new PeliculaEntity()
            {
                //Id = p.Id,
                Nombre = p.Nombre,
                Director = p.Director,
                Idioma = p.Idioma,
                Duracion = p.Duracion,
                Valoracion = p.Valoracion,
                EsTodoPublico = p.EsTodoPublico,
                EnCartelera = p.EnCartelera,
                TieneSubtitulos = p.TieneSubtitulos,
                FechaEstreno = p.FechaEstreno,
            };

            PeliculaCollection.ListadoPeliculas.Add(entity);
            return $"Pelicula '{p.Nombre}' agregada correctamente.";
        }


        public static Pelicula Read(string id)
        {
            var res = PeliculaCollection.ListadoPeliculas.Find(x => x.Id == id);
            if (res == null) return null;

            Pelicula peli = new Pelicula()
            {
                Id = res.Id,
                Nombre = res.Nombre,
                Director = res.Director,
                Idioma = res.Idioma,
                Duracion = res.Duracion,
                Valoracion = res.Valoracion,
                EsTodoPublico = res.EsTodoPublico,
                EnCartelera = res.EnCartelera,
                TieneSubtitulos = res.TieneSubtitulos,
                FechaEstreno = res.FechaEstreno,
                CreatedAt = res.RetornarCreatedAt()
            };
            return peli;
        }


        public static string Update(string id, int newValoracion, bool cartelera)
        {
            var res = PeliculaCollection.ListadoPeliculas.Find(x => x.Id == id);
            if (res == null) return $"Pelicula con ID: {id} no encontrada";

            res.Valoracion = newValoracion;
            res.EnCartelera = cartelera;

            return $"Pelicula '{res.Nombre}' actualizada correctamente.";
        }

        public static string Delete(string id)
        {
            var res = PeliculaCollection.ListadoPeliculas.Find(x => x.Id == id);
            if (res == null) return $"Pelicula con ID: {id} no encontrada";

            PeliculaCollection.ListadoPeliculas.Remove(res);
            return $"Pelicula ID: '{id}' eliminada correctamente.";
        }
        
        public static List<Pelicula> ReadAll()
        {
            List<Pelicula> pelis = new List<Pelicula>();

            PeliculaCollection.ListadoPeliculas.ForEach(x =>
            {
                Pelicula p = new Pelicula()
                {
                    Id = x.Id,
                    Nombre = x.Nombre,
                    Director = x.Director,
                    Idioma = x.Idioma,
                    Duracion = x.Duracion,
                    Valoracion = x.Valoracion,
                    EsTodoPublico = x.EsTodoPublico,
                    EnCartelera = x.EnCartelera,
                    TieneSubtitulos = x.TieneSubtitulos,
                    FechaEstreno = x.FechaEstreno,
                    CreatedAt = x.RetornarCreatedAt()
                };
                pelis.Add(p);
            });
            return pelis;
        }

        public static List<Pelicula> Search(string filter)
        {
            List<Pelicula> pelis = new List<Pelicula>();

            PeliculaCollection.ListadoPeliculas.Where(x =>
            x.Nombre.Contains(filter) ||
            x.Director.Contains(filter) ||
            x.Idioma.Contains(filter))
            .ToList()
            .ForEach(x =>
            {
                Pelicula p = new Pelicula()
                {
                    Id = x.Id,
                    Nombre = x.Nombre,
                    Director = x.Director,
                    Idioma = x.Idioma,
                    Duracion = x.Duracion,
                    Valoracion = x.Valoracion,
                    EsTodoPublico = x.EsTodoPublico,
                    EnCartelera = x.EnCartelera,
                    TieneSubtitulos = x.TieneSubtitulos,
                    FechaEstreno = x.FechaEstreno,
                    CreatedAt = x.RetornarCreatedAt()
                };
                pelis.Add(p);
            });
            return pelis;
        }
    }
}

/*
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Director { get; set; }
        public string Idioma { get; set; }
        public int Duracion { get; set; }
        public int Valoracion { get; set; }
        public bool EsTodoPublico { get; set; }
        public bool EnCartelera { get; set; }
        public bool TieneSubtitulos { get; set; }
        public DateTime FechaEstreno { get; set; }
        public DateTime CreatedAt { get; set; }

*/