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
    /// The type AppleOwnerTypeEnrollmentType.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AppleOwnerTypeEnrollmentType>))]
    public partial class AppleOwnerTypeEnrollmentType
    {

        /// <summary>
        /// Gets or sets enrollmentType.
        /// The enrollment type. Possible values are: unknown, device, user.
        /// </summary>
        [JsonPropertyName("enrollmentType")]
        public AppleUserInitiatedEnrollmentType? EnrollmentType { get; set; }
    
        /// <summary>
        /// Gets or sets ownerType.
        /// The owner type. Possible values are: unknown, company, personal.
        /// </summary>
        [JsonPropertyName("ownerType")]
        public ManagedDeviceOwnerType? OwnerType { get; set; }
    
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
