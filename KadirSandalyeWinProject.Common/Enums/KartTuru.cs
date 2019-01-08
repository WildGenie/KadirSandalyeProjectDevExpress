using System.ComponentModel;

namespace KadirSandalyeWinProject.Common.Enums
{
    public enum KartTuru:byte
    {
        [Description("Ürün Kartı")]
        Product =1,
        [Description("Kategori Kartı")]
        Category =2
    }
}
