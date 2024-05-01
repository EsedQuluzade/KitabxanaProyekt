using System.Collections;
using System.Collections.Generic;

namespace Kitabxanın_idarəetmə_sistemi
{
    internal class Seslikitablar
    {
        private string[] list;
        public Seslikitablar()
        {
            list = new[]
            {"---------------------------------------",
               "Yazqan Bestami - Qəlbini itirən adam",
              "Bahadıroğlu Yavuz - Dürüst ol ki, xoşbəxt olasan",
              "Sultanov Əziz - Qarışqa uşaq",
              "Hüseyn Cavid - İblis",
              "Məmməd Səid Ordubad - Qılınc və qələm",
            };
        }public void seslikitabsiyahi()
        {
            foreach (var seslikitab in list)
            {
                Console.WriteLine(seslikitab);
            }
        }

        public void Addsoundbook(string newsoundbook)
        {
            Array.Resize(ref list, list.Length + 1);
            list[list.Length - 1] = newsoundbook;
        }

    }
   
}
