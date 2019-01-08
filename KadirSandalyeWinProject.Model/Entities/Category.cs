using KadirSandalyeWinProject.Model.Attributes;
using KadirSandalyeWinProject.Model.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KadirSandalyeWinProject.Model.Entities
{
    public class Category : BaseEntityDurum
    {
        [Index("IX_Kod", IsUnique = true)]
        public override string Kod { get; set; }
        [Required, StringLength(100), ZorunluAlan("Kategori Adı", "txtUrunAdi")]
        public string CategoryName { get; set; }        
        [StringLength(500)]
        public string Explanation { get; set; }
    }
}
