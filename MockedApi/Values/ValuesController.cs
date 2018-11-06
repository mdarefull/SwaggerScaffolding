using AbstractApi;

using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;

namespace MockedApi.Values
{
    public sealed class ValuesController : ValuesControllerBase
    {
        public override ActionResult Delete(int id) => Ok();
        public override ActionResult<IEnumerable<string>> Get() => new[] { "A", "B", "C" };
        public override ActionResult<string> Get(int id) => "OOK";
        public override ActionResult Post([FromBody] string value) => Ok();
        public override ActionResult Put(int id, [FromBody] string value) => Ok();
    }
}
