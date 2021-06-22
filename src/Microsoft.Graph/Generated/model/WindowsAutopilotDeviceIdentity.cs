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
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Windows Autopilot Device Identity.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WindowsAutopilotDeviceIdentity : Entity
    {
    
		///<summary>
		/// The WindowsAutopilotDeviceIdentity constructor
		///</summary>
        public WindowsAutopilotDeviceIdentity()
        {
            this.ODataType = "microsoft.graph.windowsAutopilotDeviceIdentity";
        }
	
        /// <summary>
        /// Gets or sets addressable user name.
        /// Addressable user name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "addressableUserName", Required = Newtonsoft.Json.Required.Default)]
        public string AddressableUserName { get; set; }
    
        /// <summary>
        /// Gets or sets azure active directory device id.
        /// AAD Device ID - to be deprecated
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "azureActiveDirectoryDeviceId", Required = Newtonsoft.Json.Required.Default)]
        public string AzureActiveDirectoryDeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets azure ad device id.
        /// AAD Device ID
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "azureAdDeviceId", Required = Newtonsoft.Json.Required.Default)]
        public string AzureAdDeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets deployment profile assigned date time.
        /// Profile set time of the Windows autopilot device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deploymentProfileAssignedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? DeploymentProfileAssignedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets deployment profile assignment detailed status.
        /// Profile assignment detailed status of the Windows autopilot device. Possible values are: none, hardwareRequirementsNotMet, surfaceHubProfileNotSupported, holoLensProfileNotSupported, windowsPcProfileNotSupported.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deploymentProfileAssignmentDetailedStatus", Required = Newtonsoft.Json.Required.Default)]
        public WindowsAutopilotProfileAssignmentDetailedStatus? DeploymentProfileAssignmentDetailedStatus { get; set; }
    
        /// <summary>
        /// Gets or sets deployment profile assignment status.
        /// Profile assignment status of the Windows autopilot device. Possible values are: unknown, assignedInSync, assignedOutOfSync, assignedUnkownSyncState, notAssigned, pending, failed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deploymentProfileAssignmentStatus", Required = Newtonsoft.Json.Required.Default)]
        public WindowsAutopilotProfileAssignmentStatus? DeploymentProfileAssignmentStatus { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Display Name
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets enrollment state.
        /// Intune enrollment state of the Windows autopilot device. Possible values are: unknown, enrolled, pendingReset, failed, notContacted.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enrollmentState", Required = Newtonsoft.Json.Required.Default)]
        public EnrollmentState? EnrollmentState { get; set; }
    
        /// <summary>
        /// Gets or sets group tag.
        /// Group Tag of the Windows autopilot device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "groupTag", Required = Newtonsoft.Json.Required.Default)]
        public string GroupTag { get; set; }
    
        /// <summary>
        /// Gets or sets last contacted date time.
        /// Intune Last Contacted Date Time of the Windows autopilot device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastContactedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastContactedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets managed device id.
        /// Managed Device ID
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedDeviceId", Required = Newtonsoft.Json.Required.Default)]
        public string ManagedDeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets manufacturer.
        /// Oem manufacturer of the Windows autopilot device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "manufacturer", Required = Newtonsoft.Json.Required.Default)]
        public string Manufacturer { get; set; }
    
        /// <summary>
        /// Gets or sets model.
        /// Model name of the Windows autopilot device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "model", Required = Newtonsoft.Json.Required.Default)]
        public string Model { get; set; }
    
        /// <summary>
        /// Gets or sets product key.
        /// Product Key of the Windows autopilot device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "productKey", Required = Newtonsoft.Json.Required.Default)]
        public string ProductKey { get; set; }
    
        /// <summary>
        /// Gets or sets purchase order identifier.
        /// Purchase Order Identifier of the Windows autopilot device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "purchaseOrderIdentifier", Required = Newtonsoft.Json.Required.Default)]
        public string PurchaseOrderIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets resource name.
        /// Resource Name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resourceName", Required = Newtonsoft.Json.Required.Default)]
        public string ResourceName { get; set; }
    
        /// <summary>
        /// Gets or sets serial number.
        /// Serial number of the Windows autopilot device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "serialNumber", Required = Newtonsoft.Json.Required.Default)]
        public string SerialNumber { get; set; }
    
        /// <summary>
        /// Gets or sets sku number.
        /// SKU Number
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "skuNumber", Required = Newtonsoft.Json.Required.Default)]
        public string SkuNumber { get; set; }
    
        /// <summary>
        /// Gets or sets system family.
        /// System Family
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "systemFamily", Required = Newtonsoft.Json.Required.Default)]
        public string SystemFamily { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// User Principal Name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets deployment profile.
        /// Deployment profile currently assigned to the Windows autopilot device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deploymentProfile", Required = Newtonsoft.Json.Required.Default)]
        public WindowsAutopilotDeploymentProfile DeploymentProfile { get; set; }
    
        /// <summary>
        /// Gets or sets intended deployment profile.
        /// Deployment profile intended to be assigned to the Windows autopilot device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "intendedDeploymentProfile", Required = Newtonsoft.Json.Required.Default)]
        public WindowsAutopilotDeploymentProfile IntendedDeploymentProfile { get; set; }
    
    }
}

