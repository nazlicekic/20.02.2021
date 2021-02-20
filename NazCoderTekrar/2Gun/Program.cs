using System;

namespace _2Gun
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("1.not gir");
            //int not1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.not gir");
            //int not2 = Convert.ToInt32(Console.ReadLine());
            //double ort = (not1 + not2) / 2;

            //if (ort >= 50) //== atama operatör c== true
            //    Console.WriteLine("geçti");
            //else
            //    Console.WriteLine("Kaldı");

            //Console.ReadKey();

            //Conditional ve Ternary Operatorler

            ////Ternary Operatörü: Üç işlem alan

            //Console.Write("[1-10] arasında sayı giriniz");
            //if ()
            //{

            //}
            //int rakam = int.Parse(Console.ReadLine());
            //string cevap = "";
            //cevap += rakam == 7 ? "doğru cevap" : "yanlış cevap";
            //Console.WriteLine(cevap);



            // Coalescing Kullanımı 
            Console.WriteLine("Yasını gir");
            string yas = Console.ReadLine();
            string sonuc = "";

            sonuc = (yas == "" ? null : yas) ?? "boş geçildi";
            Console.WriteLine("Yasınız : " + sonuc);
        }
    }
}
