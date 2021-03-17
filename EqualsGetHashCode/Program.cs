using EqualsGetHashCode.Entities;
using System;

namespace EqualsGetHashCode
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Client client1 = new Client(name: "Joao", email: "maria@gmail.com");
                Client client2 = new Client(name: "Maria", email: "maria@gmail.com");

                Console.WriteLine(client1.Equals(client2));
                Console.WriteLine(client1 == client2);
                Console.WriteLine(client1.GetHashCode());
                Console.WriteLine(client2.GetHashCode());



            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


            Console.ReadKey();
        }
    }
}
