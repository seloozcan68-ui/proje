using System;
using proje.Models;

namespace proje.Models
{
    public class JobApplication // (many to many ilişki)
    {
        public int Id { get; set; }

        public int CandidateId { get; set; }  // Başvuruyu yapan adayın ID'si
        public Candidate Candidate { get; set; }  // Başvuruyu yapan adayın bilgisini candidate dosyasından alıyoruz

        public int JobPostingId { get; set; }  // Başvurulan iş ilanının ID'si
        public JobPosting JobPosting { get; set; }  // Başvurulan iş ilanını jobposting dosyasından alıyoruz

        public DateTime ApplicationDate { get; set; }  // Başvuru tarihi
        public string Status { get; set; }  // Başvuru durumu (reddedildi, kabul edildi)
    }
}
