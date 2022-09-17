using System;
using System.IO;
using System.Linq;


class DIO {

    static void Main(string[] args)
    {
        int qt = int.Parse(Console.ReadLine());
// TODO: Crie as outras condições necessárias para a resolução do desafio:
        string[] v = new string[1000];
        for (int N = 0; N < qt; N++)
        {
            v = Console.ReadLine().Split(" ");
            string a = v[0];
            string b = v[1];

            if (b.Length > a.Length)
                Console.WriteLine("nao encaixa");
            else if (a.EndsWith(b))
                Console.WriteLine("encaixa");
            else
                Console.WriteLine("nao encaixa");

        }

    }

}