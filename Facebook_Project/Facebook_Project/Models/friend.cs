//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Facebook_Project.Models
{
    using System;
    using System.Collections.Generic;

    public partial class friends
    {
        public int Id { set; get; }

        public int id_User { get; set; }
        public virtual userinfo User { get; set; }

        public int id_userFriend { get; set; }
        public virtual userinfo userFriend { get; set; }

    }
}
