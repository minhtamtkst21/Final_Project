//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ViewListItem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mathang
    {
        public Mathang()
        {
            this.GioHangs = new HashSet<GioHang>();
            this.NhaSanXuats = new HashSet<NhaSanXuat>();
        }
    
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Produce { get; set; }
        public int Price { get; set; }
        public Nullable<int> Remain { get; set; }
    
        public virtual ICollection<GioHang> GioHangs { get; set; }
        public virtual ICollection<NhaSanXuat> NhaSanXuats { get; set; }
    }
}