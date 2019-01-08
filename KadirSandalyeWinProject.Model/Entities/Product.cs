using KadirSandalyeWinProject.Model.Attributes;
using KadirSandalyeWinProject.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KadirSandalyeWinProject.Model.Entities
{
    public class Product : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }
        [Required, StringLength(100), ZorunluAlan("Ürün Adı", "txtUrunAdi")]
        public string ProductName { get; set; }
        [ZorunluAlan("Kategori Adı", "txtKategoriAdi")]
        public long CategoryId { get; set; }
        public decimal Price { get; set; }
        [StringLength(500)]
        public string Explanation { get; set; }
        public Category Category { get; set; }
    }
}
