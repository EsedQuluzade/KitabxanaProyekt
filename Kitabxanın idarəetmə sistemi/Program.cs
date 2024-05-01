using Kitabxanın_idarəetmə_sistemi;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Login login = new();
login.CheckUser();


if (login.cehdSayi <= 5)
{
    Menyu menyu = new();
    menyu.menu(menyu.GetKitablar());

}

