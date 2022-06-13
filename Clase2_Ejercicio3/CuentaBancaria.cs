namespace Clase2_Ejercicio3
{
    public class CuentaBancaria
    {
        private int NroCuenta { get; set; }
        private int NroCliente { get; set; }
        private string MonedaCuenta { get; set; }
        private decimal Saldo { get; set; }

        public CuentaBancaria(int unNroCuenta, int unNroCliente, string unaMonedaCuenta, decimal unSaldo)
        {
            this.NroCuenta = unNroCuenta;
            this.NroCliente = unNroCliente;
            this.MonedaCuenta = unaMonedaCuenta;
            this.Saldo = unSaldo;
        }

        public void OperacionBancaria(string operacion, decimal monto = 0)
        {
            switch (operacion)
            {
                case "informar":
                    this.Informar();
                    break;
                case "depositar":
                    this.Saldo += monto;
                    break;
                case "retirar":
                    if (this.Saldo < monto) Console.WriteLine("La cuenta no posee fondos suficientes para realizar la operación.");
                    else this.Saldo -= monto;
                    break;
            }
            if (operacion != "informar") Console.WriteLine($"Su saldo actual es: {this.Saldo}");
        }

        public void Informar()
        {
            Console.WriteLine("\nLa cuenta bancaria tiene los siguientes datos:\n" +
                $"\tNúmero de cuenta: {this.NroCuenta}\n" +
                $"\tNúmero de Cliente {this.NroCliente}\n" +
                $"\tMoneda: {this.MonedaCuenta}\n" +
                $"\tSaldo Actual: {this.Saldo}");
        }
    }
}
