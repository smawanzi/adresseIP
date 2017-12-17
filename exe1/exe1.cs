using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdressageIP;

namespace exe1
{
    class exe1
    {
        static void Main(string[] args)
        {
            AdresseIP ip1, ip2, ip3;

            //instanciation création d'un objet

            ip1 = AdresseIP.CreateAdresseIp("0.0.0.0");
            ip2 = AdresseIP.CreateAdresseIp("128.0.0.0");
            ip3 = AdresseIP.CreateAdresseIp("192.0.0.0");

            Console.WriteLine("afficher les adresses IP");
            //accessuers get
            ip1.GetOctet1(); ip1.GetOctet2(); ip1.GetOctet3(); ip1.GetOctet4();
            ip2.GetOctet1(); ip2.GetOctet2(); ip2.GetOctet3(); ip2.GetOctet4();
            ip3.GetOctet1(); ip3.GetOctet2(); ip3.GetOctet3(); ip3.GetOctet4();
            //méthode toString
            Console.WriteLine(ip1.ToString());
            Console.WriteLine(ip2.ToString());
            Console.WriteLine(ip3.ToString());
            //classe et masque
            Console.WriteLine(ip1.ClasseReseau());
            Console.WriteLine(ip1.Masque());
            Console.WriteLine(ip2.ClasseReseau());
            Console.WriteLine(ip2.Masque());
            Console.WriteLine(ip3.ClasseReseau());
            Console.WriteLine(ip3.Masque());
            //adresseIP binaire
            Console.WriteLine(ip1.AdresseIpBinaire());
            Console.WriteLine(ip2.AdresseIpBinaire());
            Console.WriteLine(ip3.AdresseIpBinaire());

            Console.ReadLine();
        }
    }
}
