using System.Globalization;

namespace Clase4_Ejercicio1
{
    public class Artista
    {
        public string Nombre { get; set; }
        public string Nacionalidad { get; set; }

        public Artista(string unNombre, string unaNacionalidad)
        {
            this.Nombre = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(unNombre.Trim());
            this.Nacionalidad = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(unaNacionalidad.Trim());
        }
    }
}
