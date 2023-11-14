using Exemple.Domain.Models;
using LanguageExt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exemple.Domain.Repository
{
    public interface IProductsRepository
    {
        Task<List<ProductCode>> TryGetExistingProductCodes();

        Task<Quantity> TryGetQuantityForProduct(ProductCode code);

        Task<Price> TryGetPrice(ProductCode code);
    }
}
