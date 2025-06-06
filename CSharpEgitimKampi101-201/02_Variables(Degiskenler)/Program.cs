using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables_Degiskenler_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double Degiskenler
            //Console.WriteLine("*********** Fiyat Listesi **************");

            //double applePrice, orangePrice, bananaPrice, tomatoPrice;

            //applePrice = 23.23;
            //orangePrice = 43.99;
            //bananaPrice = 60.43;
            //tomatoPrice = 23.39;
            //Console.WriteLine("---------- Elma birim fiyati :" + applePrice);
            //Console.WriteLine("---------- Portakal birim fiyati :" + orangePrice);
            //Console.WriteLine("---------- Muz birim fiyati :" + bananaPrice);
            //Console.WriteLine("---------- Domates birim fiyati :" + tomatoPrice);
            //Console.WriteLine("\n");
            // double appleGram, orangeGram, bananaGram, tomatoGram;

            //appleGram = 1245;
            //orangeGram = 4321;
            //bananaGram = 2300;
            //tomatoGram = 1656;


            //double appleTotalPrice , orangeTotalPrice , bananaTotalPrice , tomatoTotalPrice ,totalCost;

            //appleTotalPrice = applePrice* appleGram;
            //orangeTotalPrice= orangePrice* orangeGram;   
            //bananaTotalPrice = bananaPrice* bananaGram;
            //tomatoTotalPrice = tomatoPrice* tomatoGram;

            //Console.WriteLine("Elmanın toplam fiyati: " + appleTotalPrice +"TL");
            //Console.WriteLine("Portakalın toplam fiyati: " + orangeTotalPrice + "TL");
            //Console.WriteLine("Muzun toplam fiyati: " + bananaTotalPrice + "TL");
            //Console.WriteLine("Domatesin toplam fiyati: " + tomatoTotalPrice + "TL");

            //totalCost = appleTotalPrice + orangeTotalPrice+bananaTotalPrice+tomatoTotalPrice ;

            //Console.WriteLine("Toplam hesap :" + totalCost/1000 + " TL");// bir kg bin gram oldugu için

            //Console.Read();
            #endregion

            #region Char Degiskenler

            //char ch = 'a';// karakterler tek tırnakla alınırlar
            //Console.WriteLine(ch);


            #endregion

            #region Klavyeden Veri Girişleri  String Değişkenler

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerID, passengerAge;

            //Console.Write("Yolcunun adı:");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcunun Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.WriteLine("------- yolcu biligileri --------");

            //Console.WriteLine(passengerName+" "+passengerSurname);

            //Console.Write("Yolcunun ilcesi :");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Yolcunun sehri :");
            //passengerCity=  Console.ReadLine();

            //Console.Write("Yolcunun ID'si :");
            //passengerID = Console.ReadLine();

            //Console.WriteLine("Yolcunun ID'si :" + passengerID);
            #endregion;

            #region  Klavyeden Tam Sayı Girişleri ve Dönüşümler


            //int shoesPrice, tvPrice, chairPrice, computerPrice;

            //computerPrice = 22000;
            //shoesPrice = 2344;
            //tvPrice = 23223;
            //chairPrice = 231;


            //int shoesCount, tvCount, chairCount, computerCount;

            //Console.WriteLine(" Kac adet ayakkabı aldınız ? ");
            //shoesCount = int.Parse( Console.ReadLine());

            //Console.WriteLine(" Kac adet bilgisayar aldınız ? ");
            //computerCount = int.Parse( Console.ReadLine());

            //Console.WriteLine(" Kac adet televizyon aldınız ? ");
            //tvCount = int.Parse(Console.ReadLine());

            //Console.WriteLine(" Kac adet sandalye aldınız ? ");
            //chairCount = int.Parse( Console.ReadLine()); 

            //int totalCost = computerPrice* computerCount + chairCount* chairPrice + tvCount* tvPrice + shoesCount* shoesPrice;


            //Console.WriteLine("toplam tutar ="+ totalCost +" TL");

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.WriteLine("Please entry first exam point");
            // exam1 =double.Parse(Console.ReadLine());

            //Console.WriteLine("Please entry second exam point");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Please entry third exam point");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("\nLast result:" + result);


            #endregion

            #region Klavyeden Karakter Girişleri

            char gender;
            Console.WriteLine("Please choose a gender");

            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("The gender that you had chose: "+ gender );

            #endregion

            Console.Read();
        }
    }
}
