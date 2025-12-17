using System;
using proje.Models;

namespace proje.Models
{
    public class JobPosting // iş ilanı bilgilerini tutar
    {
        public int Id { get; set; }
        public string Title { get; set; }  // İş ilanı başlığı
        public string Description { get; set; }  // İş ilanı açıklaması
        public string Location { get; set; }  // İş ilanı konumu
        public DateTime PostedDate { get; set; }  // İlanın yayınlanma tarihi

        public int CompanyId { get; set; }  // İlanın ait olduğu şirketin ID'si

        public Company Company { get; set; }  // İlanın ait olduğu şirket

    }
}
