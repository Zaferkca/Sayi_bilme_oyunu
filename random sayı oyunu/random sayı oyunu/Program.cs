using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_sayı_oyunu
{
    class randombime
    {
        public int sayıbul(int x)
        {
            Random random = new Random();
            int rastgeleSayi = random.Next(1, 11);
            int tahmin = 0;
            int tahminHakki = 3;
            Console.WriteLine("1 ile 10 arasında bir sayıyı tahmin edin:");
            while (tahminHakki > 0)
            {
                    if (tahmin == rastgeleSayi)
                    {
                        Console.WriteLine("Tebrikler! Doğru tahmin ettiniz.");
                        break;
                    }
                    else
                    
                    tahminHakki--;
                    if (tahminHakki > 0)
                    {
                            Console.WriteLine("Yanlış tahmin ettiniz. Kalan tahmin hakkınız: " + tahminHakki);
                    }
                else
                {
                   Console.WriteLine("Tahmin hakkınız bitti. Doğru cevap: " + rastgeleSayi);      
                }
                        
                                                                     
                    else
                    {
                        Console.WriteLine("Lütfen geçerli bir sayı girin.");
                    }

            }

            Console.WriteLine("Oyun bitti. İyi günler!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
         Console.ReadKey();
        }
    }
}
