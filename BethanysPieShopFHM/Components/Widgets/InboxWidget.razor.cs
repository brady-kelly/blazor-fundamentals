using BethanysPieShopFHM.State;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopFHM.Components.Widgets;

public partial class InboxWidget
{
    public int MessageCount { get; set; } = 0;
    
    [Inject]
    public ApplicationState _applicationState { get; set; }

    protected override void OnInitialized()
    {
        MessageCount = _applicationState.NumberOfMessages;
    }
}