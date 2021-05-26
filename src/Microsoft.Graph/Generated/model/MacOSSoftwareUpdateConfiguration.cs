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
    /// The type Mac OSSoftware Update Configuration.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<MacOSSoftwareUpdateConfiguration>))]
    public partial class MacOSSoftwareUpdateConfiguration : DeviceConfiguration
    {
    
        ///<summary>
        /// The MacOSSoftwareUpdateConfiguration constructor
        ///</summary>
        public MacOSSoftwareUpdateConfiguration()
        {
            this.ODataType = "microsoft.graph.macOSSoftwareUpdateConfiguration";
        }
    
        /// <summary>
        /// Gets or sets all other update behavior.
        /// Update behavior for all other updates. Possible values are: notConfigured, default.
        /// </summary>
        [JsonPropertyName("allOtherUpdateBehavior")]
        public MacOSSoftwareUpdateBehavior? AllOtherUpdateBehavior { get; set; }
    
        /// <summary>
        /// Gets or sets config data update behavior.
        /// Update behavior for configuration data file updates. Possible values are: notConfigured, default.
        /// </summary>
        [JsonPropertyName("configDataUpdateBehavior")]
        public MacOSSoftwareUpdateBehavior? ConfigDataUpdateBehavior { get; set; }
    
        /// <summary>
        /// Gets or sets critical update behavior.
        /// Update behavior for critical updates. Possible values are: notConfigured, default.
        /// </summary>
        [JsonPropertyName("criticalUpdateBehavior")]
        public MacOSSoftwareUpdateBehavior? CriticalUpdateBehavior { get; set; }
    
        /// <summary>
        /// Gets or sets custom update time windows.
        /// Custom Time windows when updates will be allowed or blocked. This collection can contain a maximum of 20 elements.
        /// </summary>
        [JsonPropertyName("customUpdateTimeWindows")]
        public IEnumerable<CustomUpdateTimeWindow> CustomUpdateTimeWindows { get; set; }
    
        /// <summary>
        /// Gets or sets firmware update behavior.
        /// Update behavior for firmware updates. Possible values are: notConfigured, default.
        /// </summary>
        [JsonPropertyName("firmwareUpdateBehavior")]
        public MacOSSoftwareUpdateBehavior? FirmwareUpdateBehavior { get; set; }
    
        /// <summary>
        /// Gets or sets update schedule type.
        /// Update schedule type. Possible values are: alwaysUpdate, updateDuringTimeWindows, updateOutsideOfTimeWindows.
        /// </summary>
        [JsonPropertyName("updateScheduleType")]
        public MacOSSoftwareUpdateScheduleType? UpdateScheduleType { get; set; }
    
        /// <summary>
        /// Gets or sets update time window utc offset in minutes.
        /// Minutes indicating UTC offset for each update time window
        /// </summary>
        [JsonPropertyName("updateTimeWindowUtcOffsetInMinutes")]
        public Int32? UpdateTimeWindowUtcOffsetInMinutes { get; set; }
    
    }
}

