//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CotizadorTest.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PlanCliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PlanCliente()
        {
            this.CLIENTEs = new HashSet<CLIENTE>();
        }
    
        public string NombrePlan { get; set; }
        public int PrecioEdad0a5 { get; set; }
        public int PrecioEdad6a14 { get; set; }
        public int PrecioEdad15a24 { get; set; }
        public int PrecioEdad25a34 { get; set; }
        public int PrecioEdad35a44 { get; set; }
        public int PrecioEdad45a54 { get; set; }
        public int PrecioEdad55a64 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTE> CLIENTEs { get; set; }
    }
}