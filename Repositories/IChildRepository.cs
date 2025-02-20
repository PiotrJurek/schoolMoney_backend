using schoolMoney_backend.Models;

namespace schoolMoney_backend.Repositories;

public interface IChildRepository
{
    public Task<bool> SaveChangesAsync();

    public Task AddEntityAsync<T>(T entity);
    public void UpdateEntity<T>(T entity);
    public void DeleteEntity<T>(T entity);
    
    public Task<Child?> GetChildByIdAsync(string childId);
}