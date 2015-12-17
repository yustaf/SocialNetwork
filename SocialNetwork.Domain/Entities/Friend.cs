namespace SocialNetwork.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Friend")]
    public partial class Friend
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int FriendId { get; set; }

        public virtual Profile Profile { get; set; }

        public virtual Profile Profile1 { get; set; }
    }
}
