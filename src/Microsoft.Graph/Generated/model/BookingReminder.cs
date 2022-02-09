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
    /// The type BookingReminder.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<BookingReminder>))]
    public partial class BookingReminder
    {

        /// <summary>
        /// Gets or sets message.
        /// The message in the reminder.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    
        /// <summary>
        /// Gets or sets offset.
        /// The amount of time before the start of an appointment that the reminder should be sent. It's denoted in ISO 8601 format.
        /// </summary>
        [JsonPropertyName("offset")]
        public Duration Offset { get; set; }
    
        /// <summary>
        /// Gets or sets recipients.
        /// The persons who should receive the reminder. Possible values are: allAttendees, staff, customer, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("recipients")]
        public BookingReminderRecipients? Recipients { get; set; }
    
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
