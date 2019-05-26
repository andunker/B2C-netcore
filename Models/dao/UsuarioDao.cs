using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using B2C.Models.entity;
using System.Data.SqlClient;
using System.Data;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using System.Text;
using Newtonsoft.Json;

namespace B2C.Models.dao
{
    public class UsuarioDao
    {

        public async Task<Token> login(string userEmail, string userPassword)
        {
            try
            {

                HttpClient client = new HttpClient();
                Token TokenVo = new Token();

                var url = "http://localhost:8080/oms/login";

                dynamic userLogin = new JObject();
                userLogin.userEmail = userEmail;
                userLogin.userPassword = userPassword;

                var content = new StringContent(userLogin.ToString(), Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(url, content);


                if (response.IsSuccessStatusCode)
                {
                    var json_respuesta = await response.Content.ReadAsAsync<Token>();
                    TokenVo.userToken = json_respuesta.userToken;

                }




                return TokenVo;


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


    }
}