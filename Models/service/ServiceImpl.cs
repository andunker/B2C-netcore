using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using B2C.Models.entity;
using B2C.Models.dao;
using B2C.ViewModels;
using System.IdentityModel.Tokens.Jwt;

using System.Threading.Tasks;

namespace B2C.Models.service
{
    public class ServiceImpl : IService
    {
        public List<Producto> listar_productos()
        {

            ProductoDao productodao = new ProductoDao();
            return productodao.Listar();

        }

        public Producto buscar_producto_id(int id)
        {
            ProductoDao productodao = new ProductoDao();
            return productodao.buscar_producto_id(id);
        }

        public List<Producto> buscar_productos_nombre(string value)
        {
            ProductoDao productodao = new ProductoDao();
            return productodao.buscar_productos_nombre(value);
        }

        public List<Producto> buscar_productos_descripcion(string value)
        {
            ProductoDao productodao = new ProductoDao();
            return productodao.buscar_productos_descripcion(value);
        }

        public Task<Orden> buscar_orden_id(int i)
        {

            OrdenDao ordendao = new OrdenDao();

            return ordendao.buscar_orden_id(i);

        }

        public Task<Token> login(UserLogin user)
        {

            UsuarioDao usuariodao = new UsuarioDao();
            string userEmail = user.userEmail;
            string userPassword = user.userPassword;
            Task<Token> tokenVo = usuariodao.login(userEmail, userPassword);

            var valid = validarToken(tokenVo.Result.userToken);

            return tokenVo;

        }

        public Boolean validarToken(string tokenString)
        {

            var handler = new JwtSecurityTokenHandler();
            var token = handler.ReadJwtToken(tokenString);

            int fecha_actual = Convert.ToInt32(DateTimeOffset.UtcNow.ToUnixTimeSeconds());
            int fecha_expiracion_token = Convert.ToInt32(token.Payload["exp"]);
            int vidaToken = fecha_expiracion_token - fecha_actual;

            if (vidaToken > 0)
            {
                return true;
            }

            return false;
        }

    }
}