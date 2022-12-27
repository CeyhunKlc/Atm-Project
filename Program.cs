
using System;

namespace AtmProject
{
    public class program
    {
        public static void Main(string[] args)
        {

            int Balance = 8500;

            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Tuşlama Yaparak Seçiniz");
                Console.WriteLine("********************************************************");
                Console.WriteLine("Bakiye Öğrenme    (1)");
                Console.WriteLine("Para Yatırma      (2)");
                Console.WriteLine("Para Çekme        (3)");
                Console.WriteLine("Çıkış             (0)");
                string select = Console.ReadLine();
                if (select == "1")
                {
                    Console.WriteLine("Bakiyeniz:" + Balance);
                }
                else if (select == "2")
                {
                    Console.WriteLine("Yatırmak  İstediğiniz Tutarı Giriniz:");
                    int Deposit = Convert.ToInt32(Console.ReadLine());
                    Balance = Balance + Deposit;
                    Console.WriteLine(Balance);
                }
                else if (select == "3")
                {
                    Console.WriteLine("Lütfen Çekmek İstediğiniz Tutarı Girin:");
                    int Amount_Withdrawn = Convert.ToInt32(Console.ReadLine());
                    Balance = Balance - Amount_Withdrawn;
                    Console.WriteLine(Balance);
                }
                else if (select == "0")
                {
                    Console.WriteLine("Çıkış Yapılıyor.");
                    break;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Yanlış Tuşlama Yaptonız Lütfen Tekrar Deneyiniz,");
                }

            }

        }
    }
}
