using Abp.Application.Services.Dto;

namespace MyCompanyName.AbpZeroTemplate.Oppinion.Dtos
{
    public class GetAllForLookupTableInput : PagedAndSortedResultRequestDto
    {
		public string Filter { get; set; }
    }
}