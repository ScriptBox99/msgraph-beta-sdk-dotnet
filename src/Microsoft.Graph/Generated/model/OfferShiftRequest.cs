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
    /// The type Offer Shift Request.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<OfferShiftRequestObject>))]
    public partial class OfferShiftRequestObject : ScheduleChangeRequestObject
    {
    
        ///<summary>
        /// The OfferShiftRequest constructor
        ///</summary>
        public OfferShiftRequestObject()
        {
            this.ODataType = "microsoft.graph.offerShiftRequest";
        }

        /// <summary>
        /// Gets or sets recipient action date time.
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [JsonPropertyName("recipientActionDateTime")]
        public DateTimeOffset? RecipientActionDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets recipient action message.
        /// Custom message sent by recipient of the offer shift request.
        /// </summary>
        [JsonPropertyName("recipientActionMessage")]
        public string RecipientActionMessage { get; set; }
    
        /// <summary>
        /// Gets or sets recipient user id.
        /// User id of the recipient of the offer shift request.
        /// </summary>
        [JsonPropertyName("recipientUserId")]
        public string RecipientUserId { get; set; }
    
        /// <summary>
        /// Gets or sets sender shift id.
        /// User id of the sender of the offer shift request.
        /// </summary>
        [JsonPropertyName("senderShiftId")]
        public string SenderShiftId { get; set; }
    
    }
}

