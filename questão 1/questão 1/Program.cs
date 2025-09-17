int n1;
int n2;
int soma;
Console.WriteLine("digite seu primeiro número: ");
n1 = int.Parse(Console.ReadLine());//lendo o primeiro número 
Console.WriteLine("digite seu segundo número: ");
n2 = int.Parse(Console.ReadLine());//lendo o segundo número 
soma = n1 = n2;//somando o primeiro e o segundo número
Console.WriteLine($"a soma dos seus dois números: {soma} ");
if (soma > 10 && soma < 50)//estipulando a regra
{
    Console.WriteLine("sua soma está entra 10 e 50 :)");
}
else
{
    Console.WriteLine("a sua soma não se enquadra nos requisitos :(");
}
