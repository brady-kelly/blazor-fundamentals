namespace BethanysPieShopHRM.Shared.Domain;

public class TimeRegistration
{
    public int TimeRegistrationId { get; set; }
    public int EmployeeId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string? TaskDescription { get; set; }
}