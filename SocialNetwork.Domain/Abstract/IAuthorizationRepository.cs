using System.Collections.Generic;
using SocialNetwork.Domain.Entities;

namespace SocialNetwork.Domain.Abstract
{
    public interface IAuthorizationRepository
    {
        IEnumerable<Authorization> Authorizations { get; }
    }
}
