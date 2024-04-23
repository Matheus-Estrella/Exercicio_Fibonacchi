// 1-) Faça um programa que leia um número inteiro e imprima até esta posição da sequência Fibonacchi (começando no 1); 

int anterior = 0, proximo = 1, i = 0, aux = 0;

Console.WriteLine("Digite um número para saber quais são os de posição correspondente da sequência de Fibonacchi: ");
i = int.Parse(Console.ReadLine());
Console.Write("Resultado: ");
do
{
    Console.Write($"{proximo} ");
    aux = proximo;
    proximo += anterior;
    anterior = aux;
    i--;
}while(i != 0);
