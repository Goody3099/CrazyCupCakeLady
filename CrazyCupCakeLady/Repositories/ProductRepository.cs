using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using CrazyCupCakeLady.Models;

namespace CrazyCupCakeLady.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IConfiguration _config;
        public ProductRepository(IConfiguration config)
        {
            _config = config;
        }
        public SqlConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            }
        }
        public List<Products> GetAllProducts()
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @" SELECT *
                                         FROM Products";
                    SqlDataReader reader = cmd.ExecuteReader();

                    List<Products> products = new List<Products>();
                    while (reader.Read())
                    {
                        Products product = new Products
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Name = reader.GetString(reader.GetOrdinal("Name")),
                            Picture = reader.GetString(reader.GetOrdinal("Picture")),
                            Description = reader.GetString(reader.GetOrdinal("Description")),
                            Price = reader.GetInt32(reader.GetOrdinal("Price")),
                            HowManySold = reader.GetInt32(reader.GetOrdinal("HowManySold"))
                        };

                        products.Add(product);
                    }
                    reader.Close();
                    return products;
                }
            }
        }
    }
}
