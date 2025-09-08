using BethanysPieShopFHM.Components.Widgets;

namespace BethanysPieShopFHM.Components.Pages;

public partial class Home
{
    public List<Type> Widgets { get; set; } = [typeof(EmployeeCountWidget), typeof(InboxWidget)];
}