
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
    
public partial class player_key
{

    public int id { get; set; }

    public int playerID { get; set; }

    public string keyuser { get; set; }

    public int keyStatus { get; set; }



    public virtual player player { get; set; }

}

}