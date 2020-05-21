using Abp.Application.Services;
using Abp.Domain.Repositories;

using System;
using System.Collections.Generic;
using System.Text;

using WiLSoft.Automation.RestourantManager;

namespace Service.Products.Application
{
    [RemoteService(IsEnabled = false)]
    public class MenuAdapterCommandService : ApplicationService, IMenuAdapterCommandService
    {
        public Service.Products.Model.Menu CreateUpdate(MenuDto model)
        {
            return new Service.Products.Model.Menu(model.Title, model.Image, model.Description, model.CreatorUserId, model.CreationTime, model.LastModifierUserId, model.LastModificationTime, model.DeleterUserId, model.DeletionTime, model.IsDeleted, model.OrganizationUnitId);
        }
    }
}
