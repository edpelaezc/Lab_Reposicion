using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MainProject.Models;

namespace MainProject.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CompressionsController : ControllerBase
    {
        // GET: api/Compressions
        [HttpGet]
        public IEnumerable<CompressionsCollection> Get()
        {
            return DataCompressions.Instance.archivos;
        }
    }
}
