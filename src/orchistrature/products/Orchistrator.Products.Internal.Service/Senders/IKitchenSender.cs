using Abp.Application.Services;

using WiLSoft.Automation.RestourantManager.Module;

namespace Orchistrator.Products.Internal.Service.Senders
{
    public interface IKitchenSender : IApplicationService
    {
        void SendWaitList(KitchenDto customer);
    }
}