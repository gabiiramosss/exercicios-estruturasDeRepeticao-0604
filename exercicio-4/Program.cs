//Uma certa empresa fez uma pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinad produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:
//O número de pessoas que responderam SIM.
//O número de pessoas que responderam NÃO;
//O número de mulheres que responderam SIM;
//A porcentagem de homens que responderam NÃO entre todos os homens analisados.

//algoritmo:
//entrada do sexo da pessoa
//se ela gostou do prouto
//saber quantos disseram sim
//saber quantos disseram não
//saber quantas mulheres que disseram sim
//saber a quantidade total de mulheres
//saber a quantidade total de homens
//saber a porcentagem de homens que disseram não

char genero;
char avaliacaoPositiva;

int totalSim = 0;
int totalNao = 0;

int totalMulheresSim = 0;
int totalHomensNao = 0;

int totalMulheres = 0;
int totalHomens = 0;

double porcentagemHomensNao = 0;

//Estrutura do For
//var i = 1: inicializador
//i <= 10: condicional
//i++: iterador
for (var i = 1; i <= 10; i++)
{
    //Entrada de dados

    Console.WriteLine(@$"
    Digite o gênero da pessoa:
    (m) - Masculino
    (f) - Feminino
    ");
    
    genero = char.Parse(Console.ReadLine().ToLower);
    
    //Processamento

    if (genero == 'f')
    {
        totalMulheres++;
    }
    else
    {
        totalHomens++;
    }

}

//Processamento
porcentagemHomensNao = Math.Round(((double)totalHomensNao/(double)));

//Saída
Console.WriteLine($"Text");

