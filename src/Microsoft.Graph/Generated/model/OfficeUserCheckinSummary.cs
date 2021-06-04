// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type OfficeUserCheckinSummary.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class OfficeUserCheckinSummary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OfficeUserCheckinSummary"/> class.
        /// </summary>
        public OfficeUserCheckinSummary()
        {
            this.ODataType = "microsoft.graph.officeUserCheckinSummary";
        }

        /// <summary>
        /// Gets or sets failedUserCount.
        /// Total failed user check ins for the last 3 months.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "failedUserCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? FailedUserCount { get; set; }
    
        /// <summary>
        /// Gets or sets succeededUserCount.
        /// Total successful user check ins for the last 3 months.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "succeededUserCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? SucceededUserCount { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
