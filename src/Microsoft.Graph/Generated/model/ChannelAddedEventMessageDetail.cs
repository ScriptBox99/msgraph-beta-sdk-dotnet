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
    /// The type ChannelAddedEventMessageDetail.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ChannelAddedEventMessageDetail : EventMessageDetail
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelAddedEventMessageDetail"/> class.
        /// </summary>
        public ChannelAddedEventMessageDetail()
        {
            this.ODataType = "microsoft.graph.channelAddedEventMessageDetail";
        }

        /// <summary>
        /// Gets or sets channelDisplayName.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "channelDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string ChannelDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets channelId.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "channelId", Required = Newtonsoft.Json.Required.Default)]
        public string ChannelId { get; set; }
    
        /// <summary>
        /// Gets or sets initiator.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "initiator", Required = Newtonsoft.Json.Required.Default)]
        public IdentitySet Initiator { get; set; }
    
    }
}
