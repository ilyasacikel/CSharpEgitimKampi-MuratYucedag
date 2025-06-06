using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects_Temel_Konular_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdirma Komutlari
            //Console.WriteLine("selam");
            //Console.Write("merb merb");
            //Console.Read();//enter a basana dek konsolu kapamaz
            #endregion

            #region  String Degiskenler

            //string name;
            //name = "mamo";

            //string customerName="Ai";
            //string customerSurname ="Vefa";
            //string customerPhone="+90 542 414 7896";
            //String customerEmail = "customer@gmail.com";
            //string district = "Kemal Paşa";
            //string city ="Ankara";

            //Console.WriteLine("************************************\n----------------------------------------------------------------");
            //Console.WriteLine("Müşteri Karti");
            //Console.WriteLine("Müşteri İsmi:" + customerName +" "+ customerSurname);
            //Console.WriteLine( "İletişim:"+customerPhone);
            //Console.WriteLine("Mail:"+customerEmail);
            //Console.WriteLine("Adres:"+ district +" / "+city);
            //Console.WriteLine("----------------------------------------------------------------\n************************************");


            //customerName = "Enver";
            //customerSurname = "Türk";
            //customerPhone = "+10 656 565 4175";
            //customerEmail = "test@gmail.com";
            //district = "Çegan Tepesi";
            //city = "Belcivan ";

            //Console.WriteLine("************************************\n----------------------------------------------------------------");
            //Console.WriteLine("Müşteri Karti");
            //Console.WriteLine("Müşteri İsmi:" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim:" + customerPhone);
            //Console.WriteLine("Mail:" + customerEmail);
            //Console.WriteLine("Adres:" + district + " / " + city);
            //Console.WriteLine("----------------------------------------------------------------\n************************************");

            //Console.Read();
            #endregion

            #region Int Degiskenler

            int hamburgerPrice = 300;
            int cokePrice = 45;
            int friesPrice = 42;
            int waterPrice = 30;
            int lemonadePrice = 50;


            Console.WriteLine("******* Restoran Menü Fiyatları ***************");
            Console.WriteLine("Hamburger :" + hamburgerPrice);
            Console.WriteLine("Kola:" + cokePrice);
            Console.WriteLine("Kızartmalar:" + friesPrice);
            Console.WriteLine("Su:" + waterPrice);
            Console.WriteLine("Limonata :" + lemonadePrice);

            Console.WriteLine("******* Restoran Menü Fiyatları ***************\n");

            int hamburgerCount;
            int cokeCount;
            int friesCount;
            int waterCount;
            int lemonadeCount;

            int totalPrice = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            friesCount = 1;
            waterCount = 3;
            lemonadeCount = 0;

            totalPrice = hamburgerCount * hamburgerPrice + cokePrice * cokeCount + friesPrice * friesCount + friesCount * friesPrice;

            Console.WriteLine(hamburgerCount + " adet hamburger, " + friesCount + " adet kızartma, " + cokeCount + " adet kola, " + waterCount + " adet su ");
            Console.WriteLine("Hesap :" + totalPrice);


            Console.Read();
            #endregion

        }
    }
}
