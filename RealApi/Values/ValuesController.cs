using AbstractApi;

using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;

namespace RealApi.Values
{
    public sealed class ValuesController : ValuesControllerBase
    {
        public override ActionResult<IEnumerable<string>> Get() => new string[] { "value1", "value2" };

        public override ActionResult<string> Get(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            else if (id == 1)
            {
                return StatusCode(500);
            }

            return Ok("value" + id);
        }

        public override ActionResult Post([FromBody] string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return BadRequest();
            }
            return value.Equals("500", StringComparison.OrdinalIgnoreCase)
                ? StatusCode(500)
                : StatusCode(200);
        }

        public override ActionResult Put(int id, [FromBody] string value)
        {
            if (id < 1)
            {
                return NotFound();
            }
            if (string.IsNullOrWhiteSpace(value))
            {
                return BadRequest();
            }
            return value.Equals("500", StringComparison.OrdinalIgnoreCase)
                ? StatusCode(500)
                : StatusCode(200);
        }

        public override ActionResult Delete(int id)
        {
            if (id < 1)
            {
                return NotFound();
            }
            else if (id == 1)
            {
                return StatusCode(500);
            }

            return Ok();
        }
    }
}
