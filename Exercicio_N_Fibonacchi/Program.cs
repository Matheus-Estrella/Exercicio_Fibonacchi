// 1-) Faça um programa que leia um número inteiro e imprima até esta posição da sequência Fibonacchi (começando no 1); 

int anterior = 0, proximo = 1, i = 0, aux = 0;

do
{
    Console.WriteLine("Digite um número para saber quais são os de posição correspondente da sequência de Fibonacchi: ");
    i = (int.Parse(Console.ReadLine())) - 1;
    if (i < 0)
    {
        Console.WriteLine("\nInisira um número positivo");
    }
} while (i <0 );
Console.Write("Resultado: ");
Console.Write($"{anterior} ");
do
{
    Console.Write($"{proximo} ");
    aux = proximo;
    proximo += anterior;
    anterior = aux;
    i--;
}while(i != 0);
