//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITDepartment.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Release
    {
        public int ReleaseId { get; set; }
        public int ProjectId { get; set; }
        public System.DateTime ReleaseDate { get; set; }
        public string ReleaseName { get; set; }
        public string ReleaseDescription { get; set; }
        public string ServerName { get; set; }
    
        public virtual Project Project { get; set; }
    }
}