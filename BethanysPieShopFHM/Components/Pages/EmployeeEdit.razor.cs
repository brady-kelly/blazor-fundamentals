using BethanysPieShopFHM.Contracts.Services;
using BethanysPieShopHRM.Contracts.Services;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopFHM.Components.Pages;

public partial class EmployeeEdit : ComponentBase
{
    [Inject]
    public IEmployeeDataService? EmployeeDataService { get; set; }

    [Inject]
    public ICountryDataService? CountryDataService { get; set; }

    [Inject]
    public IJobCategoryDataService? JobCategoryDataService { get; set; }

    [Inject]
    public NavigationManager NavigationManager { get; set; }
    
    [Parameter]
    public int EmployeeId { get; set; }

    [SupplyParameterFromForm]
    public Employee Employee { get; set; } = new();

    public List<Country> Countries { get; set; } = [];
    public List<JobCategory> JobCategories { get; set; } = [];

    protected bool IsSaved;
    protected string Message = string.Empty;
    protected string StatusClass = string.Empty;

    protected override async Task OnInitializedAsync()
    {
        IsSaved = false;
        Countries = (await CountryDataService.GetAllCountries()).ToList();
        JobCategories = (await JobCategoryDataService.GetAllJobCategories()).ToList();

        Employee = await EmployeeDataService.GetEmployeeById(EmployeeId);
    }

    protected async Task HandleValidSubmit()
    {
        await EmployeeDataService.UpdateEmployee(Employee);
        IsSaved = true;
        StatusClass = "alert-success";
        Message = "Employee updated";
    }

    protected void HandleInvalidSubmit()
    {
        StatusClass = "alert-danger";
        Message = "Employee update failed";
    }

    protected async Task DeleteEmployee()
    {
        await EmployeeDataService.DeleteEmployee(Employee.EmployeeId);
        StatusClass = "alert-success";
        Message = "Employee deleted";
        
        IsSaved = true;
    }

    protected void NavigateToOverview()
    {
        NavigationManager.NavigateTo("/employeeoverview");
    }
}