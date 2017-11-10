using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoTi
{
    public class ProductService
    {
        private const string url = "http://ticapacitacion.com/webapi";

        public async Task<List<Product>> GetAllProducts()
        {
            return await RestService.For<IHttpService>(url).Get();
        }
    }
}
