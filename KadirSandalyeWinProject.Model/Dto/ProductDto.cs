using KadirSandalyeWinProject.Model.Entities;
using KadirSandalyeWinProject.Model.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace KadirSandalyeWinProject.Model.Dto
{
    [NotMapped]
    public class ProductS : Product
    {
        public string CategoryName { get; set; }
    }
    public class ProductL : BaseEntity
    {
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public decimal Price { get; set; }
        public string Explanation { get; set; }
    }
}
