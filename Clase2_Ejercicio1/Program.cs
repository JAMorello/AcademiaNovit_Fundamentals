using Clase2_Ejercicio1;

Console.WriteLine("Ingrese los datos del libro.");
Console.WriteLine("Título:");
string titulo = Console.ReadLine();
Console.WriteLine("Autor:");
string autor = Console.ReadLine();

int totalPaginas;
try
{
    Console.WriteLine("Total de páginas:");
    totalPaginas = Convert.ToInt32(Console.ReadLine());
} catch (Exception ex)
{
    Console.WriteLine("Se ha ingresado el dato en un formato incorrecto. Se usará '0' por defecto.");
    totalPaginas = 0;
}

Libro libro = new Libro(titulo, autor, totalPaginas);

libro.AbrirLibro();
libro.Informar();
libro.CerrarLibro();
libro.Informar();
