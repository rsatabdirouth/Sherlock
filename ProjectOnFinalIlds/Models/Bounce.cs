//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectOnFinalIlds.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bounce
    {
        public int BounceId { get; set; }
        public string Email { get; set; }
        public System.DateTime AttemptedTime { get; set; }
        public Nullable<int> Try { get; set; }
    }
}
