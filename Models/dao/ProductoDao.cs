using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using B2C.Models.entity;

using System.Data.SqlClient;
using System.Data;

namespace B2C.Models.dao
{
    public class ProductoDao
    {


        public List<Producto> Listar()
        {
            try
            {
                List<Producto> Productos = new List<Producto>();



                SqlCommand command = new SqlCommand("sp_listar", Conexion.ObtenerConexion());

                command.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = command.ExecuteReader();



                while (reader.Read())
                {


                    Producto ProductoVo = new Producto();

                    ProductoVo.id = Convert.ToInt16(reader["id"]);
                    ProductoVo.espectaculo = reader["espectaculo"].ToString();
                    ProductoVo.descripcion = reader["descripcion"].ToString();
                    ProductoVo.fecha_espectaculo = DateTime.Parse(reader["fecha_espectaculo"].ToString());
                    ProductoVo.ciudad_espectaculo = reader["ciudad_espectaculo"].ToString();
                    ProductoVo.fecha_llegada = DateTime.Parse(reader["fecha_llegada"].ToString());
                    ProductoVo.fecha_salida = DateTime.Parse(reader["fecha_salida"].ToString());
                    ProductoVo.tipo_transporte = Convert.ToInt16(reader["tipo_transporte"]);
                    ProductoVo.tipo_espectaculo = Convert.ToInt16(reader["tipo_espectaculo"]);
                    ProductoVo.tipo_hospedaje = Convert.ToInt16(reader["tipo_hospedaje"]);
                    ProductoVo.tarifa_transporte_id = Convert.ToInt16(reader["tarifa_transporte_id"]);
                    ProductoVo.tarifa_hospedaje_id = Convert.ToInt16(reader["tarifa_hospedaje_id"]);
                    ProductoVo.tarifa_espectaculo_id = Convert.ToInt16(reader["tarifa_espectaculo_id"]);
                    ProductoVo.ciudad_id = Convert.ToInt16(reader["ciudad_id"]);
                    ProductoVo.img = reader["img"].ToString();

                    ProductoVo.tarifa_hospedaje = Convert.ToInt32(reader["tarifa_hospedaje"]);
                    ProductoVo.tarifa_transporte = Convert.ToInt32(reader["tarifa_transporte"]);
                    ProductoVo.tarifa_espectaculo = Convert.ToInt32(reader["tarifa_espectaculo"]);


                    Productos.Add(ProductoVo);

                }

                return Productos;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conexion.DescargarConexion();
            }
        }


        public Producto buscar_producto_id(int i)
        {
            try
            {

                SqlCommand command = new SqlCommand("sp_buscar_producto_id", Conexion.ObtenerConexion());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@i", i);

                SqlDataReader reader = command.ExecuteReader();

                Producto ProductoVo = new Producto();

                if (reader.Read())
                {


                    ProductoVo.id = Convert.ToInt16(reader["id"]);
                    ProductoVo.espectaculo = reader["espectaculo"].ToString();
                    ProductoVo.descripcion = reader["descripcion"].ToString();
                    ProductoVo.fecha_espectaculo = DateTime.Parse(reader["fecha_espectaculo"].ToString());
                    ProductoVo.ciudad_espectaculo = reader["ciudad_espectaculo"].ToString();
                    ProductoVo.fecha_llegada = DateTime.Parse(reader["fecha_llegada"].ToString());
                    ProductoVo.fecha_salida = DateTime.Parse(reader["fecha_salida"].ToString());
                    ProductoVo.tipo_transporte = Convert.ToInt16(reader["tipo_transporte"]);
                    ProductoVo.tipo_espectaculo = Convert.ToInt16(reader["tipo_espectaculo"]);
                    ProductoVo.tipo_hospedaje = Convert.ToInt16(reader["tipo_hospedaje"]);
                    ProductoVo.tarifa_transporte_id = Convert.ToInt16(reader["tarifa_transporte_id"]);
                    ProductoVo.tarifa_hospedaje_id = Convert.ToInt16(reader["tarifa_hospedaje_id"]);
                    ProductoVo.tarifa_espectaculo_id = Convert.ToInt16(reader["tarifa_espectaculo_id"]);
                    ProductoVo.ciudad_id = Convert.ToInt16(reader["ciudad_id"]);
                    ProductoVo.img = reader["img"].ToString();

                    ProductoVo.tarifa_hospedaje = Convert.ToInt32(reader["tarifa_hospedaje"]);
                    ProductoVo.tarifa_transporte = Convert.ToInt32(reader["tarifa_transporte"]);
                    ProductoVo.tarifa_espectaculo = Convert.ToInt32(reader["tarifa_espectaculo"]);
                }
                else
                {
                    return null;
                }

                return ProductoVo;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conexion.DescargarConexion();
            }
        }


