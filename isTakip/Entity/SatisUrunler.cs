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
    
    public partial class SatisUrunler
    {
        public int ID { get; set; }
        public Nullable<int> SatisFiyati { get; set; }
        public Nullable<System.DateTime> SatisTarih { get; set; }
        public Nullable<int> FirmaAdi { get; set; }
        public Nullable<int> SatilanMalzeme { get; set; }
        public Nullable<int> SatanPersonel { get; set; }
        public Nullable<int> SatilanAdet { get; set; }
    
        public virtual Firmalar Firmalar { get; set; }
        public virtual Malzemeler Malzemeler { get; set; }
        public virtual Personel Personel { get; set; }
    }
}
