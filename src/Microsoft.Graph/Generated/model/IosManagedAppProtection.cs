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
    /// The type Ios Managed App Protection.
    /// </summary>
    public partial class IosManagedAppProtection : TargetedManagedAppProtection
    {
    
		///<summary>
		/// The IosManagedAppProtection constructor
		///</summary>
        public IosManagedAppProtection()
        {
            this.ODataType = "microsoft.graph.iosManagedAppProtection";
        }
	
        /// <summary>
        /// Gets or sets allowed ios device models.
        /// Semicolon seperated list of device models allowed, as a string, for the managed app to work.
        /// </summary>
        [JsonPropertyName("allowedIosDeviceModels")]
        public string AllowedIosDeviceModels { get; set; }
    
        /// <summary>
        /// Gets or sets app action if ios device model not allowed.
        /// Defines a managed app behavior, either block or wipe, if the specified device model is not allowed. Possible values are: block, wipe, warn.
        /// </summary>
        [JsonPropertyName("appActionIfIosDeviceModelNotAllowed")]
        public ManagedAppRemediationAction? AppActionIfIosDeviceModelNotAllowed { get; set; }
    
        /// <summary>
        /// Gets or sets app data encryption type.
        /// Type of encryption which should be used for data in a managed app. Possible values are: useDeviceSettings, afterDeviceRestart, whenDeviceLockedExceptOpenFiles, whenDeviceLocked.
        /// </summary>
        [JsonPropertyName("appDataEncryptionType")]
        public ManagedAppDataEncryptionType? AppDataEncryptionType { get; set; }
    
        /// <summary>
        /// Gets or sets custom browser protocol.
        /// A custom browser protocol to open weblink on iOS. When this property is configured, ManagedBrowserToOpenLinksRequired should be true.
        /// </summary>
        [JsonPropertyName("customBrowserProtocol")]
        public string CustomBrowserProtocol { get; set; }
    
        /// <summary>
        /// Gets or sets custom dialer app protocol.
        /// Protocol of a custom dialer app to click-to-open a phone number on iOS, for example, skype:.
        /// </summary>
        [JsonPropertyName("customDialerAppProtocol")]
        public string CustomDialerAppProtocol { get; set; }
    
        /// <summary>
        /// Gets or sets deployed app count.
        /// Count of apps to which the current policy is deployed.
        /// </summary>
        [JsonPropertyName("deployedAppCount")]
        public Int32? DeployedAppCount { get; set; }
    
        /// <summary>
        /// Gets or sets disable protection of managed outbound open in data.
        /// Disable protection of data transferred to other apps through IOS OpenIn option. This setting is only allowed to be True when AllowedOutboundDataTransferDestinations is set to ManagedApps.
        /// </summary>
        [JsonPropertyName("disableProtectionOfManagedOutboundOpenInData")]
        public bool? DisableProtectionOfManagedOutboundOpenInData { get; set; }
    
        /// <summary>
        /// Gets or sets exempted app protocols.
        /// Apps in this list will be exempt from the policy and will be able to receive data from managed apps.
        /// </summary>
        [JsonPropertyName("exemptedAppProtocols")]
        public IEnumerable<KeyValuePair> ExemptedAppProtocols { get; set; }
    
        /// <summary>
        /// Gets or sets face id blocked.
        /// Indicates whether use of the FaceID is allowed in place of a pin if PinRequired is set to True.
        /// </summary>
        [JsonPropertyName("faceIdBlocked")]
        public bool? FaceIdBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets filter open in to only managed apps.
        /// Defines if open-in operation is supported from the managed app to the filesharing locations selected. This setting only applies when AllowedOutboundDataTransferDestinations is set to ManagedApps and DisableProtectionOfManagedOutboundOpenInData is set to False.
        /// </summary>
        [JsonPropertyName("filterOpenInToOnlyManagedApps")]
        public bool? FilterOpenInToOnlyManagedApps { get; set; }
    
        /// <summary>
        /// Gets or sets minimum required sdk version.
        /// Versions less than the specified version will block the managed app from accessing company data.
        /// </summary>
        [JsonPropertyName("minimumRequiredSdkVersion")]
        public string MinimumRequiredSdkVersion { get; set; }
    
        /// <summary>
        /// Gets or sets minimum wipe sdk version.
        /// Versions less than the specified version will block the managed app from accessing company data.
        /// </summary>
        [JsonPropertyName("minimumWipeSdkVersion")]
        public string MinimumWipeSdkVersion { get; set; }
    
        /// <summary>
        /// Gets or sets protect inbound data from unknown sources.
        /// Protect incoming data from unknown source. This setting is only allowed to be True when AllowedInboundDataTransferSources is set to AllApps.
        /// </summary>
        [JsonPropertyName("protectInboundDataFromUnknownSources")]
        public bool? ProtectInboundDataFromUnknownSources { get; set; }
    
        /// <summary>
        /// Gets or sets third party keyboards blocked.
        /// Defines if third party keyboards are allowed while accessing a managed app
        /// </summary>
        [JsonPropertyName("thirdPartyKeyboardsBlocked")]
        public bool? ThirdPartyKeyboardsBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets apps.
        /// List of apps to which the policy is deployed.
        /// </summary>
        [JsonPropertyName("apps")]
        public IIosManagedAppProtectionAppsCollectionPage Apps { get; set; }

        /// <summary>
        /// Gets or sets appsNextLink.
        /// </summary>
        [JsonPropertyName("apps@odata.nextLink")]
        public string AppsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets deployment summary.
        /// Navigation property to deployment summary of the configuration.
        /// </summary>
        [JsonPropertyName("deploymentSummary")]
        public ManagedAppPolicyDeploymentSummary DeploymentSummary { get; set; }
    
    }
}

