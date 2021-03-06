﻿using System;

namespace PnP.Framework.Enums
{
    /// <summary>
    /// Supported Microsoft Graph Change Types on Subscriptions. Documentation at: https://docs.microsoft.com/graph/api/resources/subscription#properties
    /// </summary>
    [Flags]
    public enum GraphSubscriptionChangeType : int
    {
        /// <summary>
        /// Something got created
        /// </summary>
        Created = 1,

        /// <summary>
        /// Something existing got updated
        /// </summary>
        Updated = 2,

        /// <summary>
        /// Something got deleted
        /// </summary>
        Deleted = 4
    }
}
