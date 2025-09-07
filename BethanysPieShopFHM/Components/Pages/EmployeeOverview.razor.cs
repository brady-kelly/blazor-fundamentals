using System.Collections.Generic;
using System.Threading.Tasks;
using BethanysPieShopFHM.Services;
using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopFHM.Components.Pages;

public partial class EmployeeOverview
{
    public EmployeeOverview()
    {
        Employees = MockDataService.Employees;
    }
    
    public List<Employee> Employees { get; set; }
}