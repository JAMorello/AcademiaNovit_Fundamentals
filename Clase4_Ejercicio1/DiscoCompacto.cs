using System.Globalization;

namespace Clase4_Ejercicio1
{
    public class DiscoCompacto
    { 
        public string Nombre { get; set; } 
        public int AñoLanzamiento { get; set; }
        public string GeneroMusical { get; set; }
        public Artista Artista { get; set; }
        public List<TemaMusical> TemasMusicales { get; set; }
        public string SelloDiscografico { get; set; }

        public DiscoCompacto(string unNombre, Artista unArtista, 
                             List<TemaMusical> unaListaDeTemas, int unAñoLanzamiento = 0,
                             string unGeneroMusical = "unknown", string unSelloDiscografico = "unknown")
        {
            this.Nombre = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(unNombre.Trim());
            this.Artista = unArtista;
            this.TemasMusicales = unaListaDeTemas;
            this.AñoLanzamiento = unAñoLanzamiento;
            this.GeneroMusical = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(unGeneroMusical.Trim());
            this.SelloDiscografico = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(unSelloDiscografico.Trim());

            Console.WriteLine($"Se ha creado el disco \"{this.Nombre}\" del artista \"{this.Artista.Nombre}\"");
        }

        public void AgregarTemaMusical(TemaMusical tema)
        {
            this.TemasMusicales.Add(tema);
            Console.WriteLine($"Se ha agregado el tema \"{tema.Nombre}\" al disco \"{this.Nombre}\"");
        }

        public void QuitarTemaMusical(string nombreTema)
        {
            var temaEliminado = this.TemasMusicales.Find(x => x.Nombre.ToLower() == nombreTema.ToLower());
            if (temaEliminado != null)
            {
                this.TemasMusicales.Remove(temaEliminado);
                Console.WriteLine($"Se ha borrado el tema \"{temaEliminado.Nombre}\" del disco \"{this.Nombre}\"");
            }
            else Console.WriteLine("No se ha encontrado un tema con ese nombre");
        }

    }
}
