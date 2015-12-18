using System.Collections.Generic;
using SocialNetwork.Domain.Entities;

namespace SocialNetwork.Domain.Abstract
{
    public interface IMessageRepository
    {
        IEnumerable<Message> Messages { get; }
    }
}
