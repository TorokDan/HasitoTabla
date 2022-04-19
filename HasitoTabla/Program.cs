using System;

namespace HasitoTabla
{
    public class Ember
    {
        public string nev;
        public int fizetes;
    }
    class Program
    {
        static void Main(string[] args)
        {
            // "HU" <> Magyarország
            // "UK" <> Egyesült királyság
            // "F"  <> Franciaország

            HasitoTabla<string,string> ht = new HasitoTabla<string,string>();
            ht.Beszuras("H", "Magyarorszag");
            ht.Beszuras("C", "Chile");
            ht.Beszuras("N", "Németország");
            ht.Beszuras("NL", "Norvégia");
            ht.Beszuras("HON", "Honduras");
            // ht.Beszuras("F", "Franciaország");
            ht["F"] = "Franciaország";
            ht.Beszuras("SP", "Spanyolország");
            ht.Beszuras("S", "Svédország");
            
            Console.WriteLine(ht.Kereses("H"));
            // Console.WriteLine(ht.Kereses("C"));
            Console.WriteLine(ht["C"]);
            Console.WriteLine(ht.Kereses("N"));
            Console.WriteLine(ht.Kereses("NL"));
            Console.WriteLine(ht.Kereses("HON"));
            Console.WriteLine(ht.Kereses("F"));
            Console.WriteLine(ht.Kereses("SP"));
            Console.WriteLine(ht.Kereses("S"));

            
        }
    }
}