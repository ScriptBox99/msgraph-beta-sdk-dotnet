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
    /// The type Attendance Record.
    /// </summary>
    public partial class AttendanceRecord : Entity
    {
    
        /// <summary>
        /// Gets or sets attendance intervals.
        /// List of time periods between joining and leaving a meeting.
        /// </summary>
        [JsonPropertyName("attendanceIntervals")]
        public IEnumerable<AttendanceInterval> AttendanceIntervals { get; set; }
    
        /// <summary>
        /// Gets or sets email address.
        /// Email address of the user associated with this atttendance record.
        /// </summary>
        [JsonPropertyName("emailAddress")]
        public string EmailAddress { get; set; }
    
        /// <summary>
        /// Gets or sets identity.
        /// Identity of the user associated with this atttendance record. The specific type will be one of the following derived types of identity, depending on the type of the user: communicationsUserIdentity, azureCommunicationServicesUserIdentity.
        /// </summary>
        [JsonPropertyName("identity")]
        public Identity Identity { get; set; }
    
        /// <summary>
        /// Gets or sets registrant id.
        /// Unique identifier of a meetingRegistrant. Presents when the participant has registered for the meeting.
        /// </summary>
        [JsonPropertyName("registrantId")]
        public string RegistrantId { get; set; }
    
        /// <summary>
        /// Gets or sets role.
        /// Role of the attendee. Possible values are: None, Attendee, Presenter, and Organizer.
        /// </summary>
        [JsonPropertyName("role")]
        public string Role { get; set; }
    
        /// <summary>
        /// Gets or sets total attendance in seconds.
        /// Total duration of the attendances in seconds.
        /// </summary>
        [JsonPropertyName("totalAttendanceInSeconds")]
        public Int32? TotalAttendanceInSeconds { get; set; }
    
    }
}

