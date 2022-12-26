#region Ejercicio 1
/*
List<int> resultados = new List<int>(){6,5,8,4,8,6,8,6,7,8};
int suma = 0;
resultados.ForEach(nota => {
    suma += nota;
    Console.WriteLine("Nota: "+nota);
});
Console.WriteLine("El promodio es =" + (suma / 10));
*/

#endregion

#region Ejercicio 2
/*
List<int> edades = new List<int>() { 10, 12, 55, 15, 16, 32, 18, 25, 28, 26, 30, 31, 19, 34, 32, 35, 38, 40, 15, 10 };
int mayor=0;
edades.ForEach(edad => {
    if (edad > 18)
    {
        mayor++;
    }
});
Console.WriteLine($"El listado tiene {mayor} mayores y tiene {20-mayor} menores");
*/
#endregion

#region Ejercicio 3
/*
List<string> Nombres = new List<string>(){"Jorge","Martina","Lujan","Josemaria","Juan","alberto","Rosio","Omar"};
string PalabraCorta = "";
string PalabraLarga = "";
Nombres.ForEach(nombre => {
    if (PalabraCorta.Length > nombre.Length||PalabraCorta=="")
    {
        PalabraCorta = nombre;
    }
    else
    {
        if(PalabraLarga.Length<nombre.Length)
        {
            PalabraLarga = nombre;
            
        }
    }
});
Console.WriteLine($"La palabra mas corta es {PalabraCorta}");
Console.WriteLine($"La palabra mas larga es {PalabraLarga}");
*/
#endregion

#region Ejercicio 4
List<string>Productos = new List<string>();
string prod;
do
{
    Console.WriteLine("Ingrese el nombre del producto");
    prod = Console.ReadLine();
    int indice = Productos.IndexOf(prod);
    if (indice >0)
    {
        Productos.RemoveAt(indice);
        Console.WriteLine("El elemento estaba en la lista y se quito");
    }
    else
    {
        Productos.Add(prod);
        Console.WriteLine($"El producto {prod} se agrego a la lista");
    }

} while (prod != "fin");
#endregion

#region Ejercicio 5

#endregion

#region Ejercicio 5

#endregion

#region Ejercicio 6

#endregion