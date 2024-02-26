//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LopushokDemo.ADO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.ProductMaterial = new HashSet<ProductMaterial>();
        }
    
        public string Article { get; set; }
        public string Name { get; set; }
        public decimal MinimalAgentCost { get; set; }
        public string Image { get; set; }
        public int ProductTypeId { get; set; }
        public int CountOfPeopleToProduce { get; set; }
        public int NumberOfFactory { get; set; }
    
        public virtual ProductType ProductType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductMaterial> ProductMaterial { get; set; }
    }
}
