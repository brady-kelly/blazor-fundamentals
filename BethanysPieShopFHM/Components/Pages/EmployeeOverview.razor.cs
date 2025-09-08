using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopFHM.Components.Pages;

public partial class EmployeeOverview
{
    public List<Employee>? Employees { get; set; }
    
    private Employee? _selectedEmployee;
    
    private string Title = "Employee Overview";

    protected override async Task OnInitializedAsync()
    {
        await Task.Delay(3000);
        Employees = MockDataService.Employees;
    }

    public void ShowQuickViewPopup(Employee selectedEmployee)
    {
        _selectedEmployee = selectedEmployee;
    }
}