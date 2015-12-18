using System;

namespace SocialNetwork.Domain.Entities
{
    public class Profile : BaseEntities
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PartonymicName { get; set; }
        public DateTime Birthday { get; set; }
        public string City { get; set; }
        public string Contact { get; set; }
    }
}
