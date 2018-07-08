using System.Collections.Generic;
using MPACore.PhoneBook.PhoneBooks.dtos;

namespace MPACore.PhoneBook.Web.Models.Persons
{
    public class PersonListViewModel
    {
        public IReadOnlyList<PersonListDto> Items { get; set; }
    }
}