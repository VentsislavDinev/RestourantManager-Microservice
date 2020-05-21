using Abp.Application.Services;

using Domain.Employee.Model;

using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Employee.Application
{
    public class EmployeeAdapter : ApplicationService, IEmployeeAdapter
    {
        public Model.Employee CreateAndUpdate(EmployeeEntity model)
        {
            return new Model.Employee(model.Name, model.LastName, model.PhoneNumber, model.Address, model.Email, model.Possition, model.CreatorUserId, model.CreationTime, model.LastModifierUserId, model.LastModificationTime, model.DeleterUserId, model.DeletionTime, model.IsDeleted, model.OrganizationUnitId);
        }


    }
}
