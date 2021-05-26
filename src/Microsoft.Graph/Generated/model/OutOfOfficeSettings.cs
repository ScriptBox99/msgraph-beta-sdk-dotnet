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
    /// The type OutOfOfficeSettings.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<OutOfOfficeSettings>))]
    public partial class OutOfOfficeSettings
    {

        /// <summary>
        /// Gets or sets isOutOfOffice.
        /// True if either:It is currently in the out of office time window configured on the Outlook or Teams client.There is currently an event on the user's calendar that's marked as Show as Out of OfficeOtherwise, false.
        /// </summary>
        [JsonPropertyName("isOutOfOffice")]
        public bool? IsOutOfOffice { get; set; }
    
        /// <summary>
        /// Gets or sets message.
        /// The out of office message that the user configured on Outlook client (Automatic Replies (Out of Office)) or the Teams client (Schedule out of office).
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    
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
