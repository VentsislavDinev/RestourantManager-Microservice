using Abp.Application.Services;

using System;
using System.Collections.Generic;
using System.Text;

using WiLSoft.Automation.RestourantManager.Module;

namespace Service.Products.Application
{
    [RemoteService(IsEnabled = false)]
    public class ProductCommandAdapterService : ApplicationService, IProductCommandAdapterService
    {
        public Service.Products.Model.Product CreateUpdate(ProductsDto model)
        {
            return new Service.Products.Model.Product(model.Title, model.Image, model.Description, model.OrganizationUnitId, model.CreatorUserId, model.CreationTime, model.LastModifierUserId, model.LastModificationTime, model.DeleterUserId, model.DeletionTime, model.IsDeleted);
        }
    }
}
