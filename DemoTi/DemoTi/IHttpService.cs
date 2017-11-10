using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoTi
{
    public interface IHttpService
    {
        [Get("/northwind/products")]
        Task<List<Product>> Get();
    }
}
