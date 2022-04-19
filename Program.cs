using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Ders
{
    class Program
    {
        static void Main(string[] args)
        {
            char karakter = 'K'; //2 byte
            string isim = "Kaan"; //8 byte
            int tamSayi = 15; //4 byte
            float kesirliSayi = 3.4f; //4 byte;
            double buyukKesirliSayi = 4.5; //8 byte
            bool anahtar = true; //1 byte

            Console.WriteLine(sizeof(int));
            Console.WriteLine(sizeof(char));
            Console.WriteLine(sizeof(float));
            Console.WriteLine(sizeof(bool));
            Console.WriteLine(sizeof(double));
            Console.WriteLine(isim.Length * sizeof(char));


            Console.ReadLine();
        }
    }
}
