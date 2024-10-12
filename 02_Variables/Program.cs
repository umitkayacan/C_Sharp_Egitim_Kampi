using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine("");

            //double applePrice, orangePrice, bananaPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 22.19;
            //bananaPrice = 66.88;
            //potatoPrice = 22.17;
            //tomatoPrice = 44.22;

            //Console.WriteLine("---- Elma Birim Fiyatı :" + applePrice + " TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı :" + orangePrice + " TL");
            //Console.WriteLine("---- Muz Birim Fiyatı :" + bananaPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı :" + potatoPrice + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı :" + tomatoPrice + " TL");

            //double appleGram, orangeGram, bananaGram, potatoGram, tomatoGram;
            //appleGram = 1.250;
            //orangeGram = 2.650;
            //bananaGram = 4.536;
            //potatoGram = 3.456;
            //tomatoGram = 3.966;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double bananaTotalPrice = bananaGram * bananaPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma - Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " GR. -  Toplam Tutar: " + appleTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Portakal - Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " GR. -  Toplam Tutar: " + orangeTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Muz - Birim Fiyat: " + bananaPrice + " - Gramaj: " + bananaGram + " GR. -  Toplam Tutar: " + bananaTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Patates - Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + " GR. -  Toplam Tutar: " + potatoTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Domates - Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " GR. -  Toplam Tutar: " + tomatoTotalPrice + " TL");

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + bananaTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Alışveriş Toplam Tutar : " + shoppingTotalPrice + " TL");
            #endregion

            #region Char Değişkenler

            //char symbol='B';
            //Console.WriteLine(symbol);


            #endregion

            #region Veri Girişi String Değişkenler
            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu T.C. Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------------------");
            //Console.WriteLine("Yolcu T.C. No: "  + passengerIdentityNumber + " Yolcu Ad Soyad " + passengerName + " " + passengerSurname + "Adres: " + passengerDistrict + "/" + passengerCity + " - Yaş: " + passengerAge );

            #endregion

            #region Veri Girişi Tam Sayı ve Dönüşümler
            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 50000;
            //chairPrice = 5000;
            //tvPrice = 30000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı adedini giriniz. ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar adedini giriniz. ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye adedini giriniz. ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız TV adedini giriniz. ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice +  chairCount * chairPrice + tvCount * tvPrice;
            //Console.WriteLine("");
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice + " TL");

            #endregion

            #region Veri Girişi Ondalıklı Sayı

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

            #region Veri Girişi Karakterler
            char gender;
            Console.Write("Lütfen Cinsiyet Seçiniz: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion


            Console.Read();
        }
    }
}
