using System.ComponentModel.Design;
using System.Threading.Channels;

namespace Esimene_projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///* näiteprogramm */
            //int palk = 2465;
            //int kulud = 1452;

            //Console.WriteLine("Kas see kuu kulusid või väljaminekuid oli? jah/ei");
            //string kasutajaVastus = "";
            //kasutajaVastus = Console.ReadLine();
            //if (kasutajaVastus == "jah")
            //{
            //    Console.WriteLine("sisesta kõik oma kulutused ühe arvuna");
            //    kulud = int.Parse(Console.ReadLine());
            //}

            //int kontojääk = palk - kulud;
            //    Console.WriteLine(kontojääk + " puulehtede jääk");
            //    Console.WriteLine("sisestage oma hästi tehtud töö boonus");
            //int boonus = int.Parse(Console.ReadLine());
            //kontojääk = kontojääk + boonus;
            //    Console.WriteLine("minu lõppväljavõte on: " + kontojääk + " puulehte");

            //// andmetüübid
            //string tekst = "mingi loetav tekst";
            //char täht = 'a';
            //int arv = 1;
            //float komakohaga = 2.5f; //32bit
            //double suuremkomakohaga = 1.5d; //64bit
            //decimal kümnendsüsteemikomakohaga = 1.5M;
            //var x = 123; //umbmäärane andmetüübiga ajutine muutuja
            //var y = "tekst";
            //bool yesorno = false; //true or false

            ////string string = "abc"; //bad
            //string sõna = "abc"; //very gud

            //Programm 2
            Console.WriteLine("Tere tulemast baari, palun sisestage oma vanus");
            int vanus;
            vanus = int.Parse(Console.ReadLine());
            if (vanus >= 18)
            {
                Console.WriteLine("Tere, nautige meie mojitot 🍋‍");
            }
            else
            {
                Console.WriteLine("Vabandust, alaealisi sisse ei lasta, head päeva");
            }
        }
    }
}
