// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionWithReferencesResponse.cs.tt
namespace Microsoft.Graph
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type UnifiedRoleAssignmentMultipleDirectoryScopesCollectionWithReferencesResponse.
    /// </summary>
    public class UnifiedRoleAssignmentMultipleDirectoryScopesCollectionWithReferencesResponse
    {
        /// <summary>
        /// Gets or sets the <see cref="IUnifiedRoleAssignmentMultipleDirectoryScopesCollectionWithReferencesPage"/> value.
        /// </summary>
        [JsonPropertyName("value")]
        public IUnifiedRoleAssignmentMultipleDirectoryScopesCollectionWithReferencesPage Value { get; set; }

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
