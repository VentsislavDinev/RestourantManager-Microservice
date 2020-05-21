using Abp.Application.Services;

using System;
using System.Collections.Generic;
using System.Text;

using WiLSoft.Automation.RestourantManager.Module;

namespace Service.Products.Application.Adapters
{
    [RemoteService(IsEnabled = false)]
    public class WaitListAdapterCommandService : ApplicationService, IWaitListAdapterCommandService
    {
        public Service.Products.Model.WaitList CreateUpdate(WaitListDto model)
        {
            return new Model.WaitList(model.Title, model.Image, model.Description, model.CreatorUserId, model.CreationTime, model.LastModifierUserId, model.LastModificationTime, model.DeleterUserId, model.DeletionTime, model.IsDeleted, model.OrganizationUnitId);
        }
    }
}
