using System;

namespace KadirSandalyeWinProject.Model.Attributes
{
    public class Kod:Attribute
    {
        public string Description { get; }
        public string ControlName { get; }
        /// <summary>
        /// Doğrulama İşlemleri sırasında zorunlu olan alanları işaretlemek için kullanılacak.
        /// </summary>
        /// <param name="description">Uyarı mesajında gösterilecek olan açıklama</param>
        /// <param name="controlName">Uyarı mesajı sonrası odaklanılacak control adı</param>
        public Kod(string description, string controlName)
        {
            Description = description;
            ControlName = controlName;
        }
    }
}
