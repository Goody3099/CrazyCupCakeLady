using CrazyCupCakeLady.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrazyCupCakeLady.Repositories
{
    public interface IProductRepository
    {
        List<Products> GetAllProducts();
    }
}
