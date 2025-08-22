using FinanceApp.Data;
using FinanceApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinanceApp.Services
{
    public class ExpencesService : IExpencesService
    {
        private readonly FinanceAppContext _context;

        public ExpencesService(FinanceAppContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Expences>> GetAllAsync()
        {
            return await _context.Expences.ToListAsync();
        }

        public async Task<Expences?> GetByIdAsync(int id)
        {
            return await _context.Expences.FindAsync(id);
        }

        public async Task AddAsync(Expences expence)
        {
            _context.Expences.Add(expence);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Expences expence)
        {
            _context.Expences.Update(expence);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var expence = await _context.Expences.FindAsync(id);
            if (expence != null)
            {
                _context.Expences.Remove(expence);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<object>> GetChartDataAsync()
        {
            return await _context.Expences
                .GroupBy(e => e.Category)
                .Select(g => new
                {
                    category = g.Key,
                    total = g.Sum(e => e.Amount)
                })
                .ToListAsync<object>();
        }
    }
}
