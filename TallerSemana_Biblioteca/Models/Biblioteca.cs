using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerSemana_Biblioteca.Models
{
    public class Biblioteca
    {
        List<Libro> Libros = new List<Libro>(){
            {
                new Libro
                (
                    "The Catcher in the Rye",
                    1951,
                    "978-0-316-76948-0",
                    "J.D. Salinger",
                    "Ficción literaria",
                    100000
                )
            },
            {
                new Libro
                (
                    "Brave New World",
                    1932,
                    "978-0-06-085052-4",
                    "Aldous Huxley",
                    "Ciencia ficcion",
                    150000
                )
            },
            {
                new Libro
                (
                    "Pride and Prejudice",
                    1813,
                    "978-0-19-953556-9",
                    "Aldous Huxley",
                    "Ficcion",
                    200000
                )
            },
            {
                new Libro
                (
                    "The Hobbit",
                    1937,
                    "978-0-618-00221-3",
                    "J.R.R. Tolkien",
                    "Fantasia",
                    250000
                )
            },
            {
                new Libro
                (
                    "The Midnight Library",
                    2020,
                    "978-0-525-55847-8",
                    "Matt Haig",
                    "Fantasia",
                    120000
                )
            },
            {
                new Libro
                (
                    "Klara and the Sun",
                    2021,
                    "978-0-593-31817-4",
                    "Kazuo Ishiguro",
                    "Ciencia ficcion",
                    150000
                )
            }
        };

        public void AgregarLibro()
        {
            string Titulo, AnoPublicacion, Autor, Genero;
            double Precio;
            int Isbn;

            Console.Write("Ingrese el Titulo del libro: ");
            Titulo = Console.ReadLine();
            Console.Write("\nIngrese el ISBN del libro: ");
            Isbn = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nIngrese el año de publicacion del libro: ");
            AnoPublicacion = Console.ReadLine();
            Console.Write("\nIngrese el autor del libro: ");
            Autor = Console.ReadLine();
            Console.Write("\nIngrese el genero del libro: ");
            Genero = Console.ReadLine();
            Console.Write("\nIngrese el precio del libro: ");
            Precio = Convert.ToDouble(Console.ReadLine());

            Libro libro = new Libro(Titulo, Isbn, AnoPublicacion, Autor, Genero, Precio);

            Console.Write("\nLibro Agregado exitosamente!\n");

            libro.MostrarDatos();

            Console.Write(@$"

Presione Cualquier Tecla Para Volver Al Menú Principal.");
            Console.ReadKey();
            Console.Clear();
        }

        public void EliminarLibro()
        {
            int opt, AutoIncrementalLibro = 0;
            Console.WriteLine($@"# | ISBN                   | Titulo                         | Año Publicacion   | Autor               | Genero                        | Precio
------------------------------------------------------------------------------------------------------------------------------------------------------------");
            foreach (var libro in Libros)
            {
                AutoIncrementalLibro++;
                Console.WriteLine($@"{AutoIncrementalLibro} | {libro.Isbn,-23}| {libro.Titulo,-31}| {libro.AnoPublicacion,-18}| {libro.Autor,-20}| {libro.Genero,-30}| {libro.Precio}");
            }
            Console.Write(@"

Desea eliminar libro por.
1. Numero de libro
2. Codigo ISBN

Seleccione una opcion: ");
            opt = Convert.ToInt16(Console.ReadLine());
            if (opt == 1)
            {
                int NroLibro, OpcionEliminar;
                Console.Write("\nPor favor Ingrese el numero del libro que desea eliminar: ");
                NroLibro = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($@" 
Estas Segur@ que deseas eliminar el siguiente libro?

ISBN                   | Titulo                         | Año Publicacion   | Autor               | Genero                        
----------------------------------------------------------------------------------------------------------------------------------------------");
                Console.Write($@"{Libros[NroLibro - 1].Isbn,-23}| {Libros[NroLibro - 1].Titulo,-31}| {Libros[NroLibro - 1].AnoPublicacion,-18}| {Libros[NroLibro - 1].Autor,-20}| {Libros[NroLibro - 1].Genero,-30}

1. Si
2. No

Seleccione una opcion: ");
                OpcionEliminar = Convert.ToInt16(Console.ReadLine());
                if (OpcionEliminar == 1)
                {
                    Libros.RemoveAt(NroLibro - 1);
                    Console.Write("\nLibro Eliminado Exitosamente!");
                    Console.Write(@$"

Presione Cualquier Tecla Para Volver Al Menú Principal.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.Write("\nLibro No Ha Sido Eliminado!");
                    Console.Write(@$"

Presione Cualquier Tecla Para Volver Al Menú Principal.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else if (opt == 2)
            {
                string CodigoEliminar;
                int IndexEliminar = -1, OpcionEliminar, LibroEncontrado = 0;
                Console.Write("Ingrese el codigo ISBN del libro que desea eliminar: ");
                CodigoEliminar = Console.ReadLine();
                foreach (var item in Libros)
                {
                    if (item.Isbn == CodigoEliminar)
                    {
                        IndexEliminar = Libros.IndexOf(item);
                        LibroEncontrado = 1;
                        break;
                    }
                }
                if (LibroEncontrado == 1)
                {
                    Console.WriteLine($@" 
Estas Segur@ que deseas eliminar el siguiente libro?

ISBN                   | Titulo                         | Año Publicacion   | Autor               | Genero                        
----------------------------------------------------------------------------------------------------------------------------------------------");
                    Console.Write($@"{Libros[IndexEliminar].Isbn,-23}| {Libros[IndexEliminar].Titulo,-31}| {Libros[IndexEliminar].AnoPublicacion,-18}| {Libros[IndexEliminar].Autor,-20}| {Libros[IndexEliminar].Genero,-30}

1. Si
2. No

Seleccione una opcion: ");
                    OpcionEliminar = Convert.ToInt16(Console.ReadLine());
                    if (OpcionEliminar == 1)
                    {
                        Libros.RemoveAt(IndexEliminar);
                        Console.Write("\nLibro Eliminado Exitosamente!");
                        Console.Write(@$"

Presione Cualquier Tecla Para Volver Al Menú Principal.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.Write("\nLibro No Ha Sido Eliminado!");
                        Console.Write(@$"

Presione Cualquier Tecla Para Volver Al Menú Principal.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else
                {
                    Console.WriteLine("\nLibro no encontrado por favor intente de nuevo!!!!!");
                    Console.Write(@$"

Presione Cualquier Tecla Para Volver Al Menú Principal.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        public void MostrarLibros()
        {
            Console.WriteLine($@" ISBN                   | Titulo                         | Año Publicacion   | Autor               | Genero                        | Precio
------------------------------------------------------------------------------------------------------------------------------------------------------------");
            foreach (var libro in Libros)
            {
                Console.WriteLine($@" {libro.Isbn,-23}| {libro.Titulo,-31}| {libro.AnoPublicacion,-18}| {libro.Autor,-20}| {libro.Genero,-30}| {libro.Precio}");
            }
            Console.Write(@$"

Presione Cualquier Tecla Para Volver Al Menú Principal.");
            Console.ReadKey();
            Console.Clear();
        }

        public void BuscarLibro()
        {
            int opt;
            bool validInput = false;
            do
            {
                try
                {
                                    Console.Write($@"Buscar libro por.
1. Nombre
2. ISBN
3. Genero
4. Autor
5. Rango de años

Seleccione una opcion: ");
                opt = Convert.ToInt16(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        BuscarxTitulo();
                        validInput = true;
                        break;
                    case 2:
                        BuscarxISBN();
                        validInput = true;
                        break;
                    case 3:
                        BuscarxGenero();
                        validInput = true;
                        break;
                    case 4:
                        BuscarxAutor();
                        validInput = true;
                        break;
                    case 5:
                        BuscarxRangoAño();
                        validInput = true;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida!");
                        break;
                }
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("NUMERO INVALIDO POR FAVOR INTENTE DE NUEVO!!\n");
                }

            } while (!validInput);

        }

        public void OrdenarLibrosPorAño()
        {
            var OrdenarPorAño = Libros.OrderBy(l => l.AnoPublicacion);
            Console.WriteLine($@" ISBN                   | Titulo                         | Año Publicacion   | Autor               | Genero                        | Precio
------------------------------------------------------------------------------------------------------------------------------------------------------------");
            foreach (var libro in OrdenarPorAño)
            {
                Console.WriteLine($@" {libro.Isbn,-23}| {libro.Titulo,-31}| {libro.AnoPublicacion,-18}| {libro.Autor,-20}| {libro.Genero,-30}| {libro.Precio}");
            }
            Console.Write(@$"

Presione Cualquier Tecla Para Volver Al Menú Principal.");
            Console.ReadKey();
            Console.Clear();
        }

        public void MostrarLibrosRecientes()
        {
            var MostrarLibrosRecientes = Libros.Where(l => (DateTime.Now.Year - l.AnoPublicacion) <= 5).ToList();
            if (MostrarLibrosRecientes.Count != 0)
            {
                Console.WriteLine($@"Libros Publicados en los ultimos 5 años

ISBN                   | Titulo                         | Año Publicacion   | Autor               | Genero                        | Precio
------------------------------------------------------------------------------------------------------------------------------------------------------------");
                foreach (var libro in MostrarLibrosRecientes)
                {
                    Console.WriteLine($@" {libro.Isbn,-23}| {libro.Titulo,-31}| {libro.AnoPublicacion,-18}| {libro.Autor,-20}| {libro.Genero,-30}| {libro.Precio}");
                }
                Console.Write(@$"

Presione Cualquier Tecla Para Volver Al Menú Principal.");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("No se encontraron libros publicados en los ultimos 5 años");
                Console.Write(@$"

Presione Cualquier Tecla Para Volver Al Menú Principal.");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void Descuento()
        {
            string DescuentoXIsbn;
            double Descuento;

            Console.Write("Ingrese el codigo ISBN del libro al que quiere aplicar el descuento: ");
            DescuentoXIsbn = Console.ReadLine();
            foreach (var libro in Libros)
            {
                if (DescuentoXIsbn.Equals(libro.Isbn, StringComparison.InvariantCultureIgnoreCase))
                {
                    double descuento;
                    Console.WriteLine($@"
Se le aplicara descuento al libro:

ISBN                   | Titulo                         | Año Publicacion   | Autor               | Genero                   | Precio                        
----------------------------------------------------------------------------------------------------------------------------------------------");
                    Console.Write($@"{libro.Isbn,-23}| {libro.Titulo,-31}| {libro.AnoPublicacion,-18}| {libro.Autor,-20}| {libro.Genero,-25}| {libro.Precio}
");
                    Console.Write("\nIngrese la cantidad que quiere descontar al precio del libro: ");
                    Descuento = Convert.ToDouble(Console.ReadLine());
                    libro.Precio -= Descuento;
                    Console.WriteLine($@"
Se aplico el descuento exitosamente!

Este es el nuevo precio del libro:

ISBN                   | Titulo                         | Año Publicacion   | Autor               | Genero                   | Precio                       
----------------------------------------------------------------------------------------------------------------------------------------------");
                    Console.Write($@"{libro.Isbn,-23}| {libro.Titulo,-31}| {libro.AnoPublicacion,-18}| {libro.Autor,-20}| {libro.Genero,-25}| {libro.Precio}
");
                    Console.Write(@$"

Presione Cualquier Tecla Para Volver Al Menú Principal.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        public void BuscarxTitulo()
        {
            string BuscarTitulo;
            int indexLibro = -1, LibroEncontrado = 0;

            Console.Write("\nIngresa el Titulo del libro que deseas buscar: ");
            BuscarTitulo = Console.ReadLine().Trim();
            foreach (var item in Libros)
            {
                if (item.Titulo.Equals(BuscarTitulo, StringComparison.OrdinalIgnoreCase))
                {
                    indexLibro = Libros.IndexOf(item);
                    LibroEncontrado = 1;
                    break;
                }
            }
            if (LibroEncontrado == 1)
            {
                Console.WriteLine($@"
Libro Encontrado

ISBN                   | Titulo                         | Año Publicacion   | Autor               | Genero                        
----------------------------------------------------------------------------------------------------------------------------------------------");
                Console.Write($@"{Libros[indexLibro].Isbn,-23}| {Libros[indexLibro].Titulo,-31}| {Libros[indexLibro].AnoPublicacion,-18}| {Libros[indexLibro].Autor,-20}| {Libros[indexLibro].Genero,-30}
");
                Console.Write(@$"

Presione Cualquier Tecla Para Volver Al Menú Principal.");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\nLibro No Encontrado, por favor intente de nuevo!!!!!");
                Console.Write(@$"

Presione Cualquier Tecla Para Volver Al Menú Principal.");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void BuscarxISBN()
        {
            string BuscarIsbn;
            int indexLibro = -1, LibroEncontrado = 0;
            Console.Write("\nIngresa el ISBN del libro que deseas buscar: ");
            BuscarIsbn = Console.ReadLine().Trim();
            foreach (var item in Libros)
            {
                if (item.Isbn.Equals(BuscarIsbn, StringComparison.OrdinalIgnoreCase))
                {
                    indexLibro = Libros.IndexOf(item);
                    LibroEncontrado = 1;
                    break;
                }
            }
            if (LibroEncontrado == 1)
            {
                Console.WriteLine($@"
Libro Encontrado

ISBN                   | Titulo                         | Año Publicacion   | Autor               | Genero                        
----------------------------------------------------------------------------------------------------------------------------------------------");
                Console.Write($@"{Libros[indexLibro].Isbn,-23}| {Libros[indexLibro].Titulo,-31}| {Libros[indexLibro].AnoPublicacion,-18}| {Libros[indexLibro].Autor,-20}| {Libros[indexLibro].Genero,-30}
");
                Console.Write(@$"

Presione Cualquier Tecla Para Volver Al Menú Principal.");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\nLibro No Encontrado, por favor intente de nuevo!!!!!");
                Console.Write(@$"

Presione Cualquier Tecla Para Volver Al Menú Principal.");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void BuscarxGenero()
        {
            string BuscarGenero;
            Console.Write("\nIngrese el genero del que quiere buscar libros: ");
            BuscarGenero = Console.ReadLine().Trim();
            var FiltradoGenero = Libros.Where(l => l.Genero.Equals(BuscarGenero, StringComparison.OrdinalIgnoreCase)).ToList();
            if (FiltradoGenero.Count != 0)
            {
                Console.WriteLine($@"
Libros Encontrado

ISBN                   | Titulo                         | Año Publicacion   | Autor               | Genero                        
----------------------------------------------------------------------------------------------------------------------------------------------");
                foreach (var libro in FiltradoGenero)
                {
                    Console.Write($@"{libro.Isbn,-23}| {libro.Titulo,-31}| {libro.AnoPublicacion,-18}| {libro.Autor,-20}| {libro.Genero,-30}
");
                }

                Console.Write(@$"

Presione Cualquier Tecla Para Volver Al Menú Principal.");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\nNo se encontraron libros, por favor intente de nuevo!!!!!");
                Console.Write(@$"

Presione Cualquier Tecla Para Volver Al Menú Principal.");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void BuscarxAutor()
        {
            string BuscarAutor;
            Console.Write("\nIngrese el autor del que quiere buscar libros: ");
            BuscarAutor = Console.ReadLine().Trim();
            var FiltradoAutor = Libros.Where(l => l.Autor.Equals(BuscarAutor, StringComparison.OrdinalIgnoreCase)).ToList();
            if (FiltradoAutor.Count != 0)
            {
                Console.WriteLine($@"
Libros Encontrado

ISBN                   | Titulo                         | Año Publicacion   | Autor               | Genero                        
----------------------------------------------------------------------------------------------------------------------------------------------");
                foreach (var libro in FiltradoAutor)
                {
                    Console.Write($@"{libro.Isbn,-23}| {libro.Titulo,-31}| {libro.AnoPublicacion,-18}| {libro.Autor,-20}| {libro.Genero,-30}
");
                }

                Console.Write(@$"

Presione Cualquier Tecla Para Volver Al Menú Principal.");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\nNo se encontraron libros, por favor intente de nuevo!!!!!");
                Console.Write(@$"

Presione Cualquier Tecla Para Volver Al Menú Principal.");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void BuscarxRangoAño()
        {
            int RangoDesde, RangoHasta;
            Console.Write("\nIngrese el año desde el que quiere mostrar libros: ");
            RangoDesde = Convert.ToInt16(Console.ReadLine().Trim());
            Console.Write("Ingrese el año hasta el que quiere mostrar libros: ");
            RangoHasta = Convert.ToInt16(Console.ReadLine().Trim());
            var Filtradoaños = Libros.Where(l => l.AnoPublicacion >= RangoDesde && l.AnoPublicacion <= RangoHasta).OrderBy(l => l.AnoPublicacion).ToList();
            if (Filtradoaños.Count != 0)
            {
                Console.WriteLine($@"
Libros Encontrado

ISBN                   | Titulo                         | Año Publicacion   | Autor               | Genero                        
----------------------------------------------------------------------------------------------------------------------------------------------");
                foreach (var libro in Filtradoaños)
                {
                    Console.Write($@"{libro.Isbn,-23}| {libro.Titulo,-31}| {libro.AnoPublicacion,-18}| {libro.Autor,-20}| {libro.Genero,-30}
");
                }

                Console.Write(@$"

Presione Cualquier Tecla Para Volver Al Menú Principal.");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\nNo se encontraron libros, por favor intente de nuevo!!!!!");
                Console.Write(@$"

Presione Cualquier Tecla Para Volver Al Menú Principal.");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}