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
    public class BebidaController : ControllerBase
    {
        // GET: api/Bebida
        [HttpGet]
        public IEnumerable<Bebida> Get()
        {
            List<Bebida> myList = new List<Bebida>();
            myList = DataBebida.Instance.myTree.getList();
            myList.Sort(DataBebida.CompararBebida);
            return myList;
        }

        // GET: api/Bebida/5
        [HttpGet("{id}", Name = "Get")]
        public Bebida Get(string id)
        {
            return DataBebida.Instance.myTree.getElement(id);
        }

        // POST: api/Bebida
        [HttpPost]
        public void Post([FromBody] Bebida value)
        {
            DataBebida.Instance.myTree.Add(value);
        }
    }
}
