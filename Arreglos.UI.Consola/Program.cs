using Arreglos.Logica;

Console.WriteLine("Hello, World!");


MiArreglo oMyArreglo = new(10);

oMyArreglo.Llenar(1, 100);

//oMyArreglo.ToString();
Console.WriteLine("/nArreglo desordenado ");
Console.WriteLine(oMyArreglo);

Console.WriteLine("/nArreglo ordenado ascendente");
oMyArreglo.Ordenar();
Console.WriteLine(oMyArreglo);

Console.WriteLine("/nArreglo ordenado descendente");
oMyArreglo.Ordenar(false);
Console.WriteLine(oMyArreglo);

Console.ReadKey();
