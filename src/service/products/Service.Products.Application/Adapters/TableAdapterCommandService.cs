using Abp.Application.Services;

using System;
using System.Collections.Generic;
using System.Text;

using WiLSoft.Automation.RestourantManager.Module;

namespace Service.Products.Application.Adapters
{
    [RemoteService(IsEnabled = false)]
    public class TableAdapterCommandService : ApplicationService, ITableAdapterCommandService
    {
        public Service.Products.Model.Table CreateUpdate(TableDto model)
        {
            return new Model.Table(model.Title, model.Image, model.Description, model.CreatorUserId, model.CreationTime, model.LastModifierUserId, model.LastModificationTime, model.DeleterUserId, model.DeletionTime, model.IsDeleted, model.OrganizationUnitId);
        }
    }
}
