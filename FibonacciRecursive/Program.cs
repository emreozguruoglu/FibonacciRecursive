using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciRecursive
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch(); //Programın çalışma süresini öğrenebilmek için Stopwatch fonksiyonundan yararlanıldı


            Console.Write("Kacinci fibonacci sayisini ogrenmek istersiniz? :"); //Kaçıncı fibonacci dizisi isteniyorsa o isteniyor.

            double x = double.Parse(Console.ReadLine()); //Fibonacci sayısının girilmesi istendi.

            watch.Start(); //Süre başlatıldı

            Console.WriteLine();

            Console.Write("{0}. fibonacci sayisi : ", x);
            Console.WriteLine(Fibonacci(x)); //Sonuç ekrana basılıyor.

            watch.Stop(); //Süre durduruldu


            TimeSpan timer = watch.Elapsed; //Süre değerlerine erişmek için timer değişkeni oluşturuldu.

            Console.Write("Programin calisma süresi: ");

            string sonuc = String.Format("{0}:{1}:{2}.{3}", timer.Hours, timer.Minutes, timer.Seconds, timer.TotalMilliseconds * 1000000);//Süre saat,dakika,saniye ve milisaniye olarak gösterildi

            Console.Write(sonuc); //Ekrana sonuç yazdırıldı

            Console.WriteLine(); //Bu tip kod satırları konsol çıktısını daha düzgün bir biçimde görmek amacıyla kullanılmıştır.
            Console.Write("Cikmak için ENTER'a basiniz "); // Çıkmak için enter a basılması gerekli.
            Console.WriteLine("");
            Console.ReadLine(); //Ekranda sonucu görebilmemiz için eklendi.Enter a basılınca uygulama kapanır.

        }

        public static double Fibonacci(double n)
        {
            if (n == 0 || n == 1)
                return n;
            else
                return (Fibonacci(n - 1) + Fibonacci(n - 2));
        }
    }
}
