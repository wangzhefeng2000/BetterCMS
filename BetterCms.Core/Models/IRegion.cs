﻿namespace BetterCms.Core.Models
{
    /// <summary>
    /// Defines interface to access basic content properties.
    /// </summary>
    public interface IRegion : IEntity
    {
        string Description { get; }

        string RegionIdentifier { get; }
    }
}
