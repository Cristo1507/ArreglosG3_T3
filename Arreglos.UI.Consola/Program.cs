using Arreglos.Logica;

Console.WriteLine("Arreglos");


//MiArreglo oMyArreglo = new(5);

//oMyArreglo.Agregar(3);
//oMyArreglo.Agregar(5);
//oMyArreglo.Agregar(7);

//oMyArreglo.Insertar(2, 0);

//Console.WriteLine(oMyArreglo);

//Console.WriteLine("---------------------------------------------");

//oMyArreglo.Eliminar(1);
//Console.WriteLine(oMyArreglo);

//try
//{
//    for(int i=0; i< oMyArreglo.N; i++)
//    {
//        oMyArreglo.Agregar(i*6);
//    }

//    Console.WriteLine(oMyArreglo);

//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);

//}

//________________________________________________

//Console.WriteLine(oMyArreglo);



MiArreglo oMyArreglo = new(100);

oMyArreglo.Llenar();

//oMyArreglo.ToString();
Console.WriteLine("\nArreglo desordenado ");
Console.WriteLine(oMyArreglo);

Console.WriteLine("\nArreglo ordenado ascendente");
oMyArreglo.Ordenar();
Console.WriteLine(oMyArreglo);
Console.WriteLine("\nArreglo ordenado descendente");
oMyArreglo.Ordenar(false);
Console.WriteLine(oMyArreglo);

Console.ReadKey();
