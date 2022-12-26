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
/*
List<string> Productos = new List<string>() { "carne","arroz","azucar"};
List<string> Comprados = new List<string>();
List<string> CompradosFuera = new List<string>();
string prod;
do
{
    Console.WriteLine("Ingrese el nombre del producto");
    prod = Console.ReadLine();
    int indice = Productos.IndexOf(prod);
    if(prod == "fin")
    {
        break;
    }
    if (indice != -1)
    {
        Productos.RemoveAt(indice);
        Comprados.Add(prod);
        Console.WriteLine("El elemento estaba en la lista y se quito");
    }
    else
    {
        //Productos.Add(prod);
        CompradosFuera.Add(prod);
        Console.WriteLine($"El producto {prod} no estaba y se agrego a la lista");
    }

} while (prod != "fin");
Console.WriteLine("Productos no comprados");
Productos.ForEach(producto => {
    Console.WriteLine("*-*" +producto);
});
Console.WriteLine("Productos comprados");
Comprados.ForEach(producto => {
    Console.WriteLine("*-*" + producto);
});

Console.WriteLine("Productos comprados que no estaban en la lista");
CompradosFuera.ForEach(producto => {
    Console.WriteLine("*-*" + producto);
});

*/
#endregion

#region Ejercicio 5
/*
string[,] matriz = new string[5,5];

for(int i = 0; i < 5; i++)
{
    for(int j = 0; j < 5; j++)
    {
        if((i+j) % 2 == 0)
        {
            matriz[i,j] = "P";
        }
        else
        {
            matriz[i,j] = "I";
        }
    }
}
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(matriz[i, j]);
        
    }
    Console.WriteLine("");
}
*/
#endregion

#region Ejercicio 6
/*
var randomNumber = new Random();
string[] dias = new string[] {"Domingo", "Lunes","Martes", "Miércoles","Jueves","Viernes", "Sábado" };
int[,] temperatura = new int[5, 7];
int con = 0;

int TemMaxMes = 0;
string DiaTemMes = "";
for (int i = 0; i < 5; i++)
{
    for(int j = 0; j < 7; j++)
    {
        if(i+j>0 && con<32)
            temperatura[i, j] = randomNumber.Next(7, 39);

        con++;
    }
}
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 7; j++)
    {
          Console.Write(temperatura[i, j] + "|");
    }
    Console.WriteLine("");
}

for (int i = 0; i < 5; i++)
{
    int TemSemMax = 0;
    int TemSemMin = 38;
    string DiaTemMax = "";
    string DiaTemMin = "";
    int TemPromedio = 0;

    for (int j = 0; j < 7; j++)
    {
        if (TemSemMax < temperatura[i,j])
        {
            TemSemMax = temperatura[i, j];
            DiaTemMax = dias[j];
           
        }
        else
        {
           if (TemSemMin > temperatura[i, j] && temperatura[i,j]!=0)
            {
                TemSemMin = temperatura[i, j];
                DiaTemMin = dias[j];
            }
        }
        TemPromedio += temperatura[i, j]; 

    }
        Console.WriteLine($"Mínima semana {i+1} fue el día {DiaTemMin} de: {TemSemMin}º");
        Console.WriteLine($"Máxima semana {i+1} fue el día {DiaTemMax} de: {TemSemMax}º");
        Console.WriteLine($"El promedio de la semana {i+1} es: {TemPromedio/7}"); 
    if (TemMaxMes < TemSemMax)
    {
        TemMaxMes = TemSemMax;
        DiaTemMes = DiaTemMax;
    }
}
Console.WriteLine($"La Temperatura máxima del mes fue el dia {DiaTemMes} de {TemMaxMes}º");
*/
#endregion

#region Ejercicio 7

int[,] tabla = new int[10, 10];
for(int i =0; i < 10; i++)
{
    for(int j = 0; j < 10; j++)
    {
        if(i==0 ||j == 0)
        {
            tabla[i, j] = i+j;
        }
        else
        {
            tabla[i, j] = i*j;

        }
    }
}
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        Console.Write(tabla[i, j]+"|");
    }
    Console.WriteLine("");
}
#endregion