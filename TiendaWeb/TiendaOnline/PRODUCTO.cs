//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TiendaOnline
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRODUCTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUCTO()
        {
            this.CARRITO = new HashSet<CARRITO>();
            this.DETALLE_COMPRA = new HashSet<DETALLE_COMPRA>();
        }
    
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> IdMarca { get; set; }
        public Nullable<int> IdCategoria { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<int> Stock { get; set; }
        public string RutaImagen { get; set; }
        public Nullable<bool> Activo { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CARRITO> CARRITO { get; set; }
        public virtual CATEGORIA CATEGORIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_COMPRA> DETALLE_COMPRA { get; set; }
        public virtual MARCA MARCA { get; set; }
    }
}
