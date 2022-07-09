using Microsoft.AspNetCore.Mvc;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Controllers
{
    [ApiController]

    public class AddController : ControllerBase
    {
        [HttpGet("/add")]
        public IActionResult Add(int id, int cid)
        {
            var total = id + cid;
            return Ok(total);
        }

        [HttpPost("/multiply")]
        public IActionResult Multiply(int id, int cid)
        {
            var total = id * cid;
            return Ok(total);
        }

        [HttpPut("/substract")]
        public IActionResult Substract(int id, int cid)
        {
            var total = id - cid;
            return Ok(total);
        }

        [HttpPut("/delete")]
        public IActionResult Delete(int id, int cid)
        {
            return Ok(null);
        }

        [HttpGet("/getdata")]
        public IActionResult GetData()
        {
            var person = new List<PersonModel>()
            {
                new PersonModel() {Id=1, Name="Aryan"},
                new PersonModel() {Id=2, Name="Jiyani"}

            };
            return Ok(person);
        }
    }
}
