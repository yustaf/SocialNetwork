namespace SocialNetwork.Domain.Entities
{
    public class Authorization : BaseEntities
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public int UserId { get; set; }
    }
}
