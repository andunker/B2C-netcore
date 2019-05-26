using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using B2C.Models.service;
using B2C.Models.entity;
using B2C.ViewModels;

namespace B2C.Controllers
{
    [Route("api")]
    [ApiController]
    public class TheController : ControllerBase
    {
        private IService service = new ServiceImpl();

        [HttpGet]
        [Route("productos")]
        public List<Producto> GetProductos()
        {
            return service.listar_productos();
        }

        [HttpGet]
        [Route("productos/id")]
        public Producto GetProductoId([FromQuery] int id)
        {
            return service.buscar_producto_id(id);
        }

        [HttpPost]
        [Route("productos/buscar/nombre")]
        public List<Producto> GetProductosXNombre(ObjectSearchPro objectSearch)
        {
            return service.buscar_productos_nombre(objectSearch.valor);
        }

        [HttpPost]
        [Route("productos/buscar/descripcion")]
        public List<Producto> GetProductosXDescripcion(ObjectSearchPro objectSearch)
        {
            return service.buscar_productos_descripcion(objectSearch.valor);
        }

        //buscar_orden_id

        [HttpGet]
        [Route("ordenes/id")]
        public Task<Orden> GetOrdenId([FromQuery] int id)
        {
            return service.buscar_orden_id(id);
        }

        [HttpPost]
        [Route("login")]
        public Task<Token> login(UserLogin user)
        {
            return service.login(user);
        }

    }
}
