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
    /// The type Device Management Setting Category.
    /// </summary>
    public partial class DeviceManagementSettingCategory : Entity
    {
    
		///<summary>
		/// The DeviceManagementSettingCategory constructor
		///</summary>
        public DeviceManagementSettingCategory()
        {
            this.ODataType = "microsoft.graph.deviceManagementSettingCategory";
        }
	
        /// <summary>
        /// Gets or sets display name.
        /// The category name
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets has required setting.
        /// The category contains top level required setting
        /// </summary>
        [JsonPropertyName("hasRequiredSetting")]
        public bool? HasRequiredSetting { get; set; }
    
        /// <summary>
        /// Gets or sets setting definitions.
        /// The setting definitions this category contains
        /// </summary>
        [JsonPropertyName("settingDefinitions")]
        public IDeviceManagementSettingCategorySettingDefinitionsCollectionPage SettingDefinitions { get; set; }

        /// <summary>
        /// Gets or sets settingDefinitionsNextLink.
        /// </summary>
        [JsonPropertyName("settingDefinitions@odata.nextLink")]
        public string SettingDefinitionsNextLink { get; set; }
    
    }
}

