using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using MPACore.PhoneBook.Controllers;
using MPACore.PhoneBook.PhoneBooks;
using MPACore.PhoneBook.Web.Models.Persons;

namespace MPACore.PhoneBook.Web.Controllers
{
    [AbpMvcAuthorize]
    public class PersonsController : PhoneBookControllerBase
    {
        private readonly IPersonAppService _personAppService;

        public PersonsController(IPersonAppService personAppService)
        {
            _personAppService = personAppService;
        }

        public async Task<ActionResult> Index(int skipCount = 0, int maxResultCount = 10)
        {
            var dtos = await _personAppService.GetPagedPersonAsync(new PhoneBooks.dtos.GetPersonInput
            {
                SkipCount = skipCount,
                MaxResultCount = maxResultCount
            });
            var model = new PersonListViewModel { Items = dtos.Items };
            return View(model);
        }
    }
}
