using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.EntityFrameworkCore;
using MoviesManager.BLL;

namespace MoviesManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Peliculas pelicula;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BuardarButton_Click(object sender, RoutedEventArgs e)
        {
            this.pelicula = new Peliculas();
            this.pelicula.Titulo = $"Otra pelicula ";
             
            PeliculasBLL.Insertar(this.pelicula);
             
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            Contexto contexto = new Contexto();

            this.pelicula=  contexto.Peliculas.Find(1);
            contexto.Dispose();

            MessageBox.Show(pelicula.Titulo);
        }

        private void ModificarButton_Click(object sender, RoutedEventArgs e)
        {
            pelicula.Titulo = "Terminator 1";
            
            
            Contexto contexto = new Contexto();            

            contexto.Entry(this.pelicula).State = EntityState.Modified;

            contexto.SaveChanges();
            contexto.Dispose();
        }           

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            Contexto contexto = new Contexto();

            contexto.Peliculas.Remove(this.pelicula);
            contexto.SaveChanges();
            contexto.Dispose();
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

