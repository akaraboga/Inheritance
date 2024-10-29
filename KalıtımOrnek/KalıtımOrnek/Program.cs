using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalıtımOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ogrenci ogrenci = new ogrenci();//ogrenci clasından nesne olusturma
            ogrenci.Ad = "Ahmet"; //Ad ve Soyad propertysi BaseKisi yi inherit aldığımızdan geldi.
            ogrenci.Soyad = "Karaboğa";
            ogrenci.OgrenciNumara = 1445;

            Ogretmen ogretmen = new Ogretmen();
            ogretmen.Ad = "Yiğit";//Ad ve Soyad propertysi BaseKisi yi inherit aldığımızdan geldi.
            ogretmen.Soyad = "Hacıefendioğlu";
            ogretmen.maas = 20000;

            ogrenci.OgrenciBilgi();

            Console.WriteLine();

            ogretmen.OgretmenBilgi();



            Console.ReadLine();
        }



        class BaseKisi //Kişi clasında adını ve soyadını alarak ogretmen ve ogrenci clası içinde kullanacağız. 
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }

            public void yazdir()//Ad ve Soyad propertymizi yazmamız için yazdir adından metot kullanacağız.Bu metot BaseKişi clasının kalıtım yapıldığı clasda da kullanabileceğiz.
            {
                Console.WriteLine(" Adı : {0} \n Soyadı : {1}", Ad, Soyad);
            }

        }


        class ogrenci : BaseKisi//BaseKişiyi inherit alarak ozelliklerini ogrenci clasına atadık.
        {
            public int OgrenciNumara { get; set; }//ogrenci adında Property olusturarak Ogrencinin okul numarasını alacağız.

            public void OgrenciBilgi()//Olusturduğumuz bu metod da Ogrenci bilgilerini alacağız.
            {
                Console.WriteLine(" Öğrencinin\n");

                yazdir();//Bu metod BaseKişi den geldi.BaseKisiyi ogrenci clasına inherit aldığımızda , ogrenci clası basekişi clasının tum ozelliklerine erişebilecek bu sayede ogrenci clasından main metodda bir nesne olusturduğumuzda ad ve soyad propertysine ekleme yapabileceğiz. 

                Console.WriteLine(" Ogrenci No :{0}", OgrenciNumara);//Burdada ogrenci Numarasını yazdırdık.
            }


        }

        class Ogretmen : BaseKisi //Yukarda ki işlemler ogretmen içinde gecerli.
        {
            public decimal maas { get; set; }

            public void OgretmenBilgi()
            {
                Console.WriteLine(" Oğretmenin\n");

                yazdir();

                Console.WriteLine(" ogretmenin maaşı : {0} Tl", maas);
            }

        }


    }
}
