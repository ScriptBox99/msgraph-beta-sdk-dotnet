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
    /// The type Authentication Context Class Reference.
    /// </summary>
    public partial class AuthenticationContextClassReference : Entity
    {
    
        /// <summary>
        /// Gets or sets description.
        /// A short explanation of the policies that are enforced by authenticationContextClassReference. This value should be used to provide secondary text to describe the authentication context class reference when building user-facing admin experiences. For example, a selection UX.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// A friendly name that identifies the authenticationContextClassReference object when building user-facing admin experiences. For example, a selection UX.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets is available.
        /// Indicates whether the authenticationContextClassReference has been published by the security admin and is ready for use by apps. When it is set to false, it should not be shown in admin UX experiences because the value is not currently available for selection.  Supports $filter (eq).
        /// </summary>
        [JsonPropertyName("isAvailable")]
        public bool? IsAvailable { get; set; }
    
    }
}

