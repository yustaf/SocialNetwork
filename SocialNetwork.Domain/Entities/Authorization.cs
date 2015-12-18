namespace SocialNetwork.Domain
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Authorization")]
    public partial class Authorization
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Login { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        public int UserId { get; set; }

        public virtual Profile Profile { get; set; }
    }
}
