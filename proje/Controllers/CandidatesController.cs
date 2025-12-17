using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proje.Data;
using proje.Models;

namespace proje.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CandidatesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CandidatesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/candidates
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var candidates = await _context.Candidates.ToListAsync();
            return Ok(candidates);
        }

        // POST: api/candidates
        [HttpPost]
        public async Task<IActionResult> Create(Candidate candidate)
        {
            _context.Candidates.Add(candidate);
            await _context.SaveChangesAsync();
            return Ok(candidate);
        }
    }
}
