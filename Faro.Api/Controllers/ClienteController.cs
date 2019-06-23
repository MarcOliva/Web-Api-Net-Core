using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Faro.Domain;
using Faro.Service;
using Microsoft.AspNetCore.Mvc;
namespace Faro.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private IClienteService clienteService;
        public ClienteController(IClienteService clienteService)
        {
            this.clienteService = clienteService;
        }
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(clienteService.GetAll());
        }
        [HttpPost]
        public ActionResult Post([FromBody] Cliente cliente)
        {
            return Ok(clienteService.Save(cliente));
        }
        [HttpPut]
        public ActionResult Put([FromBody] Cliente cliente)
        {
            return Ok(clienteService.Update(cliente));
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(clienteService.Delete(id));
        }
    }
}