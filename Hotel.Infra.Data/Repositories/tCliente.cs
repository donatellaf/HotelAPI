//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotel.Infra.Data.Repositories
{
    using System;
    using System.Collections.Generic;
    
    public partial class tCliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tCliente()
        {
            this.tAlquiler = new HashSet<tAlquiler>();
        }
    
        public int idCliente { get; set; }
        public string documento { get; set; }
        public string nombre { get; set; }
        public Nullable<System.DateTime> fechaNacimiento { get; set; }
        public string lugarNacimiento { get; set; }
        public string sexo { get; set; }
        public string observacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tAlquiler> tAlquiler { get; set; }
    }
}
