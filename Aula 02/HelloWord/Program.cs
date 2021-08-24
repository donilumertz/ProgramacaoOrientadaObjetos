using System;

namespace HelloWord
{
    class Program
    {
        static void Main(string[] args)
        {
           Escrever("Hello World!");

           Escrever("Digite qualquer coisa:");

           string nome = Ler();

           Escrever("o nome digitado é " + nome);

           Garrafa termica = new Garrafa(100,1,"galderio");

           Escrever(termica.getCodigo() + " e capacidade: " + termica.getCapacidade() + " lt " + termica.GetMarca());
           termica.SetMarca("galderia plus plus");
           Escrever(termica.GetMarca());


            
        }

        static void Escrever(string t)
        {
            Console.WriteLine(t);
        }

        static string Ler()
        {
            return Console.ReadLine();
        }
    }
}
