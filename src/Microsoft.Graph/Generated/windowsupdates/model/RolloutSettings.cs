// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.WindowsUpdates
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type RolloutSettings.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<RolloutSettings>))]
    public partial class RolloutSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RolloutSettings"/> class.
        /// </summary>
        public RolloutSettings()
        {
            this.ODataType = "microsoft.graph.windowsUpdates.rolloutSettings";
        }

        /// <summary>
        /// Gets or sets devicesPerOffer.
        /// Specifies the number of devices that are offered at the same time. Has no effect when endDateTime is set. When endDateTime and devicesPerOffer are both not set, all devices in the deployment are offered content at the same time.
        /// </summary>
        [JsonPropertyName("devicesPerOffer")]
        public Int32? DevicesPerOffer { get; set; }
    
        /// <summary>
        /// Gets or sets durationBetweenOffers.
        /// Specifies duration between each set of devices being offered the update. Has an effect when endDateTime or devicesPerOffer are defined. Default value is P1D (1 day).
        /// </summary>
        [JsonPropertyName("durationBetweenOffers")]
        public string DurationBetweenOffers { get; set; }
    
        /// <summary>
        /// Gets or sets endDateTime.
        /// Specifies the date before which all devices currently in the deployment are offered the update. Devices added after this date are offered immediately. When endDateTime and devicesPerOffer are both not set, all devices in the deployment are offered content at the same time.
        /// </summary>
        [JsonPropertyName("endDateTime")]
        public DateTimeOffset? EndDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets startDateTime.
        /// Date on which devices in the deployment start receiving the update. When not set, the deployment starts as soon as devices are assigned.
        /// </summary>
        [JsonPropertyName("startDateTime")]
        public DateTimeOffset? StartDateTime { get; set; }
    
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
