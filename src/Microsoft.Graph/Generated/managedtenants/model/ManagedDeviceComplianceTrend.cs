// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Managed Device Compliance Trend.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ManagedDeviceComplianceTrend : Microsoft.Graph.Entity
    {
    
		///<summary>
		/// The ManagedDeviceComplianceTrend constructor
		///</summary>
        public ManagedDeviceComplianceTrend()
        {
            this.ODataType = "microsoft.graph.managedTenants.managedDeviceComplianceTrend";
        }
	
        /// <summary>
        /// Gets or sets compliant device count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "compliantDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? CompliantDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets config manager device count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "configManagerDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ConfigManagerDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets count date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "countDateTime", Required = Newtonsoft.Json.Required.Default)]
        public string CountDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets error device count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "errorDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ErrorDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets in grace period device count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "inGracePeriodDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? InGracePeriodDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets noncompliant device count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "noncompliantDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? NoncompliantDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets tenant display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tenantDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string TenantDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets tenant id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tenantId", Required = Newtonsoft.Json.Required.Default)]
        public string TenantId { get; set; }
    
        /// <summary>
        /// Gets or sets unknown device count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unknownDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? UnknownDeviceCount { get; set; }
    
    }
}

