using System;

namespace Hafta2Ödev
{
    class Program
    {
        static void Main(string[] args)
        {
            int girisHakkı = 3;
            while (true)
            {
                string kullaniciAdi, sifre;
                Console.WriteLine("Kullanıcı adı giriniz...");
                kullaniciAdi = Console.ReadLine();

                Console.WriteLine("Şifre giriniz..");
                sifre = Console.ReadLine();
                if(kullaniciAdi=="admin"&&sifre=="1234")
                {
                    Console.WriteLine("Hoşgeldiniz...");
                    break;
                }
                else
                {
                    Console.WriteLine("Kullanıcı adınız veya şifreniz hatalı!!!");
                    if (girisHakkı>0)
                    {
                        girisHakkı -= 1; 
                    }
                    if (girisHakkı == 0)
                    {
                        Console.WriteLine("3 hatalı giriş yaptığınız için oturumunuz sonlandırılmıştır.");
                        break;
                    }
                    }
                }
                 Console.ReadKey();
            }
        }     
    }

