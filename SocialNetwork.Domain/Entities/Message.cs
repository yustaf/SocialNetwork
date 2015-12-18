namespace SocialNetwork.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;

    [Table("Message")]
    public partial class Message
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int FriendId { get; set; }

        [Column("Message")]
        [Required]
        [StringLength(1000)]
        public string Message1 { get; set; }

        public DateTime DateTime { get; set; }

        public virtual Profile Profile { get; set; }

        public virtual Profile Profile1 { get; set; }
    }
}
