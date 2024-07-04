using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DoctorMagnesium.Data;
using DoctorMagnesium.Models;
using DoctorMagnesium.DTOs.ReviewDTOs;
using DoctorMagnesium.Mappers;
using DoctorMagnesium.Interface;

namespace DoctorMagnesium.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IReview _reviewRepo;
        
        public ReviewsController(ApplicationDbContext context, IReview reviewRepo)
        {
            _context = context;
            _reviewRepo = reviewRepo;
        }

        // GET: api/Reviews
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var reviews = await _reviewRepo.GetAllAsync();

            var reviewDto = reviews.Select(s => s.ToReviewDTO());

            return Ok(reviewDto);
        }

        // GET: api/Reviews/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Review>> GetReview(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var review = await _reviewRepo.GetByIdAsync(id);
            if (review == null)
            {
                return NotFound();
            }
            return Ok(review.ToReviewDTO());
        }

        // PUT: api/Reviews/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReview([FromRoute] int id, [FromBody] UpdateReviewRequestDTO updateDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var review = await _reviewRepo.UpdateAsync(id, updateDto.ToReviewFromUpdate());
            if (review == null)
            {
                NotFound("Review not found!");
            }
            return Ok(review.ToReviewDTO());
        }

        // POST: api/Reviews
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("{userId:int}")]
        public async Task<ActionResult<Review>> PostReview([FromRoute] int userId, CreateReviewRequestDTO reviewDto)
        {
            var reviewModel = reviewDto.ToStockFromCreateReview(userId);
            await _reviewRepo.CreateAsync(reviewModel);
            return CreatedAtAction(nameof(GetReview), new { id = reviewModel.Id }, reviewModel.ToReviewDTO());
        }


        // DELETE: api/Reviews/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReview(int id)
        {
            var review = await _context.Reviews.FindAsync(id);
            if (review == null)
            {
                return NotFound();
            }

            _context.Reviews.Remove(review);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ReviewExists(int id)
        {
            return _context.Reviews.Any(e => e.Id == id);
        }
    }
}
