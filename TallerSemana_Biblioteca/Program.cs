using TallerSemana_Biblioteca.Models;

namespace TallerSemana_Biblioteca;

class Program
{
    static void Main(string[] args)
    {
        Program.Menu();
    }

    public static void Menu()
    {
        int option;
        Biblioteca oBiblioteca = new Biblioteca();
        bool validInput = false;
        do
        {
            try
            {
                Console.Write(@"
###############################################################################################
#                                        MENU                                                 #    
###############################################################################################

1. Agregar Libro.
2. Mostrar Libros.
3. Eliminar libro.
4. Buscar libro.
5. Aplicar descuento a libro.
0. Salir.

Selecciona una opcion: ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        oBiblioteca.AgregarLibro();
                        break;
                    case 2:
                        Console.Clear();
                        oBiblioteca.MostrarLibros();
                        break;
                    case 3:
                        Console.Clear();
                        oBiblioteca.EliminarLibro();
                        break;
                    case 4:
                        Console.Clear();
                        oBiblioteca.BuscarLibro();
                        break;
                    case 5:
                        Console.Clear();
                        oBiblioteca.Descuento();
                        break;
                    case 0:
                        Console.WriteLine("Aplicacion finalizada con exito!");
                        validInput = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida, por favor intente de nuevo");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.Write("DATO INVALIDO POR FAVOR INTENTE DE NUEVO !!!!!!!.\n");
            }
        } while (!validInput);
    }
}
