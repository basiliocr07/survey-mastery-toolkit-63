
using SurveyApp.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SurveyApp.Domain.Repositories
{
    public interface ISurveyRepository
    {
        Task<IEnumerable<Survey>> GetAllAsync();
        Task<Survey?> GetByIdAsync(int id);
        Task<bool> AddAsync(Survey survey);
        Task<bool> UpdateAsync(Survey survey);
        Task<bool> DeleteAsync(int id);
    }
}
