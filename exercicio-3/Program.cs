//Faça um programa que receba um número inteiro e mostre a sua tabuada.

//For
Console.WriteLine($"Digite um número: ");
int numero = int.Parse(Console.ReadLine());

for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
{
    Console.WriteLine($"{numero} * {multiplicador} = {numero * multiplicador}");
}
 