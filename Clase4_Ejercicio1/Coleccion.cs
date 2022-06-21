namespace Clase4_Ejercicio1
{
    public class Coleccion
    {
        public List<DiscoCompacto> Discos { get; set; }

        public Coleccion()
        {
            this.Discos = new List<DiscoCompacto>();
            Console.WriteLine("Se ha creado una colección de discos vacía");
        }

        public Coleccion(List<DiscoCompacto> unaColeccionInicial)
        {
            this.Discos = unaColeccionInicial;
            Console.WriteLine($"Se ha creado una colección de discos con {this.Discos.Count} ítem/s");
        }

        public void AgregarDiscoCompacto(DiscoCompacto disco)
        {
            this.Discos.Add(disco);
            Console.WriteLine($"Se ha agregado a la colección el disco \"{disco.Nombre}\" del artista \"{disco.Artista.Nombre}\"");
        }

        public void QuitarDiscoCompacto(string nombreDisco)
        {
            var discoEliminado = this.Discos.Find(x => x.Nombre.ToLower() == nombreDisco.ToLower());
            if (discoEliminado != null)
            {
                this.Discos.Remove(discoEliminado);
                Console.WriteLine($"Se ha borrado exitosamente el disco \"{discoEliminado.Nombre}\" de la colección");
            } else Console.WriteLine("No se ha encontrado en la colección un disco con ese nombre");
        }

        public void CantidadDiscosCompactos()
        {
            Console.WriteLine($"La colección cuenta con {this.Discos.Count} disco/s compacto/s.");
        }

        public void BuscarDiscoCompacto(string nombreDisco)
        {
            var discoBuscado = this.Discos.Find(x => x.Nombre.ToLower() == nombreDisco.ToLower());
            if (discoBuscado != null) Console.WriteLine($"El disco \"{discoBuscado.Nombre}\" existe en la colección.");
            else Console.WriteLine($"El disco buscado no existe en la colección.");
        }
    }
}
