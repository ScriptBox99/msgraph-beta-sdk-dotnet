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
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type AppliedAuthenticationEventListener.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AppliedAuthenticationEventListener>))]
    public partial class AppliedAuthenticationEventListener
    {

        /// <summary>
        /// Gets or sets eventType.
        /// </summary>
        [JsonPropertyName("eventType")]
        public AuthenticationEventType? EventType { get; set; }
    
        /// <summary>
        /// Gets or sets executedListenerId.
        /// </summary>
        [JsonPropertyName("executedListenerId")]
        public string ExecutedListenerId { get; set; }
    
        /// <summary>
        /// Gets or sets handlerResult.
        /// </summary>
        [JsonPropertyName("handlerResult")]
        public AuthenticationEventHandlerResult HandlerResult { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
