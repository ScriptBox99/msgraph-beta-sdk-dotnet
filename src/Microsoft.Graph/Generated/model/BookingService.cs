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
    /// The type Booking Service.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<BookingService>))]
    public partial class BookingService : BookingNamedEntity
    {
    
        ///<summary>
        /// The BookingService constructor
        ///</summary>
        public BookingService()
        {
            this.ODataType = "microsoft.graph.bookingService";
        }
    
        /// <summary>
        /// Gets or sets additional information.
        /// </summary>
        [JsonPropertyName("additionalInformation")]
        public string AdditionalInformation { get; set; }
    
        /// <summary>
        /// Gets or sets default duration.
        /// The default length of the service, represented in numbers of days, hours, minutes, and seconds. For example, P11D23H59M59.999999999999S.
        /// </summary>
        [JsonPropertyName("defaultDuration")]
        public Duration DefaultDuration { get; set; }
    
        /// <summary>
        /// Gets or sets default location.
        /// The default physical location for the service.
        /// </summary>
        [JsonPropertyName("defaultLocation")]
        public Location DefaultLocation { get; set; }
    
        /// <summary>
        /// Gets or sets default price.
        /// The default monetary price for the service.
        /// </summary>
        [JsonPropertyName("defaultPrice")]
        public double? DefaultPrice { get; set; }
    
        /// <summary>
        /// Gets or sets default price type.
        /// The default way the service is charged. Possible values are: undefined, fixedPrice, startingAt, hourly, free, priceVaries, callUs, notSet.
        /// </summary>
        [JsonPropertyName("defaultPriceType")]
        public BookingPriceType? DefaultPriceType { get; set; }
    
        /// <summary>
        /// Gets or sets default reminders.
        /// The value of this property is only available when reading an individual booking service by id.
        /// </summary>
        [JsonPropertyName("defaultReminders")]
        public IEnumerable<BookingReminder> DefaultReminders { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// A text description for the service.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets is hidden from customers.
        /// True means this service is not available to customers for booking.
        /// </summary>
        [JsonPropertyName("isHiddenFromCustomers")]
        public bool? IsHiddenFromCustomers { get; set; }
    
        /// <summary>
        /// Gets or sets is location online.
        /// </summary>
        [JsonPropertyName("isLocationOnline")]
        public bool? IsLocationOnline { get; set; }
    
        /// <summary>
        /// Gets or sets notes.
        /// Additional information about this service.
        /// </summary>
        [JsonPropertyName("notes")]
        public string Notes { get; set; }
    
        /// <summary>
        /// Gets or sets post buffer.
        /// The time to buffer after an appointment for this service ends, and before the next customer appointment can be booked.
        /// </summary>
        [JsonPropertyName("postBuffer")]
        public Duration PostBuffer { get; set; }
    
        /// <summary>
        /// Gets or sets pre buffer.
        /// The time to buffer before an appointment for this service can start.
        /// </summary>
        [JsonPropertyName("preBuffer")]
        public Duration PreBuffer { get; set; }
    
        /// <summary>
        /// Gets or sets scheduling policy.
        /// The set of policies that determine how appointments for this type of service should be created and managed.
        /// </summary>
        [JsonPropertyName("schedulingPolicy")]
        public BookingSchedulingPolicy SchedulingPolicy { get; set; }
    
        /// <summary>
        /// Gets or sets staff member ids.
        /// Represents those staff members who provide this service.
        /// </summary>
        [JsonPropertyName("staffMemberIds")]
        public IEnumerable<string> StaffMemberIds { get; set; }
    
    }
}

