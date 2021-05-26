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
    /// The type Android Certificate Profile Base.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AndroidCertificateProfileBase>))]
    public partial class AndroidCertificateProfileBase : DeviceConfiguration
    {
    
        ///<summary>
        /// The internal AndroidCertificateProfileBase constructor
        ///</summary>
        protected internal AndroidCertificateProfileBase()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets certificate validity period scale.
        /// Scale for the Certificate Validity Period. Possible values are: days, months, years.
        /// </summary>
        [JsonPropertyName("certificateValidityPeriodScale")]
        public CertificateValidityPeriodScale? CertificateValidityPeriodScale { get; set; }
    
        /// <summary>
        /// Gets or sets certificate validity period value.
        /// Value for the Certificate Validity Period.
        /// </summary>
        [JsonPropertyName("certificateValidityPeriodValue")]
        public Int32? CertificateValidityPeriodValue { get; set; }
    
        /// <summary>
        /// Gets or sets extended key usages.
        /// Extended Key Usage (EKU) settings. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonPropertyName("extendedKeyUsages")]
        public IEnumerable<ExtendedKeyUsage> ExtendedKeyUsages { get; set; }
    
        /// <summary>
        /// Gets or sets renewal threshold percentage.
        /// Certificate renewal threshold percentage. Valid values 1 to 99
        /// </summary>
        [JsonPropertyName("renewalThresholdPercentage")]
        public Int32? RenewalThresholdPercentage { get; set; }
    
        /// <summary>
        /// Gets or sets subject alternative name type.
        /// Certificate Subject Alternative Name Type. Possible values are: none, emailAddress, userPrincipalName, customAzureADAttribute, domainNameService, universalResourceIdentifier.
        /// </summary>
        [JsonPropertyName("subjectAlternativeNameType")]
        public SubjectAlternativeNameType? SubjectAlternativeNameType { get; set; }
    
        /// <summary>
        /// Gets or sets subject name format.
        /// Certificate Subject Name Format. Possible values are: commonName, commonNameIncludingEmail, commonNameAsEmail, custom, commonNameAsIMEI, commonNameAsSerialNumber, commonNameAsAadDeviceId, commonNameAsIntuneDeviceId, commonNameAsDurableDeviceId.
        /// </summary>
        [JsonPropertyName("subjectNameFormat")]
        public SubjectNameFormat? SubjectNameFormat { get; set; }
    
        /// <summary>
        /// Gets or sets root certificate.
        /// Trusted Root Certificate.
        /// </summary>
        [JsonPropertyName("rootCertificate")]
        public AndroidTrustedRootCertificate RootCertificate { get; set; }
    
    }
}

