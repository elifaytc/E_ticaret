//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ayakkabi_Projesi.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Siparis
    {
        public int SiparisID { get; set; }
        public int AyakkabiID { get; set; }
        public int Adet { get; set; }
        public System.DateTime SiparisTarih { get; set; }
        public int KullaniciID { get; set; }
    
        public virtual Ayakkabi Ayakkabi { get; set; }
        public virtual Kullanici Kullanici { get; set; }
    }
}
