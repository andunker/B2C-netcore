//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace B2C.Models.entity
{
    using System;
    using System.Collections.Generic;

    public partial class Producto
    {
        public int id { get; set; }
        public string espectaculo { get; set; }
        public string descripcion { get; set; }
        public Nullable<System.DateTime> fecha_espectaculo { get; set; }
        public string ciudad_espectaculo { get; set; }
        public Nullable<System.DateTime> fecha_llegada { get; set; }
        public Nullable<System.DateTime> fecha_salida { get; set; }
        public Nullable<int> tipo_transporte { get; set; }
        public Nullable<int> tipo_espectaculo { get; set; }
        public Nullable<int> tipo_hospedaje { get; set; }
        public Nullable<int> tarifa_transporte_id { get; set; }
        public Nullable<int> tarifa_hospedaje_id { get; set; }
        public Nullable<int> tarifa_espectaculo_id { get; set; }
        public Nullable<int> ciudad_id { get; set; }
        public string img { get; set; }


        public Nullable<int> tarifa_hospedaje { get; set; }
        public Nullable<int> tarifa_transporte { get; set; }
        public Nullable<int> tarifa_espectaculo { get; set; }


    }
}
