using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Döngüler_Jump_Deyimleri
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i == 3 || i == 6)
                {
                    continue; // Sonraki adıma geçer. Yani i++ kısmını yapar. Yazdırmayı yapmaz.
                }
                Console.WriteLine(i);
            }
            // Kullanıcıdan sayı alınarak 10'dan küçük olup olmadığını kontrol ediniz. Eğer sayı 10'dan küçükse ekranda gösteriniz. Değilse kullanıcıdan tekrar sayıyı isteyiniz. Kullanıcı 3 kere 10'dan küçük sayısını ekranda görebilmelidir. Yani 3 hakkı olmalıdır.
            /*  for (int j = 0; j < 3; j++)
                {
                    Console.Write("Sayı giriniz: ");
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    if (sayi > 10)
                    {
                        j--;
                        continue;
                    }
                    Console.Write("\nSayınız:" + sayi + "\n\n2");
                }  */
            int j = 0;
            while (j < 3)
            {
                Console.Write("Sayı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi > 10)
                {
                    continue;
                }
                Console.Write("\nSayınız: " + sayi + "\n\n");
                j++;
            }
            Console.ReadKey();
        }
    }
}
/* Break, Continue, Return
   Döngü içerisinde kullanılan akış değiştirme komutlarıdır.
   Bu komutlar bir koşula göre yazılır ve kullanıldıkları satırdan sonraki hiç bir komutu çalıştırmazlar.
   Break: Switch - case ve döngülerde kullanılır. Switch'te ne yapıyorsa döngüde de aynısını yapar, döngüyü bitirir.
   Continue: Sadece döngülerde kullanılır. Döngüde bir sonraki adıma geçer.
   Return: Her yerde kullanılır. Olayı sonlandırır.
*/