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
    /// The type Office Client Configuration.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<OfficeClientConfiguration>))]
    public partial class OfficeClientConfiguration : Entity
    {
    
		///<summary>
		/// The internal OfficeClientConfiguration constructor
		///</summary>
        protected internal OfficeClientConfiguration()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets checkin statuses.
        /// List of office Client check-in status.
        /// </summary>
        [JsonPropertyName("checkinStatuses")]
        public IEnumerable<OfficeClientCheckinStatus> CheckinStatuses { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Not yet documented
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Admin provided description of the office client configuration policy.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets policy payload.
        /// Policy settings JSON string in binary format, these values cannot be changed by the user.
        /// </summary>
        [JsonPropertyName("policyPayload")]
        public Stream PolicyPayload { get; set; }
    
        /// <summary>
        /// Gets or sets priority.
        /// Priority value should be unique value for each policy under a tenant and will be used for conflict resolution, lower values mean priority is high.
        /// </summary>
        [JsonPropertyName("priority")]
        public Int32? Priority { get; set; }
    
        /// <summary>
        /// Gets or sets user checkin summary.
        /// User check-in summary for the policy.
        /// </summary>
        [JsonPropertyName("userCheckinSummary")]
        public OfficeUserCheckinSummary UserCheckinSummary { get; set; }
    
        /// <summary>
        /// Gets or sets user preference payload.
        /// Preference settings JSON string in binary format, these values can be overridden by the user.
        /// </summary>
        [JsonPropertyName("userPreferencePayload")]
        public Stream UserPreferencePayload { get; set; }
    
        /// <summary>
        /// Gets or sets assignments.
        /// The list of group assignments for the policy.
        /// </summary>
        [JsonPropertyName("assignments")]
        public IOfficeClientConfigurationAssignmentsCollectionPage Assignments { get; set; }
    
    }
}

