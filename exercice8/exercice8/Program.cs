using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdressageIP;

namespace exercice8
{
    class Program
    {
        static void Main(string[] args)
        {

            AdresseIP ip1, ip2, ip3;

            
            ip1 = AdresseIP.CreateAdresseIp(Console.ReadLine());
            ip2 = AdresseIP.CreateAdresseIp(Console.ReadLine());
            ip3 = AdresseIP.CreateAdresseIp(Console.ReadLine());

            bool memereseau = ip1.AppartientAuMemeReseau(ip2);
            bool memereseau1 = ip2.AppartientAuMemeReseau(ip3);

            do {

                Console.WriteLine("Veuillez saisir 3 adresses IP");
                ip1=AdresseIP.CreateAdresseIp(Console.ReadLine());

            }

                while(ip1.AppartientAuMemeReseau(ip2);


        }
    }
}
