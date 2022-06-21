using System.Globalization;

namespace Clase4_Ejercicio1
{
    public class TemaMusical
    {
        public string Nombre { get; set; }
        public int DuracionSegundos { get; set; }

        public TemaMusical(string unNombre, int ununaDuracionSegundos)
        {
            this.Nombre = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(unNombre.Trim());
            this.DuracionSegundos = ununaDuracionSegundos;
        }

        public TemaMusical(string unNombre, string unaDuracionSegundos)
        {
            this.Nombre = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(unNombre.Trim());

            int num;
            bool parsed = int.TryParse(unaDuracionSegundos.Trim(), out num);
            if (parsed)
                this.DuracionSegundos = int.Parse(unaDuracionSegundos.Trim());
            else
            {
                this.DuracionSegundos = 0;
                Console.WriteLine($"La duración en segundos se ingresó en un formato incorrecto. Se usará cero por defecto.");
            }
        }
    }
}
