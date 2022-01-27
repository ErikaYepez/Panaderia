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
    public class OrdenesController : ApiController
    {
        private IMapper mapper;
        private readonly OrdenService ordenService = new OrdenService(new OrdenRepository(PanaderiaContext.Create()));

        public OrdenesController()
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            var ordenes = await ordenService.GetAll();
            var ordenesDTO = ordenes.Select(x => mapper.Map<OrdenDTO>(x));
            return Ok(ordenesDTO);
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            var orden = await ordenService.GetById(id);
            if (orden == null)
                return NotFound();
            var ordenDTO = mapper.Map<OrdenDTO>(orden);
            return Ok(ordenDTO);
        }

        [HttpPost]
        public async Task<IHttpActionResult> Post(OrdenDTO ordenDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var orden = mapper.Map<Orden>(ordenDTO);
                orden = await ordenService.Insert(orden);
                return Ok(orden);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public async Task<IHttpActionResult> Put(OrdenDTO ordenDTO, int id)
        {
            //Valida Estado Modelo
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            //Verifica Id 
            if (ordenDTO.IdOrden != id)
                return BadRequest();
            //Valida existencia de Objeto
            var flag = await ordenService.GetById(id);
            if (flag == null)
                return NotFound();
            try
            {
                var orden = mapper.Map<Orden>(ordenDTO);
                orden = await ordenService.Update(orden);
                return Ok(orden);
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
            var flag = await ordenService.GetById(id);
            if (flag == null)
                return NotFound();
            try
            {
                if (!await ordenService.DeleteEntity(id))
                    await ordenService.Delete(id);
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