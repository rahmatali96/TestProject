using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Models.Products;

namespace TestProject.Services.Products.Dto
{
    [AutoMap(typeof(Product))]
    public class ProductDto : IEntityDto<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
