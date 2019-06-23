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
    public class CategoriaController : ControllerBase
    {
        private ICategoriaService categoriaService;
        public CategoriaController(ICategoriaService categoriaService)
        {
            this.categoriaService = categoriaService;
        }
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(categoriaService.GetAll());
        }
        [HttpPost]
        public ActionResult Post([FromBody] Categoria categoria)
        {
            return Ok(categoriaService.Save(categoria));
        }
        [HttpPut]
        public ActionResult Put([FromBody] Categoria categoria)
        {
            return Ok(categoriaService.Update(categoria));
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(categoriaService.Delete(id));
        }
    }
}