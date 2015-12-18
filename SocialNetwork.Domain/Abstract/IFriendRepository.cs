using System.Collections.Generic;
using SocialNetwork.Domain.Entities;

namespace SocialNetwork.Domain.Abstract
{
    public interface IFriendRepository
    {
        IEnumerable<Friend> Friends { get; }
    }
}
