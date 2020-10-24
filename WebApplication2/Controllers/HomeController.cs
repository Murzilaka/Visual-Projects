using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        List<Phone> phones;
        public HomeController()
        {
            phones = new List<Phone>();
            phones.Add(new Phone { Id = 1, Model = "Samsung Galaxy III", Producer = "Samsung" });
            phones.Add(new Phone { Id = 2, Model = "Samsung Ace II", Producer = "Samsung" });
            phones.Add(new Phone { Id = 3, Model = "Samsung Ace II", Producer = "Samsung" });
            phones.Add(new Phone { Id = 4, Model = "Samsung Ace II", Producer = "Samsung" });
            phones.Add(new Phone { Id = 5, Model = "Samsung Ace II", Producer = "Samsung" });
            phones.Add(new Phone { Id = 6, Model = "Samsung Ace II", Producer = "Samsung" });
            phones.Add(new Phone { Id = 7, Model = "Samsung Ace II", Producer = "Samsung" });
            phones.Add(new Phone { Id = 8, Model = "Samsung Ace II", Producer = "Samsung" });
            phones.Add(new Phone { Id = 9, Model = "Samsung Ace II", Producer = "Samsung" });

        }
        public async Task<ActionResult> Index(int page = 1)
        {
            int pageSize = 3;
            IEnumerable<Phone> phonesperPage = phones.Skip((page - 1) * (pageSize)).Take(pageSize);
            PageInfo pageInfo = new PageInfo { PageNumber = page, PageSize = pageSize, TotalItems = phones.Count};
            IndexViewModel ivm = new IndexViewModel { PageInfo = pageInfo, Phones = phonesperPage };
            return View(ivm);
        }


      
    }
}