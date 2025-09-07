using System.Collections.Generic;
using System.Threading.Tasks;
using BethanysPieShopFHM.Services;
using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopFHM.Components.Pages;

public partial class EmployeeOverview
{
    public List<Employee>? Employees { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await Task.Delay(3000);
        Employees = MockDataService.Employees;
    }
}