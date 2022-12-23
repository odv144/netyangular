using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases.Clases
{
    public class Libro
    {
        private string Nombre;
        private string Autor;
        private int CanPagina;
        //private Boolean leido;
        public Boolean WasRead { get; set; }

        public Libro(string nombre, string autor, int canPag, Boolean leido)
        {
            this.Nombre= nombre;
            this.Autor= autor;
            this.CanPagina= canPag;
            WasRead = leido;
        }

        public string getNombre()
        {
            return this.Nombre;
        }
        public int getCanPagina()
        {
            return CanPagina;
        }

       
    }
}
