﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //int i;
            //for (i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 0; i <=20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 51; i += 3)
            //{
            //    Console.WriteLine(i);
            //}


            //Console.Write("Lütfen adedi giriniz: ");
            //int finishValue=int.Parse(Console.ReadLine());

            //for (int i = 0; i <=finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet " + i);
            //}
            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 1; i <=100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;
            //for (int i = 0; i <= 10; i++)
            //{ 
            //    totalValue += i;
            //}

            //Console.WriteLine(totalValue);

            //int totalValue = 0;
            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("--------------------");
            //Console.WriteLine(totalValue);

            //int count = 0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine(count);

            //int bacterium = 1;

            //for (int hours = 1; hours <= 24; hours++)
            //{
            //    bacterium *= 2;

            //    Console.WriteLine(hours + ". Saat Sonunda: " + bacterium);
            //}


            #endregion

            #region While Döngüsü

            //int i = 1;
            //int sum = 0;

            //while (i<=10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine("While Çalışıyoruz - Toplam " + sum);

            #endregion

            #region Örnek Sınav Sorusu
            Console.Write("Sayıyı Giriniz: ");
            int number = int.Parse(Console.ReadLine());
            int ones, tens, hundreds, sum;

            ones = number % 10;
            hundreds = number / 100;
            tens = (number % 100) / 10;

            sum = ones + tens + hundreds;

            Console.WriteLine(ones + "|" + tens + "|" + hundreds);
            Console.WriteLine("Toplam: " + sum);

            #endregion


            Console.Read();
        }
    }
}
