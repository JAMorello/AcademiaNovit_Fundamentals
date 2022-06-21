using System.Globalization;
using System.Net.Mail;

namespace Clase4_Ejercicio2
{
    public class Persona
    {
        public string Nombre { get; set; }

        private string? correoElectronico;

        public string CorreoElectronico
        {
            get { return correoElectronico; }
            set 
            {
                try
                {
                    var tryParseMail = new MailAddress(value);
                    correoElectronico = value;
                }
                catch
                {
                    Console.WriteLine("El correo electrónico es inválido.");
                }
            }
        }

        private SmartPhone? SmartPhone { get; set; }

        public Persona(string unNombre, string unCorreoElectronico)
        {
            this.Nombre = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(unNombre);
            this.CorreoElectronico = unCorreoElectronico;
        }

        public void ObtenerSmartPhone(SmartPhone celular)
        {
            this.SmartPhone = celular;
        }

        public void ActualizarSistemaOperativoDeSmartPhone()
        {
            if (this.SmartPhone == null)
            {
                Console.WriteLine($"{this.Nombre} no tiene smartphone.");
            }
            else
            {
                this.SmartPhone.ActualizarSistemaOperativo();
            }
        }
    }
}
