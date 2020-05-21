using Abp.Application.Services;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Reporting.Abstract
{
    public interface IQuery<TSecond, T> : IApplicationService where T : class where TSecond : class
    {
        Task<T> Get<Model>(Model model) where Model : class;
        Task<TSecond> GetAll<Model>(Model model) where Model : class;
    }
}
