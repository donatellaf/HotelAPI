//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotel.Infra.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class tAlquiler
    {
        public int idAlquiler { get; set; }
        public Nullable<decimal> precio { get; set; }
        public Nullable<System.DateTime> fechaEntrada { get; set; }
        public Nullable<System.DateTime> fechaSalida { get; set; }
        public string estado { get; set; }
        public string observacion { get; set; }
        public string fkVendedor { get; set; }
        public Nullable<int> fkCliente { get; set; }
        public Nullable<int> fkHabitacion { get; set; }
    
        public virtual tCliente tCliente { get; set; }
        public virtual tHabitacion tHabitacion { get; set; }
        public virtual tVendedor tVendedor { get; set; }
    }
}
