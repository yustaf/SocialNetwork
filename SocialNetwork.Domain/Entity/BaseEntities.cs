using System;
using System.ComponentModel.DataAnnotations;

namespace SocialNetwork.Domain.Entities
{
    public class BaseEntities
    {
        [Key]
        public Guid Id { get; set; }
    }
}
