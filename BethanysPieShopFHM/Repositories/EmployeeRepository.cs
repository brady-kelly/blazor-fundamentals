using BethanysPieShopFHM.Contracts.Repositories;
using BethanysPieShopFHM.Data;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShopFHM.Repositories;

public class EmployeeRepository:  IEmployeeRepository, IDisposable
{
    private readonly AppDbContext _appDbContext;

    public EmployeeRepository(IDbContextFactory<AppDbContext> appDbContextFactory)
    {
        _appDbContext = appDbContextFactory.CreateDbContext();
    }

    public void Dispose()
    {
        _appDbContext.Dispose();
    }
    
    public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
    {
        return await _appDbContext.Employees.ToListAsync();
    }

    public async Task<Employee?> GetEmployeeByIdAsync(int employeeId)
    {
        return await _appDbContext.Employees.FirstOrDefaultAsync(e => e.EmployeeId == employeeId);
    }
}