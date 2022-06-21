namespace Clase4_Ejercicio2
{
    public class SistemaOperativo
    {
        private string nombre;
        public int Version { get; set; }

        public SistemaOperativo(string unNombre, int unaVersion = 1)
        {
            this.nombre = unNombre;
            this.Version = unaVersion;
        }

        public string Nombre() { return nombre; }
    }
}
