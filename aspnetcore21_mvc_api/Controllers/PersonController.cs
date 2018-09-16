using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnetcore21_mvc_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcore21_mvc_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        [Route("person")]
        public ActionResult<List<Person>> FindPerson()
        {
            return new List<Person>() { new Person() { Alder = 10, Navn = "a" } };
        }

        [HttpGet]
        [Route("person/{id}")]
        public ActionResult<Person> FindPersoner(int id)
        {
            return new Person() { Alder = 10, Navn = "a" };
        }

        public ActionResult Patch(int id, [FromBody] JsonPatchDocument<Person> patch)
        {
            try
            {
                var p = new Person() { Alder = 10, Navn = "a" };
                patch.ApplyTo(p);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}