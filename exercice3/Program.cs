using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdressageIP;

namespace exercice3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("veuillez saisir les quatres octets");
            AdresseIP IP1;
            IP1 = AdresseIP.CreateAdresseIp("192.1.0.0");
            
            AdresseIP masque = IP1.Masque();
            string masqueEnString = masque.AdresseIpBinaire();
            Console.WriteLine("{0}", masqueEnString);
            Console.ReadLine();
            
            IP1.GetOctet1();
            IP1.GetOctet2();
            IP1.GetOctet3();
            IP1.GetOctet4();
        
            Console.ReadLine();
        }
    }
}
