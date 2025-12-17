using System.Collections.Generic;

namespace proje.Models
{
    public class Company // şirket bilgilerini tutar
    {
        public int Id { get; set; }
        public string Name { get; set; }   // Şirket adı
        public string Description { get; set; }  // Açıklama
        public string Location { get; set; }  // Şehir / Ülke
        public string Phone { get; set; }  // Telefon numarası
        public string Email { get; set; }  // E-posta adresi

        public ICollection<JobPosting>? JobPostings { get; set; } // Şirketin sahip olduğu iş ilanlarını tutan liste
    }
}
