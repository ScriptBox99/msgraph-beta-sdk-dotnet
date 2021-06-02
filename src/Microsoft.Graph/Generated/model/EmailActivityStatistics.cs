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
    /// The type Email Activity Statistics.
    /// </summary>
    public partial class EmailActivityStatistics : ActivityStatistics
    {
    
        ///<summary>
        /// The EmailActivityStatistics constructor
        ///</summary>
        public EmailActivityStatistics()
        {
            this.ODataType = "microsoft.graph.emailActivityStatistics";
        }

        /// <summary>
        /// Gets or sets after hours.
        /// Total hours spent on email outside of working hours, which is based on the user's Outlook calendar setting for work hours. The value is represented in ISO 8601 format for durations.
        /// </summary>
        [JsonPropertyName("afterHours")]
        public Duration AfterHours { get; set; }
    
        /// <summary>
        /// Gets or sets read email.
        /// Total hours spent reading email. The value is represented in ISO 8601 format for durations.
        /// </summary>
        [JsonPropertyName("readEmail")]
        public Duration ReadEmail { get; set; }
    
        /// <summary>
        /// Gets or sets sent email.
        /// Total hours spent writing and sending email. The value is represented in ISO 8601 format for durations.
        /// </summary>
        [JsonPropertyName("sentEmail")]
        public Duration SentEmail { get; set; }
    
    }
}

