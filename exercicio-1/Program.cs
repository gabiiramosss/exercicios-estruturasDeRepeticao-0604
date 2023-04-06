//Faça um programa que peça uma nota, entre 0 e 10. Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.

//Do While

float nota;

do
{
    Console.WriteLine($"Insira sua nota: ");
    nota = float.Parse(Console.ReadLine());

    if (nota > 10 || nota < 0)
    {
        Console.WriteLine($"Número inválido, insira novamente.");
    }
} while (nota > 10 || nota < 0);
