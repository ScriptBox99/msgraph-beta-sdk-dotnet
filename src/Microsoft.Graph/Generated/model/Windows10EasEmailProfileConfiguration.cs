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
    /// The type Windows10Eas Email Profile Configuration.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Windows10EasEmailProfileConfiguration>))]
    public partial class Windows10EasEmailProfileConfiguration : EasEmailProfileConfigurationBase
    {
    
        ///<summary>
        /// The Windows10EasEmailProfileConfiguration constructor
        ///</summary>
        public Windows10EasEmailProfileConfiguration()
        {
            this.ODataType = "microsoft.graph.windows10EasEmailProfileConfiguration";
        }

        /// <summary>
        /// Gets or sets account name.
        /// Account name.
        /// </summary>
        [JsonPropertyName("accountName")]
        public string AccountName { get; set; }
    
        /// <summary>
        /// Gets or sets duration of email to sync.
        /// Duration of email to sync. Possible values are: userDefined, oneDay, threeDays, oneWeek, twoWeeks, oneMonth, unlimited.
        /// </summary>
        [JsonPropertyName("durationOfEmailToSync")]
        public EmailSyncDuration? DurationOfEmailToSync { get; set; }
    
        /// <summary>
        /// Gets or sets email address source.
        /// Email attribute that is picked from AAD and injected into this profile before installing on the device. Possible values are: userPrincipalName, primarySmtpAddress.
        /// </summary>
        [JsonPropertyName("emailAddressSource")]
        public UserEmailSource? EmailAddressSource { get; set; }
    
        /// <summary>
        /// Gets or sets email sync schedule.
        /// Email sync schedule. Possible values are: userDefined, asMessagesArrive, manual, fifteenMinutes, thirtyMinutes, sixtyMinutes, basedOnMyUsage.
        /// </summary>
        [JsonPropertyName("emailSyncSchedule")]
        public EmailSyncSchedule? EmailSyncSchedule { get; set; }
    
        /// <summary>
        /// Gets or sets host name.
        /// Exchange location that (URL) that the native mail app connects to.
        /// </summary>
        [JsonPropertyName("hostName")]
        public string HostName { get; set; }
    
        /// <summary>
        /// Gets or sets require ssl.
        /// Indicates whether or not to use SSL.
        /// </summary>
        [JsonPropertyName("requireSsl")]
        public bool? RequireSsl { get; set; }
    
        /// <summary>
        /// Gets or sets sync calendar.
        /// Whether or not to sync the calendar.
        /// </summary>
        [JsonPropertyName("syncCalendar")]
        public bool? SyncCalendar { get; set; }
    
        /// <summary>
        /// Gets or sets sync contacts.
        /// Whether or not to sync contacts.
        /// </summary>
        [JsonPropertyName("syncContacts")]
        public bool? SyncContacts { get; set; }
    
        /// <summary>
        /// Gets or sets sync tasks.
        /// Whether or not to sync tasks.
        /// </summary>
        [JsonPropertyName("syncTasks")]
        public bool? SyncTasks { get; set; }
    
    }
}

