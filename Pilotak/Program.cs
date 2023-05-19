using System;
using System.IO;
using System.Linq;
using System.Text.Unicode;
using System.Collections.Generic;
using Pilotak;
using System.Text;

namespace Pilotak
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pilota> lista = new List<Pilota>();

            StreamReader sr = new StreamReader("pilota.csv");
            sr.ReadLine();
            while (sr.EndOfStream) 
            {
                lista.Add(new Pilota(sr.ReadLine()));
            }
            sr.Close();

            Console.WriteLine($"3. feladat: {lista.Count}");

            Console.WriteLine($"4. feladat: {lista.Last().Név}");

            Console.WriteLine("5. feladat: ");

        }
    }
}