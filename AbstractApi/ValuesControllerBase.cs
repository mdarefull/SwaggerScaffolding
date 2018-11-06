using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;

namespace AbstractApi
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class ValuesControllerBase : ControllerBase
    {
        // GET api/values
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public abstract ActionResult<IEnumerable<string>> Get();

        // GET api/values/5
        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public abstract ActionResult<string> Get(int id);

        // POST api/values
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public abstract ActionResult Post([FromBody] string value);

        // PUT api/values/5
        [HttpPut("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public abstract ActionResult Put(int id, [FromBody] string value);

        // DELETE api/values/5
        [HttpDelete("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public abstract ActionResult Delete(int id);
    }
}
