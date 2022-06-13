using Clase2_Ejercicio3;

int checkIntegerInput()
{
    try
    {
        return Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception ex)
    {
        Console.WriteLine("Se ha ingresado el dato en un formato incorrecto. Se usará '0' por defecto.");
        return 0;
    }
}

Console.WriteLine("Usted está por crear una nueva cuenta bancaria. Ingrese los datos solicitados.");
Console.WriteLine("Número de Cuenta");
int nroCuenta = checkIntegerInput();
Console.WriteLine("Número de Cliente Titular");
int nroCliente = checkIntegerInput();
Console.WriteLine("Moneda de la cuenta");
string monedaCuenta = Console.ReadLine();

decimal saldoInicial;
try
{
    Console.WriteLine("Saldo Inicial:");
    saldoInicial = Convert.ToDecimal(Console.ReadLine());
}
catch (Exception ex)
{
    Console.WriteLine("Se ha ingresado el dato en un formato incorrecto. Se usará '0' por defecto.");
    saldoInicial = 0;
}

if (saldoInicial > 0)
{
    CuentaBancaria cuenta = new CuentaBancaria(nroCuenta, nroCliente, monedaCuenta, saldoInicial);

    string operacion = "";
    decimal monto = 0;
    string[] operacionesDisponibles = new string[] { "depositar", "retirar", "informar", "salir" };

    while (operacion != "salir") {
    
        Console.WriteLine("Escoja una operación: 'depositar', 'retirar', 'informar' o 'salir'");
        operacion = Console.ReadLine().ToLower();

        if (operacion == "salir") break;

        if (Array.IndexOf(operacionesDisponibles, operacion) >= 0)
        {
            if (operacion != "informar")
            {
                try
                {
                    Console.WriteLine($"Ingrese el monto a {operacion}:");
                    monto = Convert.ToDecimal(Console.ReadLine());
                } catch
                {
                    Console.WriteLine("No se reconoce el monto ingresado.");
                }
            }
            cuenta.OperacionBancaria(operacion, monto);
        }
        else Console.WriteLine("No se reconoce la operación ingresada.");
    };
    Console.WriteLine("Han finalizado las operaciones bancarias.");

} else Console.WriteLine("Saldo cuenta incorrecto.");