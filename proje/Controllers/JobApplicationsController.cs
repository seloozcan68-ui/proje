using Microsoft.AspNetCore.Builder;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proje.Data;
using proje.Models;

namespace proje.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobApplicationsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public JobApplicationsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/jobapplications
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var applications = await _context.JobApplications
                .Include(a => a.Candidate)
                .Include(a => a.JobPosting)
                .ToListAsync();

            return Ok(applications);
        }

        // POST: api/jobapplications
        [HttpPost]
        public async Task<IActionResult> Create(JobApplication application)
        {
            _context.JobApplications.Add(application);
            await _context.SaveChangesAsync();
            return Ok(application);
        }
    }
}
