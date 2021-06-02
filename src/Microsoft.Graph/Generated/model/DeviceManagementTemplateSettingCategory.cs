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
    /// The type Device Management Template Setting Category.
    /// </summary>
    public partial class DeviceManagementTemplateSettingCategory : DeviceManagementSettingCategory
    {
    
        ///<summary>
        /// The DeviceManagementTemplateSettingCategory constructor
        ///</summary>
        public DeviceManagementTemplateSettingCategory()
        {
            this.ODataType = "microsoft.graph.deviceManagementTemplateSettingCategory";
        }

        /// <summary>
        /// Gets or sets recommended settings.
        /// The settings this category contains
        /// </summary>
        [JsonPropertyName("recommendedSettings")]
        public IDeviceManagementTemplateSettingCategoryRecommendedSettingsCollectionPage RecommendedSettings { get; set; }

        /// <summary>
        /// Gets or sets recommendedSettingsNextLink.
        /// </summary>
        [JsonPropertyName("recommendedSettings@odata.nextLink")]
        public string RecommendedSettingsNextLink { get; set; }
    
    }
}

