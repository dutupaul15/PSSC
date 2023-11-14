using Exemple.Domain.Models;
using Exemple.Domain.Repository;
using LanguageExt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple.Data.Repositories
{
    public class OrdersRepository: IOrdersRepository
    {
        private readonly ProductsContext productsContext;

        public OrdersRepository(ProductsContext dBContext)
        {
            this.productsContext = dBContext;
        }

        public TryAsync<List<ValidatedProduct>> TryGetExistingOrders()
        {
            throw new NotImplementedException();
        }

        public TryAsync<Unit> TrySaveOrders(ProductOrder.ValidatedProductOrder order)
        {
            throw new NotImplementedException();
        }
    }
}
