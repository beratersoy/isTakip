//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace isTakip.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Firmalar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Firmalar()
        {
            this.Cagrilar = new HashSet<Cagrilar>();
            this.Mesajlar = new HashSet<Mesajlar>();
            this.Mesajlar1 = new HashSet<Mesajlar>();
            this.SatisUrunler = new HashSet<SatisUrunler>();
        }
    
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Yetkili { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Sektor { get; set; }
        public string İl { get; set; }
        public string İlçe { get; set; }
        public string Sifre { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cagrilar> Cagrilar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mesajlar> Mesajlar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mesajlar> Mesajlar1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SatisUrunler> SatisUrunler { get; set; }
    }
}
