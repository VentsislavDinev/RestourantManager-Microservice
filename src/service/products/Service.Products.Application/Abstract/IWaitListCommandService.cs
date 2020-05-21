﻿using System.Threading.Tasks;

using WiLSoft.Automation.RestourantManager.Module;

namespace WiLSoft.Automation.RestourantManager
{
    public interface IWaitListCommandService
    {
        Task Create(WaitListDto model);
        Task Delete(int id);
        Task Update(WaitListDto model);
    }
}