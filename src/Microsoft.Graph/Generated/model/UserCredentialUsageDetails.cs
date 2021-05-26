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
    /// The type User Credential Usage Details.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<UserCredentialUsageDetails>))]
    public partial class UserCredentialUsageDetails : Entity
    {
    
        /// <summary>
        /// Gets or sets auth method.
        /// Represents the authentication method that the user used. Possible values are:email, mobileSMS, mobileCall, officePhone, securityQuestion (only used for self-service password reset), appNotification, appCode, alternateMobileCall (supported only in registration), fido, appPassword,unknownFutureValue
        /// </summary>
        [JsonPropertyName("authMethod")]
        public UsageAuthMethod? AuthMethod { get; set; }
    
        /// <summary>
        /// Gets or sets event date time.
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: 2014-01-01T00:00:00Z.
        /// </summary>
        [JsonPropertyName("eventDateTime")]
        public DateTimeOffset? EventDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets failure reason.
        /// Provides the failure reason for the corresponding reset or registration workflow.
        /// </summary>
        [JsonPropertyName("failureReason")]
        public string FailureReason { get; set; }
    
        /// <summary>
        /// Gets or sets feature.
        /// Possible values are: registration, reset, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("feature")]
        public FeatureType? Feature { get; set; }
    
        /// <summary>
        /// Gets or sets is success.
        /// Indicates success or failure of the workflow.
        /// </summary>
        [JsonPropertyName("isSuccess")]
        public bool? IsSuccess { get; set; }
    
        /// <summary>
        /// Gets or sets user display name.
        /// User name of the user performing the reset or registration workflow.
        /// </summary>
        [JsonPropertyName("userDisplayName")]
        public string UserDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// User principal name of the user performing the reset or registration workflow.
        /// </summary>
        [JsonPropertyName("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    
    }
}

