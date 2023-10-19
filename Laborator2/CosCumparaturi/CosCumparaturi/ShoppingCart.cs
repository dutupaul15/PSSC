using CSharp.Choices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosCumparaturi
{
    [AsChoice]
    public static partial class ShoppingCart
    {
        public interface IShoppingCart { }
        public record EmptyShoppingCart(IReadOnlyCollection<UnvalidatedCart> ProductsList) : IShoppingCart;

        public record InvalidatedShoppingCart(IReadOnlyCollection<UnvalidatedCart> ProductsList, string reason) : IShoppingCart;

        public record ValidatedShoppingCart(IReadOnlyCollection<ValidatedCart> ProductsList) : IShoppingCart;

        public record PublishedShoppingCart(IReadOnlyCollection<ValidatedCart> ProductsList, DateTime PublishedDate) : IShoppingCart;
    }
}
