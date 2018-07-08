using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MPACore.PhoneBook.PhoneBooks.Persons;

namespace MPACore.PhoneBook.PhoneBooks.dtos
{
    [AutoMapTo(typeof(Person))]
    public class PersonEditDto
    {
        public int? Id { get; set; }
        public string Name { get; set; }


        public string Email { get; set; }


        public string Address { get; set; }
    }
}