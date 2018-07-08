using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MPACore.PhoneBook.PhoneBooks.Persons;

namespace MPACore.PhoneBook.PhoneBooks.dtos
{
    [AutoMapFrom(typeof(Person))]
    public class PersonListDto:FullAuditedEntityDto
    {
       
        public string Name { get; set; }

      
        public string Email { get; set; }

      
        public string Address { get; set; }
    }
}
