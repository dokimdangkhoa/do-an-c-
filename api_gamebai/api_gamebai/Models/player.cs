//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace api_gamebai.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class player
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public player()
        {
            this.player_chatlist = new HashSet<player_chatlist>();
            this.player_chatlist1 = new HashSet<player_chatlist>();
            this.player_listfriend = new HashSet<player_listfriend>();
            this.player_listfriend1 = new HashSet<player_listfriend>();
            this.player_rank = new HashSet<player_rank>();
            this.player_status = new HashSet<player_status>();
        }
    
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public decimal money { get; set; }
        public string nickname { get; set; }
        public string email { get; set; }
        public int status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<player_chatlist> player_chatlist { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<player_chatlist> player_chatlist1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<player_listfriend> player_listfriend { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<player_listfriend> player_listfriend1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<player_rank> player_rank { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<player_status> player_status { get; set; }
    }
}
