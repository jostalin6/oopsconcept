using System;
using System.Collections.Generic;


namespace INKJOLEARN
{
    class Program
    {
        static void Main(string[] args)
        {

             PrimeUser primeUser = new PrimeUser()
            {
                id = 1,
                firstName="Prime",
                lastName="User",
                monthlyOffer=12
            };

            Console.WriteLine("****************");
            Console.WriteLine("PrimeUser Details");
            Console.WriteLine(primeUser.GetFullName());
            Console.WriteLine(primeUser.GetOffer());
            Console.WriteLine("****************");



            NonPrimeUser nonprimeUser = new NonPrimeUser()
            {
                id = 2,
                firstName = "Non Prime",
                lastName = "User",
                yearlyOffer = 6
            };

            Console.WriteLine("****************");
            Console.WriteLine("Non PrimeUser Details");
            Console.WriteLine(nonprimeUser.GetFullName());
            Console.WriteLine(nonprimeUser.GetOffer());
            Console.WriteLine("****************");

        }
    }
}
