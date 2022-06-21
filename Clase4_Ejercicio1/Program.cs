using Clase4_Ejercicio1;

Console.WriteLine("SE CREAN LOS DISCOS:");

// SE CREA EL PRIMER DISCO
Artista artista1 = new Artista("Epica", "Países Bajos");
TemaMusical tema1 = new TemaMusical("Cry For The Moon", 406);
TemaMusical tema2 = new TemaMusical("Sensorium", 289);
List<TemaMusical> listaTemas1 = new List<TemaMusical>() { tema1, tema2 };
DiscoCompacto disco1 = new DiscoCompacto("The Phantom Agony (Expanded Edition)", artista1, listaTemas1, 2003, "Metal Sinfónico", "Transmission");

// SE CREA EL SEGUNDO DISCO
Artista artista2 = new Artista("    el cuarteto de nos", "uruguay");
TemaMusical tema3 = new TemaMusical("me agarré el pitito con el cierre   ", "204  ");
TemaMusical tema4 = new TemaMusical("hay que comer", "   382");
List<TemaMusical> listaTemas2 = new List<TemaMusical>() { tema3, tema4 };
DiscoCompacto disco2 = new DiscoCompacto("grandes éxitos", artista2, listaTemas2);
TemaMusical tema5 = new TemaMusical("tema para agregar y borrar", "0");
Console.WriteLine("\nOPERACIONES CON EL SEGUNDO DISCO:");
disco2.AgregarTemaMusical(tema5);
disco2.QuitarTemaMusical("tema para agregar y borrar");

// SE CREA LA COLECCIÓN
Console.WriteLine("\nSE CREA LA COLECCIÓN:");
Coleccion coleccion = new Coleccion();
coleccion.AgregarDiscoCompacto(disco1);
coleccion.AgregarDiscoCompacto(disco2);

Console.WriteLine("\nOPERACIONES CON LA COLLECIÓN:");
coleccion.CantidadDiscosCompactos();
coleccion.BuscarDiscoCompacto("grandes éxitos");
coleccion.QuitarDiscoCompacto("grandes éxitos");
coleccion.CantidadDiscosCompactos();