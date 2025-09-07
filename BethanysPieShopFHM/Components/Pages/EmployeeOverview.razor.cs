using System.Collections.Generic;
using System.Threading.Tasks;
using BethanysPieShopFHM.Services;
using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopFHM.Components.Pages;

public partial class EmployeeOverview
{
    public List<Employee> Employees { get; set; } = new List<Employee>();

    protected override Task OnInitializedAsync()
    {
        Employees = MockDataService.Employees;
        return base.OnInitializedAsync();
    }
}