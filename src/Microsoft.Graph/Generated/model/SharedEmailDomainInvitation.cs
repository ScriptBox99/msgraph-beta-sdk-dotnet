// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Shared Email Domain Invitation.
    /// </summary>
    public partial class SharedEmailDomainInvitation : Entity
    {
    
        /// <summary>
        /// Gets or sets expiry time.
        /// </summary>
        [JsonPropertyName("expiryTime")]
        public DateTimeOffset? ExpiryTime { get; set; }
    
        /// <summary>
        /// Gets or sets invitation domain.
        /// </summary>
        [JsonPropertyName("invitationDomain")]
        public string InvitationDomain { get; set; }
    
        /// <summary>
        /// Gets or sets invitation status.
        /// </summary>
        [JsonPropertyName("invitationStatus")]
        public string InvitationStatus { get; set; }
    
    }
}

