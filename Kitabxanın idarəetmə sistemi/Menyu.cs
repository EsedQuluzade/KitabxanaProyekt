using Kitabxanın_idarəetmə_sistemi;
using Kitabxanın_idarəetmə_sistemi.Exceptions;
using System.Diagnostics;
namespace Kitabxanın_idarəetmə_sistemi
{
    internal class Menyu
    {
        Kitablar kitablar = new();
        Seslikitablar seslikitablar = new();
        Jurnallar jurnallar = new();
        bool aktiv = true;

        public Kitablar GetKitablar()
        {
            return kitablar;
        }

        public void menu(Kitablar kitablar)
        {
            while (aktiv)
            {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1)Kitabxanadakı kitabların siyahısı");
            Console.WriteLine("2)Kitab əlavə etmək");
            Console.WriteLine("3)Səsli kitab əlavə etmək");
            Console.WriteLine("4)Jurnal əlavə etmək");
            Console.WriteLine("5)Tələbəyə kitab kirayə vermək");
            Console.WriteLine("6)Tələbəyə jurnal kirayə vermək");
            Console.WriteLine("7)Kitabxanada axtarış etmək");
            Console.WriteLine("8)Çıxış");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Seçiminizi edin:(1-8)");
            Console.WriteLine("--------------------------------");
            int secim =Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Kitabxanadakı kitabların siyahısı");
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("1)Kitablar\n2)Səsli kitablar\n3)jurnallar");
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Seçiminizi edin:(1-3)");
                        Console.WriteLine("--------------------------------");
                        int secim1 = Convert.ToInt32(Console.ReadLine());
                        switch (secim1)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Kitablar");
                                kitablar.kitabsiyahi();
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("Səsli kitablar");
                                seslikitablar.seslikitabsiyahi();
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("Jurnallar");
                                jurnallar.jurnalsiyahi();
                                break;
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Zəhmət olmasa əlavə edəcəyiniz kitabın adın daxil edin. ");
                        string newBook = Console.ReadLine();
                        kitablar.AddBook(newBook);
                        Console.WriteLine("Daxil etdiyiniz ad uğurla əlavə edildi");
                        Thread.Sleep(2000);
                        break;
                case 3:
                        Console.Clear();
                        Console.WriteLine("Zəhmət olmasa əlavə edəcəyiniz səsli kitabın adın daxil edin. ");
                        string newsoundbook = Console.ReadLine();
                        seslikitablar.Addsoundbook(newsoundbook);
                        Console.WriteLine("Daxil etdiyiniz ad uğurla əlavə edildi");
                        Thread.Sleep(2000);
                    break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Zəhmət olmasa əlavə edəcəyiniz jurnalın adın daxil edin. ");
                        string newjurnal = Console.ReadLine();
                        jurnallar.Addjurnal(newjurnal);
                        Console.WriteLine("Daxil etdiyiniz ad uğurla əlavə edildi");
                        Thread.Sleep(2000);
                    break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Zəhmət olmasa icarəyə verəcəyiniz kitabın adın daxil edin. ");
                        string remBook = Console.ReadLine();
                        try
                        {
                            kitablar.RemoveBook(remBook);
                            Console.WriteLine("Uğurla icarəyə verdiniz");
                        }
                        catch (KitabTapilmadiException ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(ex.Message);
                            Console.ResetColor();
                        }
                        Thread.Sleep(2000);
       
                    break;
                    case 6:
                          Console.Clear();
                        Console.WriteLine("Zəhmət olmasa icarəyə verəcəyiniz jurnalın adın daxil edin. ");
                        string remjurnal = Console.ReadLine();
                        try
                        {
                            jurnallar.Removejurnal(remjurnal);
                            Console.WriteLine("Uğurla icarəyə verdiniz");
                        }
                        catch (KitabTapilmadiException ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Belə bir jurnal yoxdur.");
                            Console.ResetColor();
                        }
                        Thread.Sleep(2000);
                        Console.Clear();

                        break; 
                    case 7:             
                        Console.WriteLine("Zəhmət olmasa axtardığınız kitabın adın daxil edin");
                        string bookfind = Console.ReadLine();
                        kitablar.FindBook(bookfind);
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                    case 8:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sistemdən çıxış edilir");
                    Thread.Sleep(2000);
                    Console.Clear();
                        Console.ResetColor();
                        return;
                default: 
                    Console.WriteLine("Zəhmət olmasa seçimi 1-8 arasında edin.");
                    break;
            } 





            }
           
        }
    }
}
