using Abp.Application.Services;

using System;
using System.Collections.Generic;
using System.Text;

using WiLSoft.Automation.RestourantManager.Module;

namespace Service.Products.Application
{
    [RemoteService(IsEnabled = false)]
    public class KitchenAdapterCommandService : ApplicationService, IKitchenAdapterCommandService
    {
        public Model.Kitchen CreateUpdate(KitchenDto model)
        {
            return new Model.Kitchen(model.Title, model.Image, model.Description, model.OrganizationUnitId, model.IsDeleted, model.CreatorUserId, model.CreationTime, model.LastModifierUserId, model.LastModificationTime, model.DeleterUserId, model.DeletionTime);
        }
    }
}
