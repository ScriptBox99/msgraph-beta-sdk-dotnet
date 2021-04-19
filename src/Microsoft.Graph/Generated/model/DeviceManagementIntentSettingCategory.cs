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
    /// The type Device Management Intent Setting Category.
    /// </summary>
    public partial class DeviceManagementIntentSettingCategory : DeviceManagementSettingCategory
    {
    
		///<summary>
		/// The DeviceManagementIntentSettingCategory constructor
		///</summary>
        public DeviceManagementIntentSettingCategory()
        {
            this.ODataType = "microsoft.graph.deviceManagementIntentSettingCategory";
        }
	
        /// <summary>
        /// Gets or sets settings.
        /// The settings this category contains
        /// </summary>
        [JsonPropertyName("settings")]
        public IDeviceManagementIntentSettingCategorySettingsCollectionPage Settings { get; set; }

        /// <summary>
        /// Gets or sets settingsNextLink.
        /// </summary>
        [JsonPropertyName("settings@odata.nextLink")]
        public string SettingsNextLink { get; set; }
    
    }
}

