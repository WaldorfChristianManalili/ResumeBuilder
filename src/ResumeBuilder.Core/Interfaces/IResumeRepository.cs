using ResumeBuilder.Core.Entities;

namespace ResumeBuilder.Core.Interfaces
{
    public interface IResumeRepository
    {
        Task<IEnumerable<Resume>> GetAllAsync();
        Task<Resume?> GetByIdAsync(Guid id);
        Task<IEnumerable<Resume>> GetByUserIdAsync(Guid userId);
        Task<Resume> AddAsync(Resume resume);
        Task UpdateAsync(Resume resume);
        Task DeleteAsync(Guid id);
    }
}