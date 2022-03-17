using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator";

            float jumlah, kurang, kali, bagi;
            float a, b;
            int pilih;

            Console.WriteLine("Pilih Menu Kalkulator");
            Console.WriteLine("1. Penjumlahan (+)");
            Console.WriteLine("2. Pengurangan (-)");
            Console.WriteLine("3. Perkalian (×)");
            Console.WriteLine("4. Pembagian (:)");
            Console.WriteLine("5. Keluar");

            Console.Write("Masukkan Menu Pilihan (1-5): ");
            pilih = Convert.ToInt16(Console.ReadLine());
            switch (pilih)
            {
                case 1:
                    Console.Write("Masukkan Angka Pertama: ");
                    a = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Masukkan Angka Kedua: ");
                    b = Convert.ToInt16(Console.ReadLine());
                    jumlah = a + b;
                    Console.WriteLine("=================================");
                    Console.WriteLine("Hasil Penjumlahan " + a + " + " + b + " Adalah " + jumlah);
                    Console.WriteLine("=================================");
                    Console.WriteLine("Tekan Sembarang Key Untuk Keluar");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.Write("Masukkan Angka Pertama: ");
                    a = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Masukkan Angka Kedua: ");
                    b = Convert.ToInt16(Console.ReadLine());
                    kurang = a - b;
                    Console.WriteLine("=================================");
                    Console.WriteLine("Hasil Pengurangan " + a + " - " + b + " Adalah " + kurang);
                    Console.WriteLine("=================================");
                    Console.WriteLine("Tekan Sembarang Key Untuk Keluar");
                    Console.ReadKey();
                    break;

                case 3:
                    Console.Write("Masukkan Angka Pertama: ");
                    a = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Masukkan Angka Kedua: ");
                    b = Convert.ToInt16(Console.ReadLine());
                    kali = a * b;
                    Console.WriteLine("=================================");
                    Console.WriteLine("Hasil Perkalian " + a + " × " + b + " Adalah " + kali);
                    Console.WriteLine("=================================");
                    Console.WriteLine("Tekan Sembarang Key Untuk Keluar");
                    Console.ReadKey();
                    break;

                case 4:
                    Console.Write("Masukkan Angka Pertama: ");
                    a = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Masukkan Angka Kedua: ");
                    b = Convert.ToInt16(Console.ReadLine());
                    bagi = a / b;
                    Console.WriteLine("=================================");
                    Console.WriteLine("Hasil Pembagian " + a + " : " + b + " Adalah " + bagi);
                    Console.WriteLine("=================================");
                    Console.WriteLine("Tekan Sembarang Key Untuk Keluar");
                    Console.ReadKey();
                    break;

                case 5:
                    Console.Write("Terimakasih Sudah Menggunakan Aplikasi ini");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Input Yang Anda Masukkan Salah");
                    Console.WriteLine("Silahkan Ulangi !!!");
                    Console.ReadKey();
                    break;
            }
        }
    }
}