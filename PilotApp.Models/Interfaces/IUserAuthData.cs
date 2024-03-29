﻿using System.Collections.Generic;

namespace PilotApp.PilotApp.Interfaces
{
    public interface IUserAuthData
    {
        int Id { get; }
        string Name { get; }
        IEnumerable<string> Roles { get; }
        object TenantId { get; }
    }
}