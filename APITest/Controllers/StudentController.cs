using APITest.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Cors;

namespace APITest.Controllers
{
    [RoutePrefix("api/Student")]
    [EnableCors(origins: "http://localhost:51333/Default.html", headers: "*", methods: "*")]
    public class StudentController : ApiController
    {
        [HttpGet]
        [Route("findStudent")]
        public HttpResponseMessage findStudent()
        {
            try
            {
            
                using (PerformanceTestEntities mde = new PerformanceTestEntities())
                {
                    mde.Configuration.ProxyCreationEnabled = false;

                    var response = new HttpResponseMessage(HttpStatusCode.OK);
                    response.Content = new StringContent(JsonConvert.SerializeObject(mde.Students.Where(x => x.ClassId == 1).ToList()));                    
                    response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    
                    return response;
                }
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(HttpStatusCode.BadGateway);
            }
        }

    }
}
