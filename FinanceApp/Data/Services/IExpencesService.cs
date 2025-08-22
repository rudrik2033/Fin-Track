using FinanceApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinanceApp.Services
{
    public interface IExpencesService
    {
        Task<IEnumerable<Expences>> GetAllAsync();
        Task<Expences?> GetByIdAsync(int id);
        Task AddAsync(Expences expence);
        Task UpdateAsync(Expences expence);
        Task DeleteAsync(int id);
        Task<IEnumerable<object>> GetChartDataAsync();
    }
}
