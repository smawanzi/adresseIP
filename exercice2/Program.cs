using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdressageIP;

namespace exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
            AdresseIP Ip1;
            Ip1 = AdresseIP.CreateAdresseIp("172.10.15.17");

            AdresseIP masque = Ip1.Masque();
            string masqueEnString = masque.AdresseIpBinaire();
            Console.WriteLine("{0}", masqueEnString);

            AdresseIP reseau = AdresseIP.CreateAdresseIp(Ip1.AdresseReseau());
            
            Console.WriteLine("{0}",AdresseIP.CreateAdresseIp(Ip1.AdresseReseau()).AdresseIpBinaire());
            Console.WriteLine("{0}",Ip1.Masque().AdresseIpBinaire());
            Console.WriteLine(Ip1.AdresseIpBinaire());
            Console.ReadLine();


        }
    }
}
