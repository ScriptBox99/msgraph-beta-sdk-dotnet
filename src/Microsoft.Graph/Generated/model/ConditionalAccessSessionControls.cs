// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type ConditionalAccessSessionControls.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ConditionalAccessSessionControls>))]
    public partial class ConditionalAccessSessionControls
    {

        /// <summary>
        /// Gets or sets applicationEnforcedRestrictions.
        /// Session control to enforce application restrictions. Only Exchange Online and Sharepoint Online support this session control.
        /// </summary>
        [JsonPropertyName("applicationEnforcedRestrictions")]
        public ApplicationEnforcedRestrictionsSessionControl ApplicationEnforcedRestrictions { get; set; }
    
        /// <summary>
        /// Gets or sets cloudAppSecurity.
        /// Session control to apply cloud app security.
        /// </summary>
        [JsonPropertyName("cloudAppSecurity")]
        public CloudAppSecuritySessionControl CloudAppSecurity { get; set; }
    
        /// <summary>
        /// Gets or sets disableResilienceDefaults.
        /// Session control that determines whether it is acceptable for Azure AD to extend existing sessions based on information collected prior to an outage or not.
        /// </summary>
        [JsonPropertyName("disableResilienceDefaults")]
        public bool? DisableResilienceDefaults { get; set; }
    
        /// <summary>
        /// Gets or sets persistentBrowser.
        /// Session control to define whether to persist cookies or not. All apps should be selected for this session control to work correctly.
        /// </summary>
        [JsonPropertyName("persistentBrowser")]
        public PersistentBrowserSessionControl PersistentBrowser { get; set; }
    
        /// <summary>
        /// Gets or sets signInFrequency.
        /// Session control to enforce signin frequency.
        /// </summary>
        [JsonPropertyName("signInFrequency")]
        public SignInFrequencySessionControl SignInFrequency { get; set; }
    
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
