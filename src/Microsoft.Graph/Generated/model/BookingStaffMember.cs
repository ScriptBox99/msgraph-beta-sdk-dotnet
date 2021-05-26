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
    /// The type Booking Staff Member.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<BookingStaffMember>))]
    public partial class BookingStaffMember : BookingPerson
    {
    
        /// <summary>
        /// Gets or sets availability is affected by personal calendar.
        /// True means that if the staff member is a Microsoft 365 user, the Bookings API would verify the staff member's availability in their personal calendar in Microsoft 365, before making a booking.
        /// </summary>
        [JsonPropertyName("availabilityIsAffectedByPersonalCalendar")]
        public bool? AvailabilityIsAffectedByPersonalCalendar { get; set; }
    
        /// <summary>
        /// Gets or sets color index.
        /// Identifies a color to represent the staff member. The color corresponds to the color palette in the Staff details page in the Bookings app.
        /// </summary>
        [JsonPropertyName("colorIndex")]
        public Int32? ColorIndex { get; set; }
    
        /// <summary>
        /// Gets or sets role.
        /// The role of the staff member in the business. Possible values are: guest, administrator, viewer, externalGuest. Required.
        /// </summary>
        [JsonPropertyName("role")]
        public BookingStaffRole? Role { get; set; }
    
        /// <summary>
        /// Gets or sets use business hours.
        /// True means the staff member's availability is as specified in the businessHours property of the business. False means the availability is determined by the staff member's workingHours property setting.
        /// </summary>
        [JsonPropertyName("useBusinessHours")]
        public bool? UseBusinessHours { get; set; }
    
        /// <summary>
        /// Gets or sets working hours.
        /// The range of hours each day of the week that the staff member is available for booking. By default, they are initialized to be the same as the businessHours property of the business.
        /// </summary>
        [JsonPropertyName("workingHours")]
        public IEnumerable<BookingWorkHours> WorkingHours { get; set; }
    
    }
}

