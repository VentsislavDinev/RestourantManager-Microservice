using Abp.Application.Services;

using WiLSoft.Automation.RestourantManager;

namespace Orchistrator.Products.Internal.Service.Senders
{
    public interface IMenuSender : IApplicationService
    {
        void SendWaitList(MenuDto customer);
    }
}