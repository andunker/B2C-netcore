namespace B2C.Models.entity
{
    using System;
    using System.Collections.Generic;

    public partial class Orden
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public Nullable<int> cliente_id { get; set; }

    }
}
