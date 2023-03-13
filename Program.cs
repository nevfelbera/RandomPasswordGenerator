using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rastgele Şifre Oluşturucuya Hoşgeldiniz! (Welcome to Random Password Generator!)");
            Console.Write("Şifrenin uzunluğunu giriniz (Enter the length of the password) : ");
            int uzunluk = Convert.ToInt32(Console.ReadLine());

            string sifre = rastgeleSifreOlustur(uzunluk);
            Console.WriteLine($"\nOluşturulan Şifre (Generated Password) : {sifre}");
            Console.WriteLine("İyi Günler! (Have a nice day!)");
            Console.ReadLine();
        }
        static string rastgeleSifreOlustur(int uzunluk)
        {
            string karakter = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxvz0123456789!%&.";
            Random random = new Random();
            char[] sifre = new char[uzunluk];
            for (int i = 0; i < uzunluk; i++)
            {
                sifre[i] = karakter[random.Next(karakter.Length)];
            }
            return new string(sifre);
        }
    }
}

