using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesManager.BLL
{
    public static class PeliculasBLL
    {
        public static void Insertar(Peliculas pelicula)
        {
            Contexto contexto = new Contexto();
            try
            {
                contexto.Peliculas.Add(pelicula);
                contexto.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();

            }
        }

        public static Peliculas Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Peliculas pelicula;
            try
            {
                pelicula = contexto.Peliculas.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            finally {
                contexto.Dispose();
            }


            return pelicula;
        }
    }
}
