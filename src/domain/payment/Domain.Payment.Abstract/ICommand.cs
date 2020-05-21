using Abp.Application.Services;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Payment.Abstract
{
    public interface ICommand<T> : IApplicationService where T : class
    {
        Task<T> Create<Model>(Model model) where Model : class;
        Task<T> Update<Model>(Model model) where Model : class;
        Task<T> Delete<Model>(Model model) where Model : class;
    }
}
