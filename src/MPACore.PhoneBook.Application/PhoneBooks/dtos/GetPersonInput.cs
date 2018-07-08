using System;
using System.Collections.Generic;
using System.Text;
using Abp.Runtime.Validation;
using MPACore.PhoneBook.Dto;

namespace MPACore.PhoneBook.PhoneBooks.dtos
{
    public class GetPersonInput:PagedAndSortedInputDto,IShouldNormalize
    {
        public string FilterText { get; set; }


        /// <summary>
        /// 指定默认行为,例如默认的排序字段
        /// </summary>
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
        }
    }
}
