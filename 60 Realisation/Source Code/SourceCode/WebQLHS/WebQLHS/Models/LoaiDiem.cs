﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebQLHS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    public partial class LoaiDiem
    {
        [DisplayName("Mã loại")]
        public int MaLoai { get; set; }
        [DisplayName("Tên loại")]
        public string TenLoai { get; set; }
        [DisplayName("Hệ số")]
        public Nullable<int> HeSo { get; set; }
    }
}