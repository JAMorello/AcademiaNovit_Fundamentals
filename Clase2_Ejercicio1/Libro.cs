using System.Globalization;

namespace Clase2_Ejercicio1
{
    public class Libro
    {
        private string Titulo { get; set; }

        private string Autor { get; set; }

        private int TotalPaginas { get; set; }

        private bool Estado { get; set; }

        public Libro(string unTitulo, string unAutor, int unTotalPaginas)
        {
            this.Titulo = unTitulo;
            this.Autor = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(unAutor);
            this.TotalPaginas = unTotalPaginas;
            this.Estado = false;
        }

        public void Informar()
        {
            Console.WriteLine($"\nEl libro \"{this.Titulo}\" escrito por {this.Autor} tiene {this.TotalPaginas} páginas y su estado es {(this.Estado ? "abierto" : "cerrado")}");
        }

        public void AbrirLibro()
        {
            if (!this.Estado) this.Estado = true;
            else Console.WriteLine("El libro ya ha sido abierto.");
        }
        public void CerrarLibro()
        {
            if (this.Estado) this.Estado = false;
            else Console.WriteLine("El libro ya ha sido cerrado.");
        }

    }
}
