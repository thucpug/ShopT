using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TedShop.Data.infrastructure;
using TeduShop.Model.Models;

namespace TedShop.Data.repositories
{
    
    public interface IProductRepository
    {
        IEnumerable<Product> GetByAlias(string alias);

    }
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(DbFactory dbFactory) : base(dbFactory)
        {

        }
        public IEnumerable<Product> GetByAlias(string alias)
        {
            return this.DbContext.products.Where(p => p.Name == alias);
        }
    }
}
