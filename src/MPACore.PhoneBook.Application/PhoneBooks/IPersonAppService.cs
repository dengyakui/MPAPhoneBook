using System;
using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MPACore.PhoneBook.PhoneBooks.dtos;

namespace MPACore.PhoneBook.PhoneBooks
{
    public interface IPersonAppService : IApplicationService
    {
        Task<PagedResultDto<PersonListDto>> GetPagedPersonAsync(GetPersonInput input);

        Task<PersonListDto> GetPersonByIdAsync(NullableIdDto input);

        /// <summary>
        /// 新增或更改
        /// </summary>
        /// <returns></returns>
        Task CreateOrUpdateAsync(CreateOrUpdatePersonInput input);


        Task DeletePersonAsync(EntityDto input);
    }
}
