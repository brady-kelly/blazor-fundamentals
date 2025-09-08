﻿using BethanysPieShopFHM.Contracts.Services;
using BethanysPieShopHRM.Contracts.Repositories;
using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopFHM.Services;

public class TimeRegistrationService : ITimeRegistrationService
{
    private readonly ITimeRegistrationRepository _timeRegistrationRepository;

    public TimeRegistrationService(ITimeRegistrationRepository timeRegistrationRepository)
    {
        _timeRegistrationRepository = timeRegistrationRepository;
    }

    public async Task<List<TimeRegistration>> GetTimeRegistrationsForEmployee(int employeeId)
    {
        return await _timeRegistrationRepository.GetTimeRegistrationsForEmployee(employeeId);
    }

    public async Task<List<TimeRegistration>> GetPagedTimeRegistrationsForEmployee(int employeeId, int pageSize, int start)
    {
        return await _timeRegistrationRepository.GetPagedTimeRegistrationsForEmployee(employeeId, pageSize, start);
    }

    public async Task<int> GetTimeRegistrationsCountForEmployee(int employeeId)
    {
        return await _timeRegistrationRepository.GetTimeRegistrationsCountForEmployee(employeeId);
    }
}