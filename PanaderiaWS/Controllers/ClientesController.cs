using AutoMapper;
using Panaderia.BL.Data;
using Panaderia.BL.DTOs;
using Panaderia.BL.Models;
using Panaderia.BL.Repositories.Implements;
using Panaderia.BL.Services.Implements;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace PanaderiaWS.Controllers
{
    public class ClientesController : ApiController
    {
        private IMapper mapper;
        private readonly ClienteService clienteService = new ClienteService(new ClienteRepository(PanaderiaContext.Create()));

        public ClientesController()
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            var clientes = await clienteService.GetAll();
            var clientesDTO = clientes.Select(x => mapper.Map<ClienteDTO>(x));
            return Ok(clientesDTO);
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            var cliente = await clienteService.GetById(id);
            if (cliente == null)
                return NotFound();
            var clienteDTO = mapper.Map<ClienteDTO>(cliente);
            return Ok(clienteDTO);
        }

        [HttpPost]
        public async Task<IHttpActionResult> Post(ClienteDTO clienteDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var cliente = mapper.Map<Cliente>(clienteDTO);
                cliente = await clienteService.Insert(cliente);
                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public async Task<IHttpActionResult> Put(ClienteDTO clienteDTO, int id)
        {
            //Valida Estado Modelo
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            //Verifica Id 
            if (clienteDTO.IdCliente != id)
                return BadRequest();
            //Valida existencia de Objeto
            var flag = await clienteService.GetById(id);
            if (flag == null)
                return NotFound();
            try
            {
                var cliente = mapper.Map<Cliente>(clienteDTO);
                cliente = await clienteService.Update(cliente);
                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpDelete]
        public async Task<IHttpActionResult> Delete(int id)
        {
            //Valida existencia de Objeto
            var flag = await clienteService.GetById(id);
            if (flag == null)
                return NotFound();
            try
            {
                if (!await clienteService.DeleteEntity(id))
                    await clienteService.Delete(id);
                else
                    throw new Exception("Existen claves Foraneas");
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}