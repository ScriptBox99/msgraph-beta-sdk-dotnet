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
    /// The type Embedded SIMActivation Code Pool.
    /// </summary>
    public partial class EmbeddedSIMActivationCodePool : Entity
    {
    
        /// <summary>
        /// Gets or sets activation code count.
        /// The total count of activation codes which belong to this pool.
        /// </summary>
        [JsonPropertyName("activationCodeCount")]
        public Int32? ActivationCodeCount { get; set; }
    
        /// <summary>
        /// Gets or sets activation codes.
        /// The activation codes which belong to this pool. This navigation property is used to post activation codes to Intune but cannot be used to read activation codes from Intune.
        /// </summary>
        [JsonPropertyName("activationCodes")]
        public IEnumerable<EmbeddedSIMActivationCode> ActivationCodes { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// The time the embedded SIM activation code pool was created. Generated service side.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The admin defined name of the embedded SIM activation code pool.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets modified date time.
        /// The time the embedded SIM activation code pool was last modified. Updated service side.
        /// </summary>
        [JsonPropertyName("modifiedDateTime")]
        public DateTimeOffset? ModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets assignments.
        /// Navigational property to a list of targets to which this pool is assigned.
        /// </summary>
        [JsonPropertyName("assignments")]
        public IEmbeddedSIMActivationCodePoolAssignmentsCollectionPage Assignments { get; set; }

        /// <summary>
        /// Gets or sets assignmentsNextLink.
        /// </summary>
        [JsonPropertyName("assignments@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AssignmentsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets device states.
        /// Navigational property to a list of device states for this pool.
        /// </summary>
        [JsonPropertyName("deviceStates")]
        public IEmbeddedSIMActivationCodePoolDeviceStatesCollectionPage DeviceStates { get; set; }

        /// <summary>
        /// Gets or sets deviceStatesNextLink.
        /// </summary>
        [JsonPropertyName("deviceStates@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string DeviceStatesNextLink { get; set; }
    
    }
}

