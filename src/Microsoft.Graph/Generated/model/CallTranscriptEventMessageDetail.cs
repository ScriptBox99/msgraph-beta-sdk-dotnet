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
    /// The type CallTranscriptEventMessageDetail.
    /// </summary>
    public partial class CallTranscriptEventMessageDetail : EventMessageDetail
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallTranscriptEventMessageDetail"/> class.
        /// </summary>
        public CallTranscriptEventMessageDetail()
        {
            this.ODataType = "microsoft.graph.callTranscriptEventMessageDetail";
        }

        /// <summary>
        /// Gets or sets callId.
        /// </summary>
        [JsonPropertyName("callId")]
        public string CallId { get; set; }
    
        /// <summary>
        /// Gets or sets callTranscriptICalUid.
        /// </summary>
        [JsonPropertyName("callTranscriptICalUid")]
        public string CallTranscriptICalUid { get; set; }
    
        /// <summary>
        /// Gets or sets meetingOrganizer.
        /// </summary>
        [JsonPropertyName("meetingOrganizer")]
        public IdentitySet MeetingOrganizer { get; set; }
    
    }
}