        internal List<Producto> buscar_productos_nombre(string value)
        {
            try
            {
                List<Producto> Productos = new List<Producto>();


                SqlCommand command = new SqlCommand("sp_buscar_productos_nombre", Conexion.ObtenerConexion());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@value", value);

                SqlDataReader reader = command.ExecuteReader();



                while (reader.Read())
                {


                    Producto ProductoVo = new Producto();

                    ProductoVo.id = Convert.ToInt16(reader["id"]);
                    ProductoVo.espectaculo = reader["espectaculo"].ToString();
                    ProductoVo.descripcion = reader["descripcion"].ToString();
                    ProductoVo.fecha_espectaculo = DateTime.Parse(reader["fecha_espectaculo"].ToString());
                    ProductoVo.ciudad_espectaculo = reader["ciudad_espectaculo"].ToString();
                    ProductoVo.fecha_llegada = DateTime.Parse(reader["fecha_llegada"].ToString());
                    ProductoVo.fecha_salida = DateTime.Parse(reader["fecha_salida"].ToString());
                    ProductoVo.tipo_transporte = Convert.ToInt16(reader["tipo_transporte"]);
                    ProductoVo.tipo_espectaculo = Convert.ToInt16(reader["tipo_espectaculo"]);
                    ProductoVo.tipo_hospedaje = Convert.ToInt16(reader["tipo_hospedaje"]);
                    ProductoVo.tarifa_transporte_id = Convert.ToInt16(reader["tarifa_transporte_id"]);
                    ProductoVo.tarifa_hospedaje_id = Convert.ToInt16(reader["tarifa_hospedaje_id"]);
                    ProductoVo.tarifa_espectaculo_id = Convert.ToInt16(reader["tarifa_espectaculo_id"]);
                    ProductoVo.ciudad_id = Convert.ToInt16(reader["ciudad_id"]);
                    ProductoVo.img = reader["img"].ToString();

                    ProductoVo.tarifa_hospedaje = Convert.ToInt32(reader["tarifa_hospedaje"]);
                    ProductoVo.tarifa_transporte = Convert.ToInt32(reader["tarifa_transporte"]);
                    ProductoVo.tarifa_espectaculo = Convert.ToInt32(reader["tarifa_espectaculo"]);


                    Productos.Add(ProductoVo);

                }

                return Productos;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conexion.DescargarConexion();
            }
        }



        internal List<Producto> buscar_productos_descripcion(string value)
        {
            try
            {
                List<Producto> Productos = new List<Producto>();


                SqlCommand command = new SqlCommand("sp_buscar_productos_descripcion", Conexion.ObtenerConexion());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@value", value);

                SqlDataReader reader = command.ExecuteReader();



                while (reader.Read())
                {


                    Producto ProductoVo = new Producto();

                    ProductoVo.id = Convert.ToInt16(reader["id"]);
                    ProductoVo.espectaculo = reader["espectaculo"].ToString();
                    ProductoVo.descripcion = reader["descripcion"].ToString();
                    ProductoVo.fecha_espectaculo = DateTime.Parse(reader["fecha_espectaculo"].ToString());
                    ProductoVo.ciudad_espectaculo = reader["ciudad_espectaculo"].ToString();
                    ProductoVo.fecha_llegada = DateTime.Parse(reader["fecha_llegada"].ToString());
                    ProductoVo.fecha_salida = DateTime.Parse(reader["fecha_salida"].ToString());
                    ProductoVo.tipo_transporte = Convert.ToInt16(reader["tipo_transporte"]);
                    ProductoVo.tipo_espectaculo = Convert.ToInt16(reader["tipo_espectaculo"]);
                    ProductoVo.tipo_hospedaje = Convert.ToInt16(reader["tipo_hospedaje"]);
                    ProductoVo.tarifa_transporte_id = Convert.ToInt16(reader["tarifa_transporte_id"]);
                    ProductoVo.tarifa_hospedaje_id = Convert.ToInt16(reader["tarifa_hospedaje_id"]);
                    ProductoVo.tarifa_espectaculo_id = Convert.ToInt16(reader["tarifa_espectaculo_id"]);
                    ProductoVo.ciudad_id = Convert.ToInt16(reader["ciudad_id"]);
                    ProductoVo.img = reader["img"].ToString();

                    ProductoVo.tarifa_hospedaje = Convert.ToInt32(reader["tarifa_hospedaje"]);
                    ProductoVo.tarifa_transporte = Convert.ToInt32(reader["tarifa_transporte"]);
                    ProductoVo.tarifa_espectaculo = Convert.ToInt32(reader["tarifa_espectaculo"]);


                    Productos.Add(ProductoVo);

                }

                return Productos;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conexion.DescargarConexion();
            }
        }


    }


}