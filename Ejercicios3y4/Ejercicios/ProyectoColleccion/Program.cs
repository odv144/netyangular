

































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
var randomNumber = new Random();
int[,] temperatura = new int[5, 7];
int con = 0;
for(int i = 0; i < 5; i++)
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
        Console.Write(temperatura[i, j]+"|"); 
    }
    Console.WriteLine("");
}
#endregion