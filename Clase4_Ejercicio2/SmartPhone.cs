namespace Clase4_Ejercicio2
{
    public class SmartPhone
    {
        private string marca;
        private string modelo;
        private SistemaOperativo sistemaOperativo;

        public SmartPhone(string unaMarca, string unModelo, SistemaOperativo unSistemaOperativo)
        {
            this.marca = unaMarca;
            this.modelo = unModelo;
            this.sistemaOperativo = unSistemaOperativo;
        }

        public string Marca() { return marca; }

        public void ActualizarSistemaOperativo()
        {
            this.UpdateOS();
        }

        private void UpdateOS()
        {
            this.sistemaOperativo.Version += 1;
            Console.WriteLine($"Se ha actualizado el sistema operativo {this.sistemaOperativo.Nombre()} del celular {this.Marca()} a la versión {this.sistemaOperativo.Version}");
        }


    }
}
