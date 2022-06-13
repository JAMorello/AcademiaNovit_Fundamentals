using System.Globalization;

namespace Clase2_Ejercicio2
{
    public class Persona
    {
        private string Nombre { get; set; }
        private int Edad { get; set; }
        private decimal PesoKg { get; set; }
        private decimal AlturaMtr { get; set; }

        public Persona(string unNombre, int unaEdad, decimal unPesoKg, decimal unaAlturaMtr)
        {
            this.Nombre = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(unNombre);
            this.Edad = unaEdad;
            this.PesoKg = unPesoKg;
            this.AlturaMtr = unaAlturaMtr;
        }

        public string CalcularIMC()
        {
            try
            {
                decimal imc = this.PesoKg / (this.AlturaMtr * this.AlturaMtr);
                if (imc < (decimal)18.5) return "Bajo Peso";
                if (imc < 25) return "Peso Ideal";
                return "Sobrepeso";
            }
            catch
            {
                return "ERROR DE CÁLCULO";
            }
        }

        public bool EsMayorEdad()
        {
            return this.Edad >= 18;
        }

        public void Informar()
        {
            Console.WriteLine($"La persona se llama {this.Nombre}, tiene {this.Edad} años, pesa {this.PesoKg} kg. y mide {this.AlturaMtr} mts.");
        }
    }
}
