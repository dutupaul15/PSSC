using System;
using System.Collections.Generic;

using Comanda_L1;


class Program
{
    static void Main()
    {
        
        var contact = new Contact("Ghita", "Marcu", "0722345561", "strada Lebadei nr. 91");
        var products = new List<Product>
        {
            new Product(1, Quantity.InUnits(5)),
            new Product(2, Quantity.InKilograms(2.5)),
        };

        var order = new Order(contact, products);

        Console.WriteLine($"Comanda pentru: {order.Contact.FirstName} {order.Contact.LastName}");
        Console.WriteLine($"Telefon: {order.Contact.PhoneNumber}");
        Console.WriteLine($"Adresa: {order.Contact.Address}");
        Console.WriteLine("Produse:");
        foreach (var product in order.Products)
        {
            if (product.Quantity.Units != 0)
            {
                Console.WriteLine($"Cod produs: {product.ProductCode}, Cantitate: {product.Quantity.Units} unitati");
            }
            else if (product.Quantity.Kilograms != 0)
            {
                Console.WriteLine($"Cod produs: {product.ProductCode}, Cantitate: {product.Quantity.Kilograms} kilograme");
            }
           
        }
    }
}
