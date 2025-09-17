float temp;
Console.WriteLine("Digite a temperatura do dia em graus Celsius: ");
temp = float.Parse(Console.ReadLine());//lendo a temperatura dada 
if (temp < 20 || temp > 30)
{
    Console.WriteLine("Temperatura fora da faixa confortável! ;(");
}
else
{
    Console.WriteLine("Temperatura confortável ;)");
}
