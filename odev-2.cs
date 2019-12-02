using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlukRomaDonusturucu
{
    class Program
    {
        static void Main(string[] args)
        {
            int onlukSayi;

            String[] bin = { "", "M", "MM", "MMM" };
            String[] yuz = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            String[] on = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            String[] bir = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            Console.WriteLine("Roma Sayısına Dönüştürmek İstediğiniz Onluk Sayıyı Giriniz");
            onlukSayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Girdiğini Sayı: " + onlukSayi);
            Console.Write("Roma rakamlarıyla karşılığı: ");

            int binlik = onlukSayi / 1000;
            int yuzluk = (onlukSayi % 1000) / 100;
            int onluk = (onlukSayi % 100) / 10;
            int birlik = onlukSayi % 10;

            Console.WriteLine(bin[binlik] + yuz[yuzluk] + on[onluk] + bir[birlik]);

            Console.WriteLine("");
            Console.WriteLine("Çıkmak İçin Bir Tuşa basınız.");
            Console.ReadLine();
        }
    
    }
}
