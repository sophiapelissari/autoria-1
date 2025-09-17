double dist;
Console.WriteLine("Digite a distância percorrida em quilômetros:");
dist = double.Parse(Console.ReadLine());// Verifica se a distância é diferente de 60
if (dist != 60)
{
    Console.WriteLine("Distância fora do padrão esperado. :(");
}
else
{
    Console.WriteLine("Distância dentro do padrão esperado. :)");
}