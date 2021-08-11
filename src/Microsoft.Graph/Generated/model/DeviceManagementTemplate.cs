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
    /// The type Device Management Template.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<DeviceManagementTemplate>))]
    public partial class DeviceManagementTemplate : Entity
    {
    
        /// <summary>
        /// Gets or sets description.
        /// The template's description
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The template's display name
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets intent count.
        /// Number of Intents created from this template.
        /// </summary>
        [JsonPropertyName("intentCount")]
        public Int32? IntentCount { get; set; }
    
        /// <summary>
        /// Gets or sets is deprecated.
        /// The template is deprecated or not. Intents cannot be created from a deprecated template.
        /// </summary>
        [JsonPropertyName("isDeprecated")]
        public bool? IsDeprecated { get; set; }
    
        /// <summary>
        /// Gets or sets platform type.
        /// The template's platform. Possible values are: android, androidForWork, iOS, macOS, windowsPhone81, windows81AndLater, windows10AndLater, androidWorkProfile, windows10XProfile, all.
        /// </summary>
        [JsonPropertyName("platformType")]
        public PolicyPlatformType? PlatformType { get; set; }
    
        /// <summary>
        /// Gets or sets published date time.
        /// When the template was published
        /// </summary>
        [JsonPropertyName("publishedDateTime")]
        public DateTimeOffset? PublishedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets template subtype.
        /// The template's subtype. Possible values are: none, firewall, diskEncryption, attackSurfaceReduction, endpointDetectionReponse, accountProtection, antivirus, firewallSharedAppList, firewallSharedIpList, firewallSharedPortlist.
        /// </summary>
        [JsonPropertyName("templateSubtype")]
        public DeviceManagementTemplateSubtype? TemplateSubtype { get; set; }
    
        /// <summary>
        /// Gets or sets template type.
        /// The template's type. Possible values are: securityBaseline, specializedDevices, advancedThreatProtectionSecurityBaseline, deviceConfiguration, custom, securityTemplate, microsoftEdgeSecurityBaseline, microsoftOffice365ProPlusSecurityBaseline, deviceCompliance, deviceConfigurationForOffice365, cloudPC, firewallSharedSettings.
        /// </summary>
        [JsonPropertyName("templateType")]
        public DeviceManagementTemplateType? TemplateType { get; set; }
    
        /// <summary>
        /// Gets or sets version info.
        /// The template's version information
        /// </summary>
        [JsonPropertyName("versionInfo")]
        public string VersionInfo { get; set; }
    
        /// <summary>
        /// Gets or sets categories.
        /// Collection of setting categories within the template
        /// </summary>
        [JsonPropertyName("categories")]
        public IDeviceManagementTemplateCategoriesCollectionPage Categories { get; set; }

        /// <summary>
        /// Gets or sets categoriesNextLink.
        /// </summary>
        [JsonPropertyName("categories@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string CategoriesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets migratable to.
        /// Collection of templates this template can migrate to
        /// </summary>
        [JsonPropertyName("migratableTo")]
        public IDeviceManagementTemplateMigratableToCollectionPage MigratableTo { get; set; }

        /// <summary>
        /// Gets or sets migratableToNextLink.
        /// </summary>
        [JsonPropertyName("migratableTo@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string MigratableToNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets settings.
        /// Collection of all settings this template has
        /// </summary>
        [JsonPropertyName("settings")]
        public IDeviceManagementTemplateSettingsCollectionPage Settings { get; set; }

        /// <summary>
        /// Gets or sets settingsNextLink.
        /// </summary>
        [JsonPropertyName("settings@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string SettingsNextLink { get; set; }
    
    }
}

