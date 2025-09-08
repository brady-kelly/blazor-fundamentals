using BethanysPieShopFHM.State;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopFHM.Components;

public partial class InboxCounter : ComponentBase
{
    private int MessageCount = 0;
    
    [Inject]
    public ApplicationState _applicationState { get; set; }

    protected override void OnInitialized()
    {
        MessageCount = new Random().Next(1, 10);
        _applicationState.NumberOfMessages = MessageCount;
    }
}