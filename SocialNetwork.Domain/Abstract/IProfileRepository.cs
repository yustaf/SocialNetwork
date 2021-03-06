﻿using System.Collections.Generic;
using SocialNetwork.Domain.Entities;

namespace SocialNetwork.Domain.Abstract
{
    public interface IProfileRepository
    {
        IEnumerable<Profile> Profiles { get; }
    }
}
