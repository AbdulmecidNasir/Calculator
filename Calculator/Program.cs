using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string devam;
            do
            {
                Console.WriteLine("----------Hesap Makinesi------------");
                Console.WriteLine("Lutfen Birinci Sayiyi Giriniz : ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Lutfen Ikinci Sayiyi Giriniz : ");
                int sayi2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Alttaki Aritmetik Islemleden birini seciniz :");
                Console.WriteLine("'+'  '-'  '*'  '/'");
                string secim = Console.ReadLine();
                if (secim == "+")
                {
                    int sonuc = sayi1 + sayi2;
                    Console.WriteLine(sayi1 + " + " + sayi2 + " = " + sonuc);
                }
                else if (secim == "-")
                {
                    int sonuc = sayi1 - sayi2;
                    Console.WriteLine(sayi1 + " - " + sayi2 + " = " + sonuc);
                }
                else if (secim == "*")
                {
                    int sonuc = sayi1 * sayi2;
                    Console.WriteLine(sayi1 + " * " + sayi2 + " = " + sonuc);
                }
                else if (secim == "/")
                {
                    if (sayi2 != 0)
                    {
                        double sonuc = (double)sayi1 / sayi2;
                        Console.WriteLine(sayi1 + " / " + sayi2 + " = " + sonuc);
                    }
                    else
                    {
                        Console.WriteLine("Bir sayi 0'a bolunemez.");
                    }

                }
                else
                {
                    Console.WriteLine("Gecersiz bir islem secimi yaptiniz !");
                }
                Console.WriteLine("Bir daha islem yapmak istermisiniz ('E'/'H')");
                devam = Console.ReadLine();
               
            } while (devam == "E" || devam == "e");
            Console.WriteLine("Program sona erdi.");
            Console.ReadKey();
        }
    }
}
