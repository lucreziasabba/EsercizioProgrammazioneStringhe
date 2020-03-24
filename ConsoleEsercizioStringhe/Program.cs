using EserciziStringhe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEsercizioStringhe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prova il primo metodo");
            Console.WriteLine("Inserisci la stringa: ");
            string s1 = Console.ReadLine();
            Console.WriteLine("Inserisci la stringa: ");
            string s2 = Console.ReadLine();
            bool risultato = Metodi.AreEquals(s1, s2);
            Console.WriteLine("La risposta è: "+risultato);

            Console.WriteLine("Prova il secondo metodo");
            Console.WriteLine("Inserisci la stringa: ");
            string s = Console.ReadLine();
            bool risultato2 = Metodi.ContainsDoubleChar(s);
            Console.WriteLine("la risposta è: "+risultato2);

            Console.WriteLine("Prova il terzo metodo");
            Console.WriteLine("Inserisci la stringa:  ");
            string s3 = Console.ReadLine();
            string risposta2 = Metodi.Convert(s3);
            Console.WriteLine(risposta2);
            Console.ReadLine();
        }
    }
}
