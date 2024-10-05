using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If

            //Console.Write("Lütfen Şifreyi Giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd") {
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlş");
            //}


            //string capital, country;
            //Console.Write("Başkenti Giriniz ");
            //capital = Console.ReadLine();

            //Console.Write("Ülke Giriniz ");
            //country = Console.ReadLine();

            //if (capital=="ankara" & country == "türkiye")
            //{
            //    Console.Write("Veriler Doğrulandı");
            //}
            //else
            //{
            //    Console.Write("Hatalı Bilgi");
            //}


            //int number;
            //Console.Write("Sayı Giriniz ");
            //number= int.Parse(Console.ReadLine());

            //if (number == 5) {
            //    Console.Write("Sayı Doğru");
            //}
            //else
            //{
            //    Console.Write("Sayı Hatalı");
            //}


            //int exam1, exam2, exam3, average;
            //string result="";

            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.Write("Sınavların Ortalaması: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç İyi";
            //}

            //if (average > 84)
            //{
            //    result = "Sonuç Çok İyi";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Şehir Girişi Yazınız: ");
            //city= Console.ReadLine();
            //if (city == "adana" | city == "tekirdağ" | city == "istanbul")
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değil");
            //}


            //Console.WriteLine("Lütfen Kullanıcı Adınızı Yazınız: ");
            //string username=Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.Write("Bu Kullanıcı Adı Kabul Edilemez");
            //}
            //else
            //{
            //    Console.Write("Giriş Başarılı. Hoş Geldiniz");
            //}

            //Console.Read();

            #endregion

            #region Mod İşlemleri
            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. Sayıyı Giriniz: ");
            //int number1= int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sayıyı Giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("Birinci Sayının ("+ number1 +") İkinci Sayıya (" + number2 + ") bölümünden Kalan: " + result);


            //Console.Write("Lütfen Sayıyı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.Write("Girdiğiniz Sayı (" + number + ") Çifttir ");
            //}
            //else {
            //    Console.Write("Girdiğiniz Sayı (" + number + ") Tektir ");
            //}

            #endregion

            #region Char değişkenler ile karar yapıları
            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' || team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}

            //if (team == 'f' || team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}

            //if (team == 'b' || team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}

            #endregion

            #region Örnek Proje
            //Console.WriteLine("****** C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("------------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Ana Yemekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("------------Ana Yemekler------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Çorbalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin çorbası");
            //    Console.WriteLine("------------Çorbalar------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("3-Tavuklu");
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------İçecekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("------------İçecekler------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Tatlılar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Sütlaç");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Supangle");
            //    Console.WriteLine("------------Tatlılar------------");
            //    Console.WriteLine();
            //}
            #endregion

            #region Switch Case
            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthnumber= int.Parse(Console.ReadLine());

            //switch (monthnumber)
            //{
            //    case 1:     Console.WriteLine("Ocak");      break;
            //    case 2:     Console.WriteLine("Şubat");      break;
            //    case 3:     Console.WriteLine("Mart");      break;
            //    case 4:     Console.WriteLine("Nisan");      break;
            //    case 5:     Console.WriteLine("Mayıs");      break;
            //    case 6:     Console.WriteLine("Haziran");      break;
            //    case 7:     Console.WriteLine("Temmuz");      break;
            //    case 8:     Console.WriteLine("Ağustos");      break;
            //    case 9:     Console.WriteLine("Eylül");      break;
            //    case 10:     Console.WriteLine("Ekim");         break;
            //    default:    Console.WriteLine("Hatalı Giriş");   break;
            //}


            #endregion

            #region Swict Case - Benim Örnek 
            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthnumber = int.Parse(Console.ReadLine());
            //switch (monthnumber)
            //{
            //    case 1:
            //    case 2:
            //    case 3:
            //        Console.WriteLine("Kış ayı");
            //        break;
            //    case 4:
            //    case 5:
            //    case 6:
            //        Console.WriteLine("İlkbahar ayı");
            //        break;
            //    case 7:
            //    case 8:
            //    case 9:
            //        Console.WriteLine("Yaz ayı");
            //        break;
            //    case 10:
            //    case 11:
            //    case 12:
            //        Console.WriteLine("Sonbahar ayı");
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı Giriş");
            //        break;
            //}

            #endregion Ümit


            #region Swict Case - Hesap Makinesi

            int number1, number2, result;
            char symbol;

            Console.Write("1.Sayıyı Giriniz: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("2.Sayıyı Giriniz: ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Toplam: " + result);
                    break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Fark: " + result);
                    break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Çarpım: " + result);
                    break;
                case '/':
                    if (number2 != 0)
                    {
                        result = number1 / number2;
                        Console.WriteLine("Bölüm: " + result);
                    }
                    else
                    {
                        Console.WriteLine("Hata: Sıfıra bölme hatası!");
                    }
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem!");
                    break;
            }
            #endregion

            Console.Read();

        }
    }
}
