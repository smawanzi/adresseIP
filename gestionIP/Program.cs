using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdressageIP;

namespace Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            AdresseIP IpA;
            AdresseIP IpB;
            AdresseIP IpC;

            IpA = AdresseIP.CreateAdresseIp("192.1.1.0");
            IpB = AdresseIP.CreateAdresseIp("172.64.20.1");
            IpC = AdresseIP.CreateAdresseIp(192, 0 ,0 ,0);

            

            // Adresse A
            
            Console.WriteLine("affiche l'adresse IpA");
            Console.WriteLine(IpA.AdresseIpBinaire());
            Console.WriteLine(IpA.ToString());
            Console.WriteLine(IpA.ClasseReseau());
            Console.WriteLine(IpA.Masque());
            IpA.GetOctet1();
            IpA.GetOctet2();
            IpA.GetOctet3();
            IpA.GetOctet4();
            

            // Adresse B
            
            Console.WriteLine("affiche l'adresse IpB");
            Console.WriteLine(IpB.AdresseIpBinaire());
            Console.WriteLine(IpB.ToString());
            Console.WriteLine(IpB.ClasseReseau());
            Console.WriteLine(IpB.Masque());
            IpB.GetOctet1();
            IpB.GetOctet2();
            IpB.GetOctet3();
            IpB.GetOctet4();
           

            // Adresse C
            
            Console.WriteLine("affiche l'adresse IpC");
            Console.WriteLine(IpC.AdresseIpBinaire());
            Console.WriteLine(IpC.ToString());
            Console.WriteLine(IpC.ClasseReseau());
            IpC.GetOctet1();
            IpC.GetOctet2();
            IpC.GetOctet3();
            IpC.GetOctet4();
            Console.ReadLine();

        }
    }
}
