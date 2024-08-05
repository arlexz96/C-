using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerSemana_Biblioteca.Models
{
    public class Libro : Publicacion
    {
        public string Isbn { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public double Precio { get; set; }

        public Libro()
        {

        }

        public Libro(string titulo, int anoPublicacion, string Isbn, string autor, string genero, double precio)
        {
            this.Titulo = titulo;
            this.AnoPublicacion = anoPublicacion;
            this.Isbn = Isbn;
            this.Autor = autor;
            this.Genero = genero;
            this.Precio = precio;
        }

        public void MostrarDatos(){
            Console.Write($@"Titulo: {Titulo}
Año publicacion: {AnoPublicacion}
ISBN: {Isbn}
Autor: {Autor}
Genero: {Genero}
Precio: {Precio}");
        }
    }
}