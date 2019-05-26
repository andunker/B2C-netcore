using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B2C.Models.entity;
using B2C.ViewModels;

namespace B2C.Models.service
{
    interface IService
    {
        List<Producto> listar_productos();
        Producto buscar_producto_id(int id);

        List<Producto> buscar_productos_nombre(string value);
        List<Producto> buscar_productos_descripcion(string value);

        Task<Orden> buscar_orden_id(int i);
        Task<Token> login(UserLogin user);
    }
}

