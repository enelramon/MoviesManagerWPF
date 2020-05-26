using Microsoft.EntityFrameworkCore;

namespace MoviesManager
{
    public class Contexto : DbContext
    {
        public DbSet<Peliculas> Peliculas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Movies.db");
        }
    }
}

// 1. Creamos el proyecto en nuestro computador
// 2. Creamos el proyecto en github
// 3. Amarramos paso 1 y 2.
// 4. Instalamos Microsoft.EntityFrameworkCore.SqLite y Microsoft.EntityFrameworkCore.Tools
// 5. Creamos la clase peliculas
// 6. Creamos el Contexto que hereda DbContext y sobre escribimos el OnConfiguring
// 7. Agregamos la migración con el comando: Add-Migration "Inicial"
// 8. Ejecutamos la migración con el comando: Update-Database
// 9. 

