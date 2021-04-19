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
    /// The type Windows Feature Update Profile.
    /// </summary>
    public partial class WindowsFeatureUpdateProfile : Entity
    {
    
		///<summary>
		/// The WindowsFeatureUpdateProfile constructor
		///</summary>
        public WindowsFeatureUpdateProfile()
        {
            this.ODataType = "microsoft.graph.windowsFeatureUpdateProfile";
        }
	
        /// <summary>
        /// Gets or sets created date time.
        /// The date time that the profile was created.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets deployable content display name.
        /// Friendly display name of the quality update profile deployable content
        /// </summary>
        [JsonPropertyName("deployableContentDisplayName")]
        public string DeployableContentDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// The description of the profile which is specified by the user.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name of the profile.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets feature update version.
        /// The feature update version that will be deployed to the devices targeted by this profile. The version could be any supported version for example 1709, 1803 or 1809 and so on.
        /// </summary>
        [JsonPropertyName("featureUpdateVersion")]
        public string FeatureUpdateVersion { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// The date time that the profile was last modified.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets role scope tag ids.
        /// List of Scope Tags for this Feature Update entity.
        /// </summary>
        [JsonPropertyName("roleScopeTagIds")]
        public IEnumerable<string> RoleScopeTagIds { get; set; }
    
        /// <summary>
        /// Gets or sets assignments.
        /// The list of group assignments of the profile.
        /// </summary>
        [JsonPropertyName("assignments")]
        public IWindowsFeatureUpdateProfileAssignmentsCollectionPage Assignments { get; set; }

        /// <summary>
        /// Gets or sets assignmentsNextLink.
        /// </summary>
        [JsonPropertyName("assignments@odata.nextLink")]
        public string AssignmentsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets device update states.
        /// The list of device states this profile targeted to
        /// </summary>
        [JsonPropertyName("deviceUpdateStates")]
        public IWindowsFeatureUpdateProfileDeviceUpdateStatesCollectionPage DeviceUpdateStates { get; set; }

        /// <summary>
        /// Gets or sets deviceUpdateStatesNextLink.
        /// </summary>
        [JsonPropertyName("deviceUpdateStates@odata.nextLink")]
        public string DeviceUpdateStatesNextLink { get; set; }
    
    }
}

