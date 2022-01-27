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

    public class ProductosController : ApiController
    {
        private IMapper mapper;
        private readonly ProductoService productoService = new ProductoService(new ProductoRepository(PanaderiaContext.Create()));

        public ProductosController()
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            var productos = await productoService.GetAll();
            var productoDTOs = productos.Select(x => mapper.Map<ProductoDTO>(x));
            return Ok(productoDTOs);
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            var producto = await productoService.GetById(id);
            if (producto == null)
                return NotFound();
            var clienteDTO = mapper.Map<ClienteDTO>(producto);
            return Ok(clienteDTO);
        }

        [HttpPost]
        public async Task<IHttpActionResult> Post(ProductoDTO productoDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var producto = mapper.Map<Producto>(productoDTO);
                producto = await productoService.Insert(producto);
                return Ok(producto);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        public async Task<IHttpActionResult> Put(ProductoDTO productoDTO, int id)
        {
            //Valida Estado Modelo
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            //Verifica Id 
            if (productoDTO.IdProducto != id)
                return BadRequest();
            //Valida existencia de Objeto
            var flag = await productoService.GetById(id);
            if (flag == null)
                return NotFound();
            try
            {
                var producto = mapper.Map<Producto>(productoDTO);
                producto = await productoService.Update(producto);
                return Ok(producto);
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
            var flag = await productoService.GetById(id);
            if (flag == null)
                return NotFound();
            try
            {
                if (!await productoService.DeleteEntity(id))
                    await productoService.Delete(id);
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