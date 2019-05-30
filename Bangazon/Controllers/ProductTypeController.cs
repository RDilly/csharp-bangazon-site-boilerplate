using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Bangazon.Models;
using Bangazon.Models.ProductViewModels;
using System.Data.SqlClient;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bangazon.Controllers
{
    public class ProductTypeController : Controller
    {
        // GET: /<controller>/
        private readonly IConfiguration _config;

        public ProductTypeController(IConfiguration config)
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
        // GET: Students
        public ActionResult Index()
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                            SELECT s.ProductTypeId,
                                s.Label,
                            FROM ProductType s
                        ";
                    SqlDataReader reader = cmd.ExecuteReader();

                    List<ProductType> productTypes = new List<ProductType>();
                    while (reader.Read())
                    {
                        ProductType productType = new ProductType
                        {
                            ProductTypeId = reader.GetInt32(reader.GetOrdinal("Id")),
                            Label = reader.GetString(reader.GetOrdinal("Label")),
                        };

                        productTypes.Add(productType);
                    }

                    reader.Close();
                    return View(productTypes);

                }
            }
        }
    }
}