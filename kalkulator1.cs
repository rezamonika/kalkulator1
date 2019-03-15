using System;

namespace kalkulator_sederhana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator Sederhana";



            Console.WriteLine("Pilih Menu : ");
            Console.WriteLine();
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine();
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine();
            Console.WriteLine("3. Perkalian");
            Console.WriteLine();
            Console.WriteLine("4. Pembagian");
            Console.WriteLine();
            Console.WriteLine("Inputkan nomor menu [1,2,3,4] : ");
            int pilihData = int.Parse(Console.ReadLine());


            Console.WriteLine("Inputkan nilai a ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Inputkan nilai b");
            int b = int.Parse(Console.ReadLine());

            if (pilihData == 1)
            {
                Console.WriteLine("Hasil Penambahan" + a + "+" + b + "=" + Penambahan(a, b));
            }
            else if (pilihData == 2)
            {
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            }
            else if (pilihData == 3)
            {
                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            }
            else if (pilihData == 4)
            {
                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
            }



            Console.ReadKey();
        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}