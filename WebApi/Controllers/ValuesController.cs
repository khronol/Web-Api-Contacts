using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : Controller
    {
        
        [HttpGet]
        public IEnumerable<IContact> Get()
        {
            return Repository.GetContacts();
        }


        // GET api/values/5
        public IContact GetCarById(int id)
        {
            return Repository.GetContactById(id);
        }



        [HttpGet]
        [Route("GetRange/{pos}/count/{count}")]
        public IEnumerable<IContact> Get(int pos, int count, int agrs = 0)
        {
            return Repository.GetContactRange(pos, count);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Contact value)
        {
            Repository.AddCar(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
