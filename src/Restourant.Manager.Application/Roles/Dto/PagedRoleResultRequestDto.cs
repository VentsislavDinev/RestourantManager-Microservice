using Abp.Application.Services.Dto;

namespace Restourant.Manager.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

