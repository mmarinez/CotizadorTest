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
    
    public partial class CLIENTE
    {
        public string NombreCliente { get; set; }
        public string Direccion { get; set; }
        public string Provincia { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Sector { get; set; }
        public string Municipio { get; set; }
        public string CodigoPromotor { get; set; }
        public Nullable<int> Edad0a5 { get; set; }
        public Nullable<int> Edad6a14 { get; set; }
        public Nullable<int> Edad15a24 { get; set; }
        public Nullable<int> Edad25a34 { get; set; }
        public Nullable<int> Edad35a44 { get; set; }
        public Nullable<int> Edad45a54 { get; set; }
        public Nullable<int> Edad55a64 { get; set; }
    
        public virtual PROMOTOR PROMOTOR { get; set; }
    }
}