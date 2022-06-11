
using Abp.Application.Services;
using Abp.Domain.Repositories;
using System.Threading.Tasks;
using TestProject.Models.Products;
using TestProject.Services.Products.Dto;

namespace TestProject.Services.Products
{
    public class ProductAppService : CrudAppService<Product, ProductDto>
    {
        private readonly IRepository<Product, int> _repository;

        public ProductAppService(IRepository<Product, int> repository):base(repository)
        {
            _repository = repository;
        }
    }
}
