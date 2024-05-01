using Kitabxanın_idarəetmə_sistemi.Exceptions;

namespace Kitabxanın_idarəetmə_sistemi
{
    internal class Kitablar
    {
        private string[] list;


        public Kitablar()
        {
            list = new[]
            {"---------------------------------------",
                "Hərb və sülh - Lev Tolstoy",
                "Cinayət və cəza - Fyodor Dostoyevski",
                "Yüz ilin tənhalığı – Qabriel Markez",
                "Səfillər – Viktor Hüqo",
                "İçimizdəki şeytan – Sabahaddin Ali",
                "dma",
                "jed"
            };
        }

        public void kitabsiyahi()
        {
            foreach (var kitab in list)
            {
                Console.WriteLine(kitab);

            }
        }


        public void AddBook(string newBook)
        {
            Array.Resize(ref list, list.Length + 1);
            list[list.Length - 1] = newBook;

        }
        public void RemoveBook(string remBook)
        {
            int index = Array.IndexOf(list, remBook);
            if (index < 0)
                throw new KitabTapilmadiException();

            for (int i = index; i < list.Length - 1; i++)
            {
                list[i] = list[i + 1];
            }
            Array.Resize(ref list, list.Length - 1);


        }
        public void FindBook(string bookfind)
        {
            bool found = false;
            foreach (var book in list)
            {
                if (book.Equals(bookfind))
                {
                    Console.WriteLine("Kitab tapıldı: " + book);
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Axtardığınız kitab tapılmadı");
                Console.ResetColor();
            }
        }

    }
}


