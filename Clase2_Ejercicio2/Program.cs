using Clase2_Ejercicio2;

decimal checkDecimalInput()
{
    try
    {
        return Convert.ToDecimal(Console.ReadLine());
    }
    catch (Exception ex)
    {
        Console.WriteLine("Se ha ingresado el dato en un formato incorrecto. Se usará '0' por defecto.");
        return 0;
    }
}
Console.WriteLine("Ingrese los datos de la persona.");
Console.WriteLine("Nombre:");
string nombre = Console.ReadLine();

int edad;
try
{
    Console.WriteLine("Edad:");
    edad = Convert.ToInt32(Console.ReadLine());
}
catch (Exception ex)
{
    Console.WriteLine("Se ha ingresado el dato en un formato incorrecto. Se usará '0' por defecto.");
    edad = 0;
}

Console.WriteLine("Peso en kilogramos:");
decimal pesoKg = checkDecimalInput();
Console.WriteLine("Altura en metros:");
decimal alturaMtr = checkDecimalInput();

Persona persona = new Persona(nombre, edad, pesoKg, alturaMtr);

Console.WriteLine($"\nInforme de IMC: {persona.CalcularIMC()}");
Console.WriteLine($"La persona es mayor de edad: {(persona.EsMayorEdad() ? "Sí" : "No")}");
persona.Informar();
