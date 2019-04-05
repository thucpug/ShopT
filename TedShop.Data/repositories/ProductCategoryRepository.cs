using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TedShop.Data.infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.repositories
{
    public interface IProductCategoryRepository
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);

    }
    public class ProductCategoryRepository : RepositoryBase<ProductCategory> , IProductCategoryRepository
    {
        public ProductCategoryRepository(DbFactory dbFactory) : base(dbFactory)
        {

        }
       public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.productCategories.Where(p => p.Alias == alias);
        }
    }
}