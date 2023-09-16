Random dado = new Random();

int tirada1 = dado.Next(1, 7);
int tirada2 = dado.Next(1, 7);
int tirada3 = dado.Next(1, 7);

int total = tirada1 + tirada2 + tirada3;

Console.Clear();

Console.Write("\n\n\n\n\n\n");
Console.Write($"\t\t\tTirada de dados: {tirada1} + {tirada2} + {tirada3} ");
Console.WriteLine($"= {total}");

if ((tirada1 == tirada2) && (tirada2 == tirada3)) 
{
    Console.Write("\n\n\t\t");
    Console.WriteLine("¡Conseguiste TRIPLES! ¡Sumás 6 puntos bonus!");
    total += 6;
}
if ((tirada1 == tirada2) || (tirada2 == tirada3) || (tirada1 == tirada3))
{
    Console.Write("\n\n\t\t");
    Console.WriteLine("¡Conseguiste DOBLES! ¡Sumás 2 puntos bonus!");
    total += 2;
}
if (total >= 15)
{
    Console.WriteLine("\n\n\t\t¡Ganaste!");
}
if (total < 15)
{
    Console.WriteLine("\n\n\t\tLo siento, perdiste.");
}



Console.Write("\n\n\n\n\n\n");