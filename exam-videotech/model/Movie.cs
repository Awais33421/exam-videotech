using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace exam_videotech.model
{
    public class Movie
    {
        private string titulo;
        private string director;
        private int anyo;
        private bool disponible;

        public Movie(string titulo, string director,int anyo,bool disponible)
        {
            this.titulo = titulo;
            this.director = director;
            this.anyo = anyo;
            this.disponible = disponible;

        }
        public string GetTitulo()
        { return titulo; }

        public string GetDirector()
        { return titulo; }

        public int GetAnyo()
        { return anyo; }

        public bool IsDisponible()
        { return disponible; }

        public string ToString()
        {
            return titulo + "-" + director +"(" + anyo +")";
        }

    }
}
