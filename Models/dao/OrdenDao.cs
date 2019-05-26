using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using B2C.Models.entity;
using System.Data.SqlClient;
using System.Data;
using System.Net.Http;
using System.Threading.Tasks;

namespace B2C.Models.dao
{
    public class OrdenDao
    {



        public async Task<Orden> buscar_orden_id(int i)
        {
            try
            {

                HttpClient client = new HttpClient();

                Orden OrdenVo = new Orden();

                HttpResponseMessage response = await client.GetAsync("http://localhost:8080/order/1");

                if (response.IsSuccessStatusCode)
                {
                    var json_respuesta = await response.Content.ReadAsAsync<Orden>();
                    OrdenVo.cliente_id = json_respuesta.cliente_id;
                    OrdenVo.id = json_respuesta.id;
                    OrdenVo.descripcion = json_respuesta.descripcion;
                }




                return OrdenVo;


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }




    }
}