using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Polymer4.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        public class ExcelRow
        {
            public string Title { get; set; }
            public string Value { get; set; }
            public string Value2 { get; set; }
        }
        [HttpGet]
        [Route("excel")]
        [Produces("application/json", "application/xml")]
        public List<ExcelRow> Excel()
        {
            return new List<ExcelRow>()
            {
                new ExcelRow()
                {
                    Title = "asd",
                    Value = "qwe",
                    Value2 = "vvv",
                },
                new ExcelRow()
                {
                    Title = "asd2",
                    Value = "qwe",
                    Value2 = "vvv",
                },
                new ExcelRow()
                {
                    Title = "asd3",
                    Value = "qwe",
                    Value2 = "vvv",
                },
            };
        }

        [HttpGet]
        [Route("projectHours")]
        public List<dynamic> GetProjectHours(int projectId, DateTime? startNullable, DateTime? endNullable)
        {
            var start = startNullable ?? new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var end = endNullable ?? new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1);


            var result = new List<dynamic>();
            var users = new List<string>()
            {
                "Date",
                "Artur",
                "Sergey",
                "Semyon"
            };
            result.Add(users.ToList());
            users.RemoveAt(0);

            var rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                var line = new List<dynamic>();
                line.Add(i.ToString());
                var k = 0;
                foreach (var user in users)
                {
                    k++;
                    line.Add(4 + k + rand.Next(10));
                }
                result.Add(line);
            }

            if (projectId == 1)
            {


            }
            else
            {

            }
            return result;
        }

        [HttpGet]
        [Route("tst")]
        public IEnumerable<string> Get2()
        {
            return new string[] { "value1231231", "value4442" };
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
