//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Biblioteca
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbLibro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbLibro()
        {
            this.tbHistoricoes = new HashSet<tbHistorico>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
        public string autor { get; set; }
        public int idCategoria { get; set; }
        public bool estado { get; set; }
    
        public virtual tbCategoria tbCategoria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHistorico> tbHistoricoes { get; set; }
    }
}