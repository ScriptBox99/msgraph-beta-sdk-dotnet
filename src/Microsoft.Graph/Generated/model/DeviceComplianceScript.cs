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
    /// The type Device Compliance Script.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<DeviceComplianceScript>))]
    public partial class DeviceComplianceScript : Entity
    {
    
        /// <summary>
        /// Gets or sets created date time.
        /// The timestamp of when the device compliance script was created. This property is read-only.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Description of the device compliance script
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets detection script content.
        /// The entire content of the detection powershell script
        /// </summary>
        [JsonPropertyName("detectionScriptContent")]
        public byte[] DetectionScriptContent { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Name of the device compliance script
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets enforce signature check.
        /// Indicate whether the script signature needs be checked
        /// </summary>
        [JsonPropertyName("enforceSignatureCheck")]
        public bool? EnforceSignatureCheck { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// The timestamp of when the device compliance script was modified. This property is read-only.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets publisher.
        /// Name of the device compliance script publisher
        /// </summary>
        [JsonPropertyName("publisher")]
        public string Publisher { get; set; }
    
        /// <summary>
        /// Gets or sets role scope tag ids.
        /// List of Scope Tag IDs for the device compliance script
        /// </summary>
        [JsonPropertyName("roleScopeTagIds")]
        public IEnumerable<string> RoleScopeTagIds { get; set; }
    
        /// <summary>
        /// Gets or sets run as32bit.
        /// Indicate whether PowerShell script(s) should run as 32-bit
        /// </summary>
        [JsonPropertyName("runAs32Bit")]
        public bool? RunAs32Bit { get; set; }
    
        /// <summary>
        /// Gets or sets run as account.
        /// Indicates the type of execution context. Possible values are: system, user.
        /// </summary>
        [JsonPropertyName("runAsAccount")]
        public RunAsAccountType? RunAsAccount { get; set; }
    
        /// <summary>
        /// Gets or sets version.
        /// Version of the device compliance script
        /// </summary>
        [JsonPropertyName("version")]
        public string Version { get; set; }
    
        /// <summary>
        /// Gets or sets assignments.
        /// The list of group assignments for the device compliance script
        /// </summary>
        [JsonPropertyName("assignments")]
        public IDeviceComplianceScriptAssignmentsCollectionPage Assignments { get; set; }

        /// <summary>
        /// Gets or sets assignmentsNextLink.
        /// </summary>
        [JsonPropertyName("assignments@odata.nextLink")]
        public string AssignmentsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets device run states.
        /// List of run states for the device compliance script across all devices
        /// </summary>
        [JsonPropertyName("deviceRunStates")]
        public IDeviceComplianceScriptDeviceRunStatesCollectionPage DeviceRunStates { get; set; }

        /// <summary>
        /// Gets or sets deviceRunStatesNextLink.
        /// </summary>
        [JsonPropertyName("deviceRunStates@odata.nextLink")]
        public string DeviceRunStatesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets run summary.
        /// High level run summary for device compliance script.
        /// </summary>
        [JsonPropertyName("runSummary")]
        public DeviceComplianceScriptRunSummary RunSummary { get; set; }
    
    }
}

