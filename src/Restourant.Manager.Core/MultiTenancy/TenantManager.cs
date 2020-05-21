using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using Restourant.Manager.Authorization.Users;
using Restourant.Manager.Editions;

namespace Restourant.Manager.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
