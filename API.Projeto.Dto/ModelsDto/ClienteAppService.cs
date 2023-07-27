using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Project.ModelsDto
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteAppService : ControllerBase
    {
        List<ClienteDto> clienteDtos = new List<ClienteDto>();
        public ClienteAppService() 
        {
            clienteDtos.Add(new ClienteDto()
            {
                Id = 1,
                Name = "Joao",
                Idade = 30
            });
        }



        [HttpGet]
        public IActionResult Get()
        {
            return NotFound(clienteDtos);
        }
    }
}
