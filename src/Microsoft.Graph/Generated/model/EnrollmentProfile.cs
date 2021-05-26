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
    /// The type Enrollment Profile.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<EnrollmentProfile>))]
    public partial class EnrollmentProfile : Entity
    {
    
        /// <summary>
        /// Gets or sets configuration endpoint url.
        /// Configuration endpoint url to use for Enrollment
        /// </summary>
        [JsonPropertyName("configurationEndpointUrl")]
        public string ConfigurationEndpointUrl { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Description of the profile
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Name of the profile
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets enable authentication via company portal.
        /// Indicates to authenticate with Apple Setup Assistant instead of Company Portal.
        /// </summary>
        [JsonPropertyName("enableAuthenticationViaCompanyPortal")]
        public bool? EnableAuthenticationViaCompanyPortal { get; set; }
    
        /// <summary>
        /// Gets or sets require company portal on setup assistant enrolled devices.
        /// Indicates that Company Portal is required on setup assistant enrolled devices
        /// </summary>
        [JsonPropertyName("requireCompanyPortalOnSetupAssistantEnrolledDevices")]
        public bool? RequireCompanyPortalOnSetupAssistantEnrolledDevices { get; set; }
    
        /// <summary>
        /// Gets or sets requires user authentication.
        /// Indicates if the profile requires user authentication
        /// </summary>
        [JsonPropertyName("requiresUserAuthentication")]
        public bool? RequiresUserAuthentication { get; set; }
    
    }
}

