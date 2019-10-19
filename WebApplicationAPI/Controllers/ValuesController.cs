using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApplicationAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private string[] _valuesRepository = new string[1000];       

        public ValuesController(
            //string[] valuesRepository
        )
        {
            this._valuesRepository[0] = "Felipe Almeida";
            this._valuesRepository[1] = "Érica Sene";
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return _valuesRepository.Where(prop => prop != null).ToArray();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return _valuesRepository[id];
        }

        // POST api/values
        [HttpPost]
        public ActionResult<string> Post([FromBody] string value)
        {
            var position = _valuesRepository.Count(prop => prop != string.Empty
                                                        && prop != null);

            _valuesRepository[position] = value;

            return value;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult<string> Put(int id, [FromBody] string value)
        {
            // transaction
            // var entity = _valuesRepository[id];

            _valuesRepository[id] = value;

            // save

            return _valuesRepository[id];
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id)
        {
            // transaction
            // 

            _valuesRepository[id] = "-";

            // commit

            return "-";
        }
    }
}
