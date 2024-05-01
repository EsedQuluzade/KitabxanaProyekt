using Kitabxanın_idarəetmə_sistemi.Exceptions;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Kitabxanın_idarəetmə_sistemi
{
    internal class Jurnallar
    {
        private string[] list;

        public Jurnallar()
        {
            list = new[]
            {
                "---------------------------------------",
                "İpək yolu",
                "Düşünən İnsan",
                "Xəzər",
                "Qızıl tələbə",
                "Zəka"
            };
        }
        public void jurnalsiyahi()
        {
            foreach (var jurnal in list)
            {
                Console.WriteLine(jurnal);
            }
        }

        internal void Addjurnal(string newjurnal)
        {
            Array.Resize(ref list, list.Length + 1);
            list[list.Length - 1] = newjurnal;

        }
        public void Removejurnal(string remjurnal)
        {
            int index = Array.IndexOf(list, remjurnal);
            if (index < 0)
                throw new KitabTapilmadiException();

            for (int i = index; i < list.Length - 1; i++)
            {
                list[i] = list[i + 1];
            }
            Array.Resize(ref list, list.Length - 1);


        }
       
    }
}
