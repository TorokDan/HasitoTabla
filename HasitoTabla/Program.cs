using System;

namespace HasitoTabla
{
    class Program
    {
        static void Main(string[] args)
        {
            // "HU" <> Magyarország
            // "UK" <> Egyesült királyság
            // "F"  <> Franciaország

            HasitoTabla ht = new HasitoTabla();
            ht.Beszuras("HU", "Magyarorszag");
            ht.Beszuras("FR", "Franciaország");
            ht.Beszuras("HON", "Honduras");

            Console.WriteLine(ht.Kereses("HU"));
            Console.WriteLine(ht.Kereses("FR"));
            Console.WriteLine(ht.Kereses("HON"));
        }
    }
}