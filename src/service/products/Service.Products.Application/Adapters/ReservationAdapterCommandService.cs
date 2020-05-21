using Abp.Application.Services;

using System;
using System.Collections.Generic;
using System.Text;

using WiLSoft.Automation.RestourantManager.Module;

namespace Service.Products.Application.Adapters
{
    [RemoteService(IsEnabled = false)]
    public class ReservationAdapterCommandService : IReservationCommandAdapterService
    {
        public Service.Products.Model.Reservation CreateUpdate(ReservationDto model)
        {
            return new Model.Reservation(model.Title, model.PhoneNumber, model.People, model.ReservationDate, model.Description, model.CreationTime, model.CreatorUserId, model.LastModifierUserId, model.LastModificationTime, model.DeleterUserId, model.DeletionTime, model.IsDeleted, model.OrganizationUnitId);
        }
    }
}
