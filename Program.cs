using System;

namespace döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrana girilen sayıya kadar olan tek sayıları ekrana yazdır
            System.Console.WriteLine("Lütfen Bir Sayı Giriniz");
            int sayac = int.Parse(Console.ReadLine());

            for (int i = 1; i <= sayac; i++)
            {
                if (i%2 == 1)
                {
                    System.Console.WriteLine(i);
                }
            }


            // 1 ile 100 arasındaki tek ve çift sayıların kendi içlerinde toplamlarını ekrana yazdır

            int tektoplam = 0;
            int cifttoplam = 0;

            for(int i= 1; i<=1000;i++)
            {
                if(i%2 == 1)
                {
                    tektoplam += i;
                }
                else
                {
                    cifttoplam += i;
                }
            }

            System.Console.WriteLine("Tek Toplam: " + tektoplam);
            System.Console.WriteLine("Çift Toplam: " + cifttoplam);

            // Break, continue

            for (int i = 1; i < 10; i++)
            {
                if (i==4)
                {
                    break;
                }
                Console.WriteLine(i);
            }

                        for (int i = 1; i < 10; i++)
            {
                if (i==4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
