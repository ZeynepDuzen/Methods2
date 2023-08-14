using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*** index of ***
            //string[] kisiler = {"Zeynep","Sehat","Cankus","Tatlis","Biricik"};
            //Array.Sort(kisiler);
            //int sira = Array.IndexOf(kisiler,"Tatlis");
            //Console.WriteLine("Tatlis isminin index no : " + sira);
            //***************************************************************

            //int[] sayilar = {10,20,30,40,50};
            //Console.WriteLine(Array.IndexOf(sayilar,30));
            //****************************************************************

            // max value - min value
            //int[] sayilar = {3,8,4,1,9,7,5};
            //Console.WriteLine("Sayilar dizisinin en kucuk degeri : " + sayilar.Min());
            //Console.WriteLine("Sayilar dizisinin en buyuk degeri : " + sayilar.Max());
            //*****************************************************************

            //int[] sayilar2 = {10,20,30,40,50};
            //Console.WriteLine("Sayilar2 dizisinin en buyuk elemani : " + sayilar2.Max());
            //Console.WriteLine("Sayilar2 dizisinin en kucuk elemani : " + sayilar2.Min());
            //****************************************************************

            // *** foreach ***

            //string[] sehirler = {"Bursa","Edirne","Istanbul","Isparta","Duzce"};
            //foreach (string s in sehirler)
            //{
            //    Console.WriteLine(s);
            //}
            //****************************************************************

            //int[] sayilar3 = {5,3,8,9,7};
            //foreach (int s in sayilar3)
            //{
            //    Console.WriteLine(s);
            //}
            //***************************************************************

            //int[] sayilar4 = {2,3,5,1};
            //int toplam = 0;
            //foreach (int n in sayilar4)
            //{
            //    toplam += n;
            //}
            //Console.WriteLine("Dizi eleman degerlerinin toplami : " + toplam);
            //****************************************************************

            int[] sayilar5 = {9,7,6,4,3,1,8,5,2};
            foreach (int x in sayilar5)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine(x);
                    
                }
                Array.Sort(sayilar5);
               
            }







            Console.Read();
        }
    }
}
