using RestService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestService.Controllers
{
    public class PetController : ApiController
    {
        [HttpGet]
        public IEnumerable<Cat> Get()
        {
            return Cat.getCats();
        }
    }
}
