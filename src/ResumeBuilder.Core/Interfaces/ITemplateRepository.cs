using ResumeBuilder.Core.Entities;

namespace ResumeBuilder.Core.Interfaces
{
    public interface ITemplateRepository
    {
        Task<IEnumerable<Template>> GetAllAsync();
        Task<Template?> GetByIdAsync(Guid id);
        Task<Template> AddAsync(Template template);
        Task UpdateAsync(Template template);
        Task DeleteAsync(Guid id);
    }
}