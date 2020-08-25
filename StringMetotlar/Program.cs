using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //double sonuc =  Math.Sin(90);

            //UPPER 
            Console.WriteLine("Lütfen bir kelime giriniz");
            string data = Console.ReadLine();
            //string sonuc = data.ToUpper();

            //LOWER
            //string sonuc = data.ToLower();

            //TRIM
            //string sonuc = data.Trim();

            //TRIM START
            //string sonuc = data.TrimStart();

            //TRIM END
            //string sonuc = data.TrimEnd();

            //REPLACE
            //string sonuc = data.Replace('a', 'x');
            //string sonuc = data.Replace("adam", "kadın");

            //Index Of
            //int sonuc = data.IndexOf('t');
            //çağatay

            //PADDING
            //string sonuc = data.PadLeft(50,'*');
            //string sonuc = data.PadRight(50, '*');

            //SUBSTRING
            //string sonuc = data.Substring(2, 5);

            //REMOVE
            //string sonuc = data.Remove(3);
            //string sonuc = data.Remove(3,1);

            //Telefon numarasının 90 dan sonrasını bana ver
            //+905437331470
            //905437331470
            //+902123356528
            //int indexno = data.IndexOf('5');
            //int indexno2 = data.IndexOf("90");

            // string sonuc = data.Substring(indexno);

            //90-543-733-14-70   => 5437331470
            //string veri = "90-543-733-14-70";

            //string veri2 = veri.Remove(0, 3);

            //for (int i = 0; i < veri2.Length; i++)
            //{
            //    if (veri2[i] == '-')
            //    {
            //       veri2 = veri2.Remove(i, 1);
            //    }
            //}


            //SPLIT
            //string veri = "İzmir,İstanbul,Ankara,Trabzon,Ordu,Diyarbakır,Gaziantep";
            //string[] sehirler = veri.Split(',');

            //string ulkeler = "MakedonYa,jamaiKA,koloMbiya,fransa,TÜRKİYE,güney Afrika";

            //string[] ulkedizi = ulkeler.Split(',');

            //for (int i = 0; i < ulkedizi.Length; i++)
            //{
            //    ulkedizi[i] = ulkedizi[i].ToLower();
            //    ulkedizi[i] = ulkedizi[i].Substring(0, 1).ToUpper() + ulkedizi[i].Substring(1);

            //    int boslukno = ulkedizi[i].IndexOf(' ');

            //    //Güney Afrika
            //    if(boslukno != -1)
            //    {
            //        ulkedizi[i] = ulkedizi[i].Substring(0,boslukno + 1) + ulkedizi[i].Substring(boslukno + 1,1).ToUpper() + ulkedizi[i].Substring(boslukno + 2);
            //    }

            //    Console.WriteLine(ulkedizi[i]);
            //}


            string data1 = "Bilge";
            string data2 = "Bilge";

            //aynıysa 0, farklıysa -1 veya 1
            //int sonuc = data1.CompareTo(data2);

            //INT ornek
            //            s1 == s2 returns 0
            //s1 > s2 returns 1
            //s1 < s2 returns - 1
            int x = 4;
            int y = 5;

            int sonuc = x.CompareTo(y);

            Console.WriteLine(sonuc);
            Console.ReadLine();


        }
    }
}
