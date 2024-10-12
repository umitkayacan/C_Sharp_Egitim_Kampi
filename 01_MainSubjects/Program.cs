using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma İşlemleri

            //Console.WriteLine("Merhaba Dünya");
            //Console.WriteLine("Selam");

            //Console.WriteLine("************* Yemek Kategorileri *************");
            //Console.WriteLine();
            //Console.WriteLine("1 - Çorbalar");
            //Console.WriteLine("2 - Ana Yemekler");
            //Console.WriteLine("3 - Soğuk Başlangıçlar");
            //Console.WriteLine("4 - Salatalar");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("6- İçecekler");
            //Console.WriteLine("************* Yemek Kategorileri *************");
            #endregion

            #region String Değişkenler

            //string customerName;
            //string customerSurName;
            //string customerPhone;
            //string customerEmail, district, city;
            //customerName = "Ümit";
            //customerSurName = "Kayacan";
            //customerPhone = "+90 555 555 55 55";
            //customerEmail = "umit@test.com";
            //district = "Merkez";
            //city = "Tekirdağ";

            //Console.WriteLine("***** Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("**********************************************************");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurName);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("e-Mail Adresi : " + customerEmail);
            //Console.WriteLine("Adres : " + district + "/" + city);
            //Console.WriteLine("**********************************************************");
            //Console.WriteLine();

            //customerName = "Ali";
            //customerSurName = "Kayacan";
            //customerPhone = "+90 123 456 77 88";
            //customerEmail = "test@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**********************************************************");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurName);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("e-Mail Adresi : " + customerEmail);
            //Console.WriteLine("Adres : " + district + "/" + city);
            //Console.WriteLine("**********************************************************");

            #endregion

            #region Integer Değişkenler

            int number = 59;
            Console.WriteLine(number);

            int hamburgerPrice = 500;
            int cokePrice = 40;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 35;

            Console.WriteLine("***** Resoran Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("------- Hamburger Fiyatı: " + hamburgerPrice + " TL");
            Console.WriteLine("------- Pizza Fiyatı: " + pizzaPrice + " TL");
            Console.WriteLine("------- Kola Fiyatı: " + cokePrice + " TL");
            Console.WriteLine("------- Limonata Fiyatı: " + lemonadePrice + " TL");
            Console.WriteLine("------- Kızartma Fiyatı: " + friesPrice + " TL");
            Console.WriteLine("------- Su Fiyatı: " + waterPrice + " TL");
            Console.WriteLine();

            int hamburgerCount, cokeCount, waterCount, friesCount, pizzaCount, lemonadeCount, totalPrice;
            int totalHamburgerPrice, totalCokePrice, totalWaterPrice, totalFriesPrice, totalPizzaPrice, totalLemonadePrice;

            hamburgerCount = 5;
            cokeCount = 0;
            waterCount = 8;
            friesCount = 12;
            pizzaCount = 0;
            lemonadeCount = 2;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("------- Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("------- Pizza Tutarı: " + totalPizzaPrice + " TL");
            Console.WriteLine("------- Kola Tutarı: " + totalCokePrice + " TL");
            Console.WriteLine("------- Limonata Tutarı: " + totalLemonadePrice + " TL");
            Console.WriteLine("------- Kızartma Tutarı: " + totalFriesPrice + " TL");
            Console.WriteLine("------- Su Tutarı: " + totalWaterPrice + " TL");
            Console.WriteLine();

            totalPrice = totalHamburgerPrice + totalPizzaPrice + totalCokePrice + totalLemonadePrice + totalFriesPrice + totalWaterPrice;
            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");
            #endregion

            Console.Read();

        }
    }
}
