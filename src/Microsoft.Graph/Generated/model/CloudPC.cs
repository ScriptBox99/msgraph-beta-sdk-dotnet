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
    /// The type Cloud PC.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class CloudPC : Entity
    {
    
		///<summary>
		/// The CloudPC constructor
		///</summary>
        public CloudPC()
        {
            this.ODataType = "microsoft.graph.cloudPC";
        }
	
        /// <summary>
        /// Gets or sets display name.
        /// The cloud PC display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets grace period end date time.
        /// The date and time when the grace period ends and reprovisioning/deprovisioning happens. Required only if status is inGracePeriod. The timestamp is shown in ISO 8601 format and Coordinated Universal Time (UTC). For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gracePeriodEndDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? GracePeriodEndDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets image display name.
        /// Name of the OS image that's on the cloud PC.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "imageDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string ImageDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// The cloud PC's last modified date and time. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets managed device id.
        /// The cloud PC’s Intune device ID.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedDeviceId", Required = Newtonsoft.Json.Required.Default)]
        public string ManagedDeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets managed device name.
        /// The cloud PC’s Intune device name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedDeviceName", Required = Newtonsoft.Json.Required.Default)]
        public string ManagedDeviceName { get; set; }
    
        /// <summary>
        /// Gets or sets on premises connection name.
        /// The on-premises connection that is applied during provisioning of cloud PCs.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onPremisesConnectionName", Required = Newtonsoft.Json.Required.Default)]
        public string OnPremisesConnectionName { get; set; }
    
        /// <summary>
        /// Gets or sets provisioning policy id.
        /// The cloud PC's provisioning policy ID.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "provisioningPolicyId", Required = Newtonsoft.Json.Required.Default)]
        public string ProvisioningPolicyId { get; set; }
    
        /// <summary>
        /// Gets or sets provisioning policy name.
        /// The provisioning policy that is applied during provisioning of cloud PCs.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "provisioningPolicyName", Required = Newtonsoft.Json.Required.Default)]
        public string ProvisioningPolicyName { get; set; }
    
        /// <summary>
        /// Gets or sets service plan id.
        /// The cloud PC's service plan ID.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "servicePlanId", Required = Newtonsoft.Json.Required.Default)]
        public string ServicePlanId { get; set; }
    
        /// <summary>
        /// Gets or sets service plan name.
        /// The cloud PC's service plan name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "servicePlanName", Required = Newtonsoft.Json.Required.Default)]
        public string ServicePlanName { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// Status of the cloud PC. Possible values are: notProvisioned, provisioning, provisioned, upgrading, inGracePeriod, deprovisioning, failed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public CloudPcStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets status details.
        /// The details of the cloud PC status.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "statusDetails", Required = Newtonsoft.Json.Required.Default)]
        public CloudPcStatusDetails StatusDetails { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// The user principal name (UPN) of the user assigned to the cloud PC.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string UserPrincipalName { get; set; }
    
    }
}

