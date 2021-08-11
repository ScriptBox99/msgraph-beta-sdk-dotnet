// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionResponse.cs.tt
namespace Microsoft.Graph
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type DepOnboardingSettingImportedAppleDeviceIdentitiesCollectionResponse.
    /// </summary>
    public class DepOnboardingSettingImportedAppleDeviceIdentitiesCollectionResponse
    {
        /// <summary>
        /// Gets or sets the <see cref="IDepOnboardingSettingImportedAppleDeviceIdentitiesCollectionPage"/> value.
        /// </summary>
        [JsonPropertyName("value")]
        public IDepOnboardingSettingImportedAppleDeviceIdentitiesCollectionPage Value { get; set; }

        /// <summary>
        /// Gets or sets the nextLink string value.
        /// </summary>
        [JsonPropertyName("@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string NextLink { get; set; }

        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    }
}
