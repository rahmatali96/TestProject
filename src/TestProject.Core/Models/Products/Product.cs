using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace TestProject.Models.Products
{
    public class Product : Entity<int>
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
