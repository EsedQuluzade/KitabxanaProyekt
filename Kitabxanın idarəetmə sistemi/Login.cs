

namespace Kitabxanın_idarəetmə_sistemi
{
    class Login
    {
        private string myid = "admin";
        private string mypassword = "dma";
        public int cehdSayi = 0;
        public bool finish = true;
        public void CheckUser()
        {
            while (finish)
            {
                
                cehdSayi++;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("İstifadəçi adınızı daxil edin:");
                string name = Console.ReadLine();

                Console.Write("Şifrənizi daxil edin:");
                string password = Console.ReadLine();
                    Console.ResetColor();
                if (myid == name && mypassword == password)
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("Sistemə xoş gəldiniz");
                    Console.Beep();
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.ResetColor();
                    return;
                }
                else if (cehdSayi > 5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("5 Uğursuz cəhddən sonra sistemə daxil ola bilmədiniz.");
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                    Console.ResetColor();
                    return;
                }
            }
           

        }
    }
}

