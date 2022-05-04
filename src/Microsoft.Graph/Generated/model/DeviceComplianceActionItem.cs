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
    /// The type Device Compliance Action Item.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<DeviceComplianceActionItem>))]
    public partial class DeviceComplianceActionItem : Entity
    {
    
        /// <summary>
        /// Gets or sets action type.
        /// What action to take. Possible values are: noAction, notification, block, retire, wipe, removeResourceAccessProfiles, pushNotification, remoteLock.
        /// </summary>
        [JsonPropertyName("actionType")]
        public DeviceComplianceActionType? ActionType { get; set; }
    
        /// <summary>
        /// Gets or sets grace period hours.
        /// Number of hours to wait till the action will be enforced. Valid values 0 to 8760
        /// </summary>
        [JsonPropertyName("gracePeriodHours")]
        public Int32? GracePeriodHours { get; set; }
    
        /// <summary>
        /// Gets or sets notification message cclist.
        /// A list of group IDs to speicify who to CC this notification message to.
        /// </summary>
        [JsonPropertyName("notificationMessageCCList")]
        public IEnumerable<string> NotificationMessageCCList { get; set; }
    
        /// <summary>
        /// Gets or sets notification template id.
        /// What notification Message template to use
        /// </summary>
        [JsonPropertyName("notificationTemplateId")]
        public string NotificationTemplateId { get; set; }
    
    }
}

