using Clase4_Ejercicio2;

SmartPhone celularRegalo = new SmartPhone("Samsung", "s10", new SistemaOperativo("Android", 10));
Persona pedro = new Persona("Pedro", "pedro@mail.com");
pedro.ObtenerSmartPhone(celularRegalo);
pedro.ActualizarSistemaOperativoDeSmartPhone();