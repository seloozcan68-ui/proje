using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proje.Data;
using proje.Models;

namespace proje.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobPostingsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public JobPostingsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/jobpostings
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var jobs = await _context.JobPostings
                .Include(j => j.Company)
                .ToListAsync();

            return Ok(jobs);
        }

        // POST: api/jobpostings
        [HttpPost]
        public async Task<IActionResult> Create(JobPosting job)
        {
            _context.JobPostings.Add(job);
            await _context.SaveChangesAsync();
            return Ok(job);
        }
    }
}
