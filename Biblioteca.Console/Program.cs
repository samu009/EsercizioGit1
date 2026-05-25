using Biblioteca.Domain;
using Brani.Domain;

namespace Biblioteca.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {
                string inputTitolo = Console.ReadLine();
                string inputAutore = Console.ReadLine();
                int inputDurata = int.Parse(Console.ReadLine());
                string t = Console.WriteLine("premi 1 se vuoi aggiungere un altro brano al cd o 0 per finire:");
                if(t== "1")
                {
                    Brano brano = new Brano(inputTitolo, inputAutore, inputDurata);
                    CD cd = new CD("CD1", "Autore1");
                    cd.listaBrani.Add(brano);
                }
            } while (s == true);
        }
    }
}
