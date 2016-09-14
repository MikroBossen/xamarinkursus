using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WeatherDesign
{
    class ProductServiceClient
    {
        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://firstbossapp.azurewebsites.net/");
                HttpResponseMessage response = await client.GetAsync("api/products");
                var products = await response.Content.ReadAsAsync<IEnumerable<Product>>();
                return products;
            }
        }

        public async Task<Product> GetProduct(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://firstbossapp.azurewebsites.net/");
                HttpResponseMessage response = await client.GetAsync("api/products/" + id);
                var product = await response.Content.ReadAsAsync<Product>();
                return product;
            }
        }
    }
}
