using System;

namespace SocialNetwork.Domain.Entities
{
    public class Message : BaseEntities
    {
        public int UserId { get; set; }
        public int FriendId { get; set; }
        public string Message { get; set; }
        public DateTime DateTime { get; set; }
    }
}
