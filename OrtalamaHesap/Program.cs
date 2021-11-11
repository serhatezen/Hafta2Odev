using System;

namespace OrtalamaHesap
{
    class Program
    {
        static void Main(string[] args)
        { 
            double ortalama;
            double enBuyuk = 0, enKucuk = 0;
            double vizeToplam = 0, finalToplam = 0;
            Console.WriteLine("Öğrenci sayısı giriniz");
            int n = Convert.ToInt32(Console.ReadLine());
            
            for (int i= 0; i < n; i++)
            {
                Console.WriteLine($"{i+1}.öğrenci vize notunu giriniz");
                int vizeNotu = Convert.ToInt32(Console.ReadLine());
                vizeToplam += vizeNotu;

                Console.WriteLine($"{i + 1}.öğrenci final notunu giriniz");
                int finalNotu = Convert.ToInt32(Console.ReadLine());
                finalToplam += finalNotu;
               ortalama = ((vizeNotu * 0.4) + (finalNotu * 0.6));
                if (i==0)
                {
                    enKucuk = ortalama;
                    enBuyuk = ortalama;
                }
                if (enBuyuk < ortalama)
                {
                    enBuyuk = ortalama;
                }
                if(enKucuk>ortalama)
                {
                    enKucuk = ortalama;
                        }
            }
            Double genelOrt = ((vizeToplam * 0.4) + (finalToplam * 0.6)) / n;
            
            Console.WriteLine("En yüksek not ortalaması="+enBuyuk);
            Console.WriteLine("En düşük not ortalaması="+enKucuk);
            Console.WriteLine("Genel ortalama=" + genelOrt);


            Console.ReadKey();

        }
    }
}
