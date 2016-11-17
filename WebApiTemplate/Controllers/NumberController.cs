using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiTemplate
{
    [RoutePrefix("v1/number")]
    public class NumberController : ApiController
    {
        [Route("")]
        [HttpGet]
        public HttpResponseMessage GetNumbers()
        {
            try
            {
                var numbers = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                return Request.CreateResponse(HttpStatusCode.OK, numbers);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}