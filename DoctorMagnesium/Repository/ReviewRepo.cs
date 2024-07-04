using DoctorMagnesium.Data;
using DoctorMagnesium.Interface;
using DoctorMagnesium.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorMagnesium.Repository
{
    public class ReviewRepo : IReview
    {
        private readonly ApplicationDbContext _context;
        public ReviewRepo(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }
        public async Task<Review> CreateAsync(Review reviewModel)
        {
            await _context.Reviews.AddAsync(reviewModel);
            await _context.SaveChangesAsync();
            return reviewModel;
        }

        public async Task<Review?> DeleteAsync(int id)
        {
            var reviewModel = await _context.Reviews.FirstOrDefaultAsync(x => x.Id == id);
            if (reviewModel == null)
            {
                return null;
            }
            _context.Reviews.Remove(reviewModel);
            await _context.SaveChangesAsync();
            return reviewModel;
        }

        public async Task<List<Review>> GetAllAsync()
        {
            return await _context.Reviews.ToListAsync();
        }

        public async Task<Review?> GetByIdAsync(int id)
        {
            return await _context.Reviews.FindAsync(id);
        }

        public async Task<Review?> UpdateAsync(int id, Review reviewModel)
        {
            var existingReview = await _context.Reviews.FindAsync(id);
            if (existingReview == null)
            {
                return null;
            }
            existingReview.Title = reviewModel.Title;
            existingReview.Content = reviewModel.Content;

            await _context.SaveChangesAsync();
            return existingReview;
        }
    }


    }

