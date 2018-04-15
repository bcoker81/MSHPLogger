using MSHPLogger.Entities;
using MSHPLogger.Repository.Interfaces;
using MSHPLogger.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace MSHPLogger.WebApi.Controllers
{
    [RoutePrefix("api/logger")]
    public class MSHPLoggerController : ApiController
    {
        private ILogger _repo;

        public MSHPLoggerController()
        {
            _repo = new LogRepository();
        }

        [HttpPost]
        [Route("LogEntry")]
        public async Task<HttpResponseMessage> LogEntry(LogEntry log)
        {
            bool res = false;

            res = _repo.LogError(log);

            if (res == true)
            {
                return Request.CreateErrorResponse(HttpStatusCode.OK, "Successfully logged data.");
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Error logging data.");
            }
        }
    }
}
