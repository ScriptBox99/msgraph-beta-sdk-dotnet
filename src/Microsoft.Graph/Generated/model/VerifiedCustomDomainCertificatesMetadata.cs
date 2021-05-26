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
    /// The type VerifiedCustomDomainCertificatesMetadata.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<VerifiedCustomDomainCertificatesMetadata>))]
    public partial class VerifiedCustomDomainCertificatesMetadata
    {

        /// <summary>
        /// Gets or sets expiryDate.
        /// The expiry date of the custom domain certificate. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        /// </summary>
        [JsonPropertyName("expiryDate")]
        public DateTimeOffset? ExpiryDate { get; set; }
    
        /// <summary>
        /// Gets or sets issueDate.
        /// The issue date of the custom domain. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        /// </summary>
        [JsonPropertyName("issueDate")]
        public DateTimeOffset? IssueDate { get; set; }
    
        /// <summary>
        /// Gets or sets issuerName.
        /// The issuer name of the custom domain certificate.
        /// </summary>
        [JsonPropertyName("issuerName")]
        public string IssuerName { get; set; }
    
        /// <summary>
        /// Gets or sets subjectName.
        /// The subject name of the custom domain certificate.
        /// </summary>
        [JsonPropertyName("subjectName")]
        public string SubjectName { get; set; }
    
        /// <summary>
        /// Gets or sets thumbprint.
        /// The thumbprint associated with the custom domain certificate.
        /// </summary>
        [JsonPropertyName("thumbprint")]
        public string Thumbprint { get; set; }
    
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
