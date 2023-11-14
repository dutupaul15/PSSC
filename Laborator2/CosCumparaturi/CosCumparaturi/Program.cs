using System;
using System.Collections.Generic;
using static CosCumparaturi.ShoppingCart;

namespace CosCumparaturi
{
    class Program
    {
        private static readonly Random random = new();
        static void Main(string[] args)
        {
            var listofClients = ReadListOfClients().ToArray();
            EmptyShoppingCart unvalidatedCart = new(listofClients);
            IShoppingCart result = ValidateCart(unvalidatedCart);
            result.Match(
                whenEmptyShoppingCart: unvalidatedResult => unvalidatedCart,
                whenPurchasedShoppingCart: publishedResult => publishedResult,
                whenInvalidatedShoppingCart: invalidResult => invalidResult,
                whenValidatedShoppingCart: validatedResult => PurchasedShoppingCart(validatedResult)
            );

            Console.WriteLine("Iesire din program");
        }
        private static List<UnvalidatedCart> ReadListOfClients()
        {
            List<UnvalidatedCart> listOfClients = new();
            do
            {
                //read client with command
                var id = ReadValue("Client ID: ");
                if (string.IsNullOrEmpty(id))
                {
                    break;
                }
                var name = ReadValue("Name: ");
                if (string.IsNullOrEmpty(name))
                {
                    break;
                }
                var code = ReadValue("Code: ");
                if (string.IsNullOrEmpty(code))
                {
                    break;
                }
                var address = ReadValue("Address: ");
                if (string.IsNullOrEmpty(address))
                {
                    break;
                }
                Console.Write("Quantity: ");
                int quantity = (int)Convert.ToInt64(Console.ReadLine());
                if (int.IsNegative(quantity) || quantity == 0 )
                {
                    break;
                }

                listOfClients.Add(new(name, id, address, code, quantity));
            } while (true);
            Console.Write("Numarul de clienti ai magazinul este: ");
            Console.WriteLine(listOfClients.Count);
            return listOfClients;
        }
        private static IShoppingCart ValidateCart(EmptyShoppingCart emptyCart) =>
          random.Next(100) > 50 ?
          new InvalidatedShoppingCart(new List<UnvalidatedCart>(), "Random errror")
          : new ValidatedShoppingCart(new List<ValidatedCart>());

        private static IShoppingCart PurchasedShoppingCart(ValidatedShoppingCart validCart)
        {

            if (validCart == null) { Console.WriteLine("validCart is null"); };
            Console.WriteLine(validCart);
            return new PurchasedShoppingCart(new List<ValidatedCart>(), DateTime.Now);
        }
            

        private static string? ReadValue(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }
}


