using System;

namespace Array_19._11
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Array");

           string[] nomes = new string[5];
           int[] idades = new int [5];

           for (var contador = 0; contador < 5; contador++)
           {
           Console.WriteLine($"Digite o {contador+1}° nome");
           nomes[contador] = Console.ReadLine();
           Console.WriteLine("Digite a idade");
           idades[contador] = int.Parse(Console.ReadLine());

           }

           Console.WriteLine("Nomes Cadastrados");

           for(var contador = 0; contador < 5; contador++){
               Console.WriteLine("Nome: "+nomes[contador]);
               Console.WriteLine("Idades: "+idades[contador]);
           }

           Console.WriteLine($"Digite mais um nome: ");


        }
    }
}