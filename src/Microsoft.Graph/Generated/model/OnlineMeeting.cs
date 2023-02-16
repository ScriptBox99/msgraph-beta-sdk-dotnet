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
    /// The type Online Meeting.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<OnlineMeeting>))]
    public partial class OnlineMeeting : Entity
    {
    
        /// <summary>
        /// Gets or sets allow attendee to enable camera.
        /// Indicates whether attendees can turn on their camera.
        /// </summary>
        [JsonPropertyName("allowAttendeeToEnableCamera")]
        public bool? AllowAttendeeToEnableCamera { get; set; }
    
        /// <summary>
        /// Gets or sets allow attendee to enable mic.
        /// Indicates whether attendees can turn on their microphone.
        /// </summary>
        [JsonPropertyName("allowAttendeeToEnableMic")]
        public bool? AllowAttendeeToEnableMic { get; set; }
    
        /// <summary>
        /// Gets or sets allowed presenters.
        /// Specifies who can be a presenter in a meeting.
        /// </summary>
        [JsonPropertyName("allowedPresenters")]
        public OnlineMeetingPresenters? AllowedPresenters { get; set; }
    
        /// <summary>
        /// Gets or sets allow participants to change name.
        /// </summary>
        [JsonPropertyName("allowParticipantsToChangeName")]
        public bool? AllowParticipantsToChangeName { get; set; }
    
        /// <summary>
        /// Gets or sets allow teamwork reactions.
        /// Indicates if Teams reactions are enabled for the meeting.
        /// </summary>
        [JsonPropertyName("allowTeamworkReactions")]
        public bool? AllowTeamworkReactions { get; set; }
    
        /// <summary>
        /// Gets or sets alternative recording.
        /// The content stream of the alternative recording of a Microsoft Teams live event. Read-only.
        /// </summary>
        [JsonPropertyName("alternativeRecording")]
        public Stream AlternativeRecording { get; set; }
    
        /// <summary>
        /// Gets or sets anonymize identity for roles.
        /// </summary>
        [JsonPropertyName("anonymizeIdentityForRoles")]
        public IEnumerable<OnlineMeetingRole> AnonymizeIdentityForRoles { get; set; }
    
        /// <summary>
        /// Gets or sets attendee report.
        /// The content stream of the attendee report of a Teams live event. Read-only.
        /// </summary>
        [JsonPropertyName("attendeeReport")]
        public Stream AttendeeReport { get; set; }
    
        /// <summary>
        /// Gets or sets audio conferencing.
        /// The phone access (dial-in) information for an online meeting. Read-only.
        /// </summary>
        [JsonPropertyName("audioConferencing")]
        public AudioConferencing AudioConferencing { get; set; }
    
        /// <summary>
        /// Gets or sets broadcast settings.
        /// Settings related to a live event.
        /// </summary>
        [JsonPropertyName("broadcastSettings")]
        public BroadcastMeetingSettings BroadcastSettings { get; set; }
    
        /// <summary>
        /// Gets or sets capabilities.
        /// </summary>
        [JsonPropertyName("capabilities")]
        public IEnumerable<MeetingCapabilities> Capabilities { get; set; }
    
        /// <summary>
        /// Gets or sets chat info.
        /// The chat information associated with this online meeting.
        /// </summary>
        [JsonPropertyName("chatInfo")]
        public ChatInfo ChatInfo { get; set; }
    
        /// <summary>
        /// Gets or sets creation date time.
        /// The meeting creation time in UTC. Read-only.
        /// </summary>
        [JsonPropertyName("creationDateTime")]
        public DateTimeOffset? CreationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets end date time.
        /// The meeting end time in UTC.
        /// </summary>
        [JsonPropertyName("endDateTime")]
        public DateTimeOffset? EndDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets external id.
        /// The external ID. A custom ID. Optional.
        /// </summary>
        [JsonPropertyName("externalId")]
        public string ExternalId { get; set; }
    
        /// <summary>
        /// Gets or sets is broadcast.
        /// Indicates whether this is a Teams live event.
        /// </summary>
        [JsonPropertyName("isBroadcast")]
        public bool? IsBroadcast { get; set; }
    
        /// <summary>
        /// Gets or sets is entry exit announced.
        /// Indicates whether to announce when callers join or leave.
        /// </summary>
        [JsonPropertyName("isEntryExitAnnounced")]
        public bool? IsEntryExitAnnounced { get; set; }
    
        /// <summary>
        /// Gets or sets join information.
        /// The join information in the language and locale variant specified in 'Accept-Language' request HTTP header. Read-only.
        /// </summary>
        [JsonPropertyName("joinInformation")]
        public ItemBody JoinInformation { get; set; }
    
        /// <summary>
        /// Gets or sets join meeting id settings.
        /// Specifies the joinMeetingId, the meeting passcode, and the requirement for the passcode. Once an onlineMeeting is created, the joinMeetingIdSettings cannot be modified. To make any changes to this property, the meeting needs to be canceled and a new one needs to be created.
        /// </summary>
        [JsonPropertyName("joinMeetingIdSettings")]
        public JoinMeetingIdSettings JoinMeetingIdSettings { get; set; }
    
        /// <summary>
        /// Gets or sets join url.
        /// </summary>
        [JsonPropertyName("joinUrl")]
        public string JoinUrl { get; set; }
    
        /// <summary>
        /// Gets or sets join web url.
        /// The join URL of the online meeting. Read-only.
        /// </summary>
        [JsonPropertyName("joinWebUrl")]
        public string JoinWebUrl { get; set; }
    
        /// <summary>
        /// Gets or sets lobby bypass settings.
        /// Specifies which participants can bypass the meeting lobby.
        /// </summary>
        [JsonPropertyName("lobbyBypassSettings")]
        public LobbyBypassSettings LobbyBypassSettings { get; set; }
    
        /// <summary>
        /// Gets or sets participants.
        /// The participants associated with the online meeting. This includes the organizer and the attendees.
        /// </summary>
        [JsonPropertyName("participants")]
        public MeetingParticipants Participants { get; set; }
    
        /// <summary>
        /// Gets or sets record automatically.
        /// Indicates whether to record the meeting automatically.
        /// </summary>
        [JsonPropertyName("recordAutomatically")]
        public bool? RecordAutomatically { get; set; }
    
        /// <summary>
        /// Gets or sets recording.
        /// The content stream of the recording of a Teams live event. Read-only.
        /// </summary>
        [JsonPropertyName("recording")]
        public Stream Recording { get; set; }
    
        /// <summary>
        /// Gets or sets share meeting chat history default.
        /// </summary>
        [JsonPropertyName("shareMeetingChatHistoryDefault")]
        public MeetingChatHistoryDefaultMode? ShareMeetingChatHistoryDefault { get; set; }
    
        /// <summary>
        /// Gets or sets start date time.
        /// The meeting start time in UTC.
        /// </summary>
        [JsonPropertyName("startDateTime")]
        public DateTimeOffset? StartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets subject.
        /// The subject of the online meeting.
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }
    
        /// <summary>
        /// Gets or sets video teleconference id.
        /// The video teleconferencing ID. Read-only.
        /// </summary>
        [JsonPropertyName("videoTeleconferenceId")]
        public string VideoTeleconferenceId { get; set; }
    
        /// <summary>
        /// Gets or sets watermark protection.
        /// Specifies whether a watermark applies for different entities.
        /// </summary>
        [JsonPropertyName("watermarkProtection")]
        public WatermarkProtectionValues WatermarkProtection { get; set; }
    
        /// <summary>
        /// Gets or sets virtual appointment.
        /// </summary>
        [JsonPropertyName("virtualAppointment")]
        public VirtualAppointment VirtualAppointment { get; set; }
    
        /// <summary>
        /// Gets or sets attendance reports.
        /// The attendance reports of an online meeting. Read-only.
        /// </summary>
        [JsonPropertyName("attendanceReports")]
        public IOnlineMeetingAttendanceReportsCollectionPage AttendanceReports { get; set; }

        /// <summary>
        /// Gets or sets attendanceReportsNextLink.
        /// </summary>
        [JsonPropertyName("attendanceReports@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AttendanceReportsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets meeting attendance report.
        /// </summary>
        [JsonPropertyName("meetingAttendanceReport")]
        public MeetingAttendanceReport MeetingAttendanceReport { get; set; }
    
        /// <summary>
        /// Gets or sets registration.
        /// The registration that has been enabled for an online meeting. One online meeting can only have one registration enabled.
        /// </summary>
        [JsonPropertyName("registration")]
        public MeetingRegistration Registration { get; set; }
    
        /// <summary>
        /// Gets or sets transcripts.
        /// The transcripts of an online meeting. Read-only.
        /// </summary>
        [JsonPropertyName("transcripts")]
        public IOnlineMeetingTranscriptsCollectionPage Transcripts { get; set; }

        /// <summary>
        /// Gets or sets transcriptsNextLink.
        /// </summary>
        [JsonPropertyName("transcripts@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string TranscriptsNextLink { get; set; }
    
    }
}

