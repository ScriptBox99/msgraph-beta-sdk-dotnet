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
    /// The type Windows10Pkcs Certificate Profile.
    /// </summary>
    public partial class Windows10PkcsCertificateProfile : Windows10CertificateProfileBase
    {
    
		///<summary>
		/// The Windows10PkcsCertificateProfile constructor
		///</summary>
        public Windows10PkcsCertificateProfile()
        {
            this.ODataType = "microsoft.graph.windows10PkcsCertificateProfile";
        }
	
        /// <summary>
        /// Gets or sets certificate store.
        /// Target store certificate. Possible values are: user, machine.
        /// </summary>
        [JsonPropertyName("certificateStore")]
        public CertificateStore? CertificateStore { get; set; }
    
        /// <summary>
        /// Gets or sets certificate template name.
        /// PKCS Certificate Template Name
        /// </summary>
        [JsonPropertyName("certificateTemplateName")]
        public string CertificateTemplateName { get; set; }
    
        /// <summary>
        /// Gets or sets certification authority.
        /// PKCS Certification Authority
        /// </summary>
        [JsonPropertyName("certificationAuthority")]
        public string CertificationAuthority { get; set; }
    
        /// <summary>
        /// Gets or sets certification authority name.
        /// PKCS Certification Authority Name
        /// </summary>
        [JsonPropertyName("certificationAuthorityName")]
        public string CertificationAuthorityName { get; set; }
    
        /// <summary>
        /// Gets or sets custom subject alternative names.
        /// Custom Subject Alternative Name Settings. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonPropertyName("customSubjectAlternativeNames")]
        public IEnumerable<CustomSubjectAlternativeName> CustomSubjectAlternativeNames { get; set; }
    
        /// <summary>
        /// Gets or sets extended key usages.
        /// Extended Key Usage (EKU) settings. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonPropertyName("extendedKeyUsages")]
        public IEnumerable<ExtendedKeyUsage> ExtendedKeyUsages { get; set; }
    
        /// <summary>
        /// Gets or sets subject alternative name format string.
        /// Custom String that defines the AAD Attribute.
        /// </summary>
        [JsonPropertyName("subjectAlternativeNameFormatString")]
        public string SubjectAlternativeNameFormatString { get; set; }
    
        /// <summary>
        /// Gets or sets subject name format string.
        /// Custom format to use with SubjectNameFormat = Custom. Example: CN={{EmailAddress}},E={{EmailAddress}},OU=Enterprise Users,O=Contoso Corporation,L=Redmond,ST=WA,C=US
        /// </summary>
        [JsonPropertyName("subjectNameFormatString")]
        public string SubjectNameFormatString { get; set; }
    
        /// <summary>
        /// Gets or sets managed device certificate states.
        /// Certificate state for devices
        /// </summary>
        [JsonPropertyName("managedDeviceCertificateStates")]
        public IWindows10PkcsCertificateProfileManagedDeviceCertificateStatesCollectionPage ManagedDeviceCertificateStates { get; set; }

        /// <summary>
        /// Gets or sets managedDeviceCertificateStatesNextLink.
        /// </summary>
        [JsonPropertyName("managedDeviceCertificateStates@odata.nextLink")]
        public string ManagedDeviceCertificateStatesNextLink { get; set; }
    
    }
}

