//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaFacturacionWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Presupuesto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Presupuesto()
        {
            this.PresupuestoDetalles = new HashSet<PresupuestoDetalles>();
        }
    
        public System.Guid CustomerId { get; set; }
        public string Cliente { get; set; }
        public string Factura { get; set; }
        public System.DateTime OrderDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PresupuestoDetalles> PresupuestoDetalles { get; set; }
    }
}