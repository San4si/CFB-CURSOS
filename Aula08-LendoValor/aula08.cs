using System;
class Aula08{

    static void Main(){
        int v1, v2, soma;
        string nome;

        Console.Write("Digite o primeiro valor: ");
        v1=int.Parse(Console.ReadLine()); // Int.Parse converte o texto digitado em inteiro

        Console.Write("Digite o segundo valor: ");
        v2=Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 converte o texto digitado em inteiro e tem a mesma função de Int.Parse
        soma=v1+v2;
        Console.WriteLine("A soma de {0} mais {1} é igual a {2}",v1,v2,soma);

    }
}