using BethanysPieShopFHM.Contracts.Repositories;
using BethanysPieShopFHM.Data;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShopFHM.Repositories;

public class EmployeeRepository:  IEmployeeRepository
{
    private readonly AppDbContext _appDbContext;

    public EmployeeRepository(IDbContextFactory<AppDbContext> appDbContextFactory)
    {
        _appDbContext = appDbContextFactory.CreateDbContext();
    }
    
    public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<Employee> GetEmployeeByIdAsync(int employeeId)
    {
        throw new NotImplementedException();
    }
}