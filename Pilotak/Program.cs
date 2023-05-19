using System;
using System.IO;
using System.Linq;
using Pilotak;

namespace Pilotak
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pilota> lista = new List<Pilota>();

            StreamReader sr = new StreamReader("pilotak.csv");
            sr.ReadLine();

            while (sr.EndOfStream) 
            {
                lista.Add(new Pilota(sr.ReadLine()));
            }
            sr.Close();

            Console.WriteLine($"3. feladat: {lista.Count} fő.");

            Console.WriteLine($"4. feladat: ");
        }
    }
}