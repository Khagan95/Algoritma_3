using System;

namespace KarakterDegistirmeUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("String ifade: ");
            string ifade = Console.ReadLine();

            KarakterDegistirici karakterDegistirici = new KarakterDegistirici();
            string sonuc = karakterDegistirici.KarakterDegistir(ifade);

            Console.WriteLine("Sonuç: " + sonuc);
        }
    }

    class KarakterDegistirici
    {
        public string KarakterDegistir(string ifade)
        {
            char[] karakterler = ifade.ToCharArray();

            for (int i = 0; i < karakterler.Length - 1; i += 2)
            {
                char temp = karakterler[i];
                karakterler[i] = karakterler[i + 1];
                karakterler[i + 1] = temp;
            }

            return new string(karakterler);
        }
    }
}
