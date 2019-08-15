using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Foo4API.Controllers
{
    [RoutePrefix("api/foo")]

    public class FooController : ApiController
    {

        [HttpGet, Route("hello")]
        public IHttpActionResult CltLoginByToken()
        {
            return Ok("bar rocks");
        }

    }
}

