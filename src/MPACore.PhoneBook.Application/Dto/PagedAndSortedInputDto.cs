using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;

namespace MPACore.PhoneBook.Dto
{
    public class PagedAndSortedInputDto:IPagedAndSortedResultRequest
    {
        [Range(1,500)]
        public int MaxResultCount { get; set; }

        [Range(0,int.MaxValue)]
        public int SkipCount { get; set; }

        public string Sorting { get; set; }
    }
}