using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Temel Dizi Örnkleri
            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Siyah";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors);
            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Tekirdağ";
            //cities[1] = "Edirne";
            //cities[2] = "Kırklareli";
            //cities[3] = "İstanbul";
            //cities[4] = "Çorlu";

            //Console.WriteLine(cities[4]);


            //int[] numbers = new int[10];
            //numbers[0] = 698;
            //numbers[1] = 24;
            //numbers[2] = 544;
            //numbers[3] = 2;
            //numbers[4] = 3;
            //numbers[7] = 963;

            //Console.WriteLine(numbers[5]);
            //Console.WriteLine(numbers[7]);

            //string[] cities = { "Prag", "Roma", "Tekirdağ", "Edirne" };

            //Console.WriteLine(cities[2]);
            #endregion

            #region Dizileri Listeleme
            //string[] colors = { "Mavi", "Sarı", "Pembe", "Siyah","Sarı","Deneme" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 2457,321,654,895,321,120,47,635,4845,3,9 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 471, 85, 95, 421, 25, 635, 789, 86, 12500 };

            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}

            //Console.WriteLine(maxNumber);

            //string[] persons = { "ali", "Ümit", "Veli", "Hasan", "Deniz", "Ayşe" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 145, 5, 52, 441, 16, 30, 99, 315 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 145, 5, 52, 441, 16, 30, 99, 315 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            #endregion

            #region Dizi Metotları

            //string[] customers = { "ümit", "deneme", "kayacan", "hasan", "deniz", "kaya" };
            //int index = Array.IndexOf(customers, "ümit");
            //Console.WriteLine(index);


            //int[] numbers = { 425, 654, 2, -10, 6944, 4544, 21, 44, 7};
            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max() + " Dizinin En Küçük Elemanı: " + numbers.Min());

            #endregion

            #region Kullanıcıdan Değer Alma
            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("-------------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            int[] numbers = { 22,48,72, 10, 262, 71, 45, 313, 479, 963, 149, 321};

            Console.WriteLine("Çift Sayılar:");
            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }


            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Tek Sayılar:");
            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            #endregion

            Console.Read();
        }
    }
}
