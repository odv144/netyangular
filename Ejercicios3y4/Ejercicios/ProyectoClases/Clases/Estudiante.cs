using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases.Clases
{
    public class Estudiante: Persona
    {
        List<Libro> ListaLibro = new List<Libro>();

        public void AgregarLibro(string nombre, string autor, int canPag, Boolean leido)
        {
            Libro nuevo = new Libro(nombre, autor, canPag, leido);
            ListaLibro.Add(nuevo);
            Console.WriteLine("Se agrego correctamente el libro");
        }

        public void QuitarLibro(int posicion)
        {
            ListaLibro.RemoveAt(posicion);
            
            Console.WriteLine("Se elimino correctamente el libro:");
        }

        public void LibrosLeidos()
        {
            ListaLibro.ForEach(libro =>
            {
                if (libro.WasRead)
                {
                    Console.WriteLine("Libro: "+libro.getNombre());
                }
            });
        }
        public int SumaLeido()
        {
            int suma = 0;
            ListaLibro.ForEach (Libro => {
                if (Libro.WasRead)
                {
                    suma += Libro.getCanPagina();
                }
            });
            return suma;
        }

        public int SinLeer()
        {
            int suma = 0;
            ListaLibro.ForEach(Libro => {
                if (!Libro.WasRead)
                {
                    suma++;
                }
            });
            return suma;
        }

    }
}
