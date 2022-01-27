using AutoMapper;
using Panaderia.BL.Models;

namespace Panaderia.BL.DTOs
{
    public class MapperConfig
    {
        public static MapperConfiguration MapperConfiguration()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Cliente, ClienteDTO>(); //Get
                cfg.CreateMap<ClienteDTO, Cliente>(); //Post-Put

                cfg.CreateMap<Direccion, DireccionDTO>(); 
                cfg.CreateMap<DireccionDTO, Direccion>();

                cfg.CreateMap<MetodoPago, MetodoPagoDTO>();
                cfg.CreateMap<MetodoPagoDTO, MetodoPago>();
                
                cfg.CreateMap<Orden, OrdenDTO>();
                cfg.CreateMap<OrdenDTO, Orden>();
                
                cfg.CreateMap<Producto, ProductoDTO>();
                cfg.CreateMap<ProductoDTO, Producto>();
            });
        }
    }
}
