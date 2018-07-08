using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace MPACore.PhoneBook.PhoneBooks.Persons
{
    
    public class Person:FullAuditedEntity
    {
        [Required]
        [MaxLength(PhoneBookConsts.MaxNameLength)]
        public string Name { get; set; }

        [EmailAddress]
        [MaxLength(PhoneBookConsts.MaxEmailLength)]
        public string Email { get; set; }

        [MaxLength(PhoneBookConsts.MaxAddressLength)]
        public string Address { get; set; }

    }
}
