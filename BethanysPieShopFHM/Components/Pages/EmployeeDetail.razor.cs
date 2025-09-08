using BethanysPieShopFHM.Contracts.Services;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.QuickGrid;
using Microsoft.AspNetCore.Components.Web.Virtualization;

namespace BethanysPieShopFHM.Components.Pages;

public partial class EmployeeDetail : ComponentBase
{
    protected IQueryable<TimeRegistration>? ItemsQueryable;
    protected int ItemsCount;
    
    [Parameter]
    public int EmployeeId { get; set; }

    public PaginationState Pagination = new() { ItemsPerPage = 10 };
    
    public Employee? Employee { get; set; } = new Employee();

    public List<TimeRegistration>? TimeRegistrations { get; set; } = [];

    [Inject]
    private IEmployeeDataService? _employeeDataService { get; set; }

    [Inject]
    private ITimeRegistrationService _timeRegistrationService { get; set; }

    private float itemHeight = 50;

    protected override async Task OnInitializedAsync()
    {
        ItemsQueryable = (await _timeRegistrationService.GetTimeRegistrationsForEmployee(EmployeeId)).AsQueryable();
        ItemsCount = ItemsQueryable.Count();
    }

    public async ValueTask<ItemsProviderResult<TimeRegistration>> LoadTimeRegistrations(ItemsProviderRequest request)
    {
        int totalNumberOfTimeRegistrations =
            await _timeRegistrationService.GetTimeRegistrationsCountForEmployee(EmployeeId);

        var numberOfTimeRegistrations = Math.Min(request.Count, totalNumberOfTimeRegistrations - request.StartIndex);

        var listItems = await
            _timeRegistrationService.GetPagedTimeRegistrationsForEmployee(EmployeeId, numberOfTimeRegistrations,
                request.StartIndex);

        return new ItemsProviderResult<TimeRegistration>(listItems, totalNumberOfTimeRegistrations);
    }

    public void ChangeHoliday()
    {
        Employee.IsOnHoliday = !Employee.IsOnHoliday;
    }
}