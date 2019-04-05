using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TedShop.Data.infrastructure
{
    public interface IDbFactory : IDisposable
    {
        ShopDbContext Init();
    }
}
