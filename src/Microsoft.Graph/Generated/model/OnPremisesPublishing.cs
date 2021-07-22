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
    /// The type OnPremisesPublishing.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<OnPremisesPublishing>))]
    public partial class OnPremisesPublishing
    {

        /// <summary>
        /// Gets or sets alternateUrl.
        /// If you are configuring a traffic manager in front of multiple App Proxy applications, the alternateUrl is the user-friendly URL that will point to the traffic manager.
        /// </summary>
        [JsonPropertyName("alternateUrl")]
        public string AlternateUrl { get; set; }
    
        /// <summary>
        /// Gets or sets applicationServerTimeout.
        /// The duration the connector will wait for a response from the backend application before closing the connection. Possible values are default, long. When set to default, the backend application timeout has a length of 85 seconds. When set to long, the backend timeout is increased to 180 seconds. Use long if your server takes more than 85 seconds to respond to requests or if you are unable to access the application and the error status is 'Backend Timeout'. Default value is default.
        /// </summary>
        [JsonPropertyName("applicationServerTimeout")]
        public string ApplicationServerTimeout { get; set; }
    
        /// <summary>
        /// Gets or sets applicationType.
        /// Indicates if this application is an Application Proxy configured application. This is pre-set by the system. Read-only.
        /// </summary>
        [JsonPropertyName("applicationType")]
        public string ApplicationType { get; set; }
    
        /// <summary>
        /// Gets or sets externalAuthenticationType.
        /// Details the pre-authentication setting for the application. Pre-authentication enforces that users must authenticate before accessing the app. Passthru does not require authentication. Possible values are: passthru, aadPreAuthentication.
        /// </summary>
        [JsonPropertyName("externalAuthenticationType")]
        public ExternalAuthenticationType? ExternalAuthenticationType { get; set; }
    
        /// <summary>
        /// Gets or sets externalUrl.
        /// The published external url for the application. For example, https://intranet-contoso.msappproxy.net/.
        /// </summary>
        [JsonPropertyName("externalUrl")]
        public string ExternalUrl { get; set; }
    
        /// <summary>
        /// Gets or sets internalUrl.
        /// The internal url of the application. For example, https://intranet/.
        /// </summary>
        [JsonPropertyName("internalUrl")]
        public string InternalUrl { get; set; }
    
        /// <summary>
        /// Gets or sets isBackendCertificateValidationEnabled.
        /// Indicates whether backend SSL certificate validation is enabled for the application. For all new Application Proxy apps, the property will be set to true by default. For all existing apps, the property will be set to false.
        /// </summary>
        [JsonPropertyName("isBackendCertificateValidationEnabled")]
        public bool? IsBackendCertificateValidationEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets isHttpOnlyCookieEnabled.
        /// Indicates if the HTTPOnly cookie flag should be set in the HTTP response headers. Set this value to true to have Application Proxy cookies include the HTTPOnly flag in the HTTP response headers. If using Remote Desktop Services, set this value to False. Default value is false.
        /// </summary>
        [JsonPropertyName("isHttpOnlyCookieEnabled")]
        public bool? IsHttpOnlyCookieEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets isOnPremPublishingEnabled.
        /// Indicates if the application is currently being published via Application Proxy or not. This is pre-set by the system. Read-only.
        /// </summary>
        [JsonPropertyName("isOnPremPublishingEnabled")]
        public bool? IsOnPremPublishingEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets isPersistentCookieEnabled.
        /// Indicates if the Persistent cookie flag should be set in the HTTP response headers. Keep this value set to false. Only use this setting for applications that can't share cookies between processes. For more information about cookie settings, see Cookie settings for accessing on-premises applications in Azure Active Directory. Default value is false.
        /// </summary>
        [JsonPropertyName("isPersistentCookieEnabled")]
        public bool? IsPersistentCookieEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets isSecureCookieEnabled.
        /// Indicates if the Secure cookie flag should be set in the HTTP response headers. Set this value to true to transmit cookies over a secure channel such as an encrypted HTTPS request. Default value is true.
        /// </summary>
        [JsonPropertyName("isSecureCookieEnabled")]
        public bool? IsSecureCookieEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets isTranslateHostHeaderEnabled.
        /// Indicates if the application should translate urls in the reponse headers. Keep this value as true unless your application required the original host header in the authentication request. Default value is true.
        /// </summary>
        [JsonPropertyName("isTranslateHostHeaderEnabled")]
        public bool? IsTranslateHostHeaderEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets isTranslateLinksInBodyEnabled.
        /// Indicates if the application should translate urls in the application body. Keep this value as false unless you have hardcoded HTML links to other on-premises applications and don't use custom domains. For more information, see Link translation with Application Proxy. Default value is false.
        /// </summary>
        [JsonPropertyName("isTranslateLinksInBodyEnabled")]
        public bool? IsTranslateLinksInBodyEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets singleSignOnSettings.
        /// Represents the single sign-on configuration for the on-premises application.
        /// </summary>
        [JsonPropertyName("singleSignOnSettings")]
        public OnPremisesPublishingSingleSignOn SingleSignOnSettings { get; set; }
    
        /// <summary>
        /// Gets or sets useAlternateUrlForTranslationAndRedirect.
        /// </summary>
        [JsonPropertyName("useAlternateUrlForTranslationAndRedirect")]
        public bool? UseAlternateUrlForTranslationAndRedirect { get; set; }
    
        /// <summary>
        /// Gets or sets verifiedCustomDomainCertificatesMetadata.
        /// Details of the certificate associated with the application when a custom domain is in use. null when using the default domain. Read-only.
        /// </summary>
        [JsonPropertyName("verifiedCustomDomainCertificatesMetadata")]
        public VerifiedCustomDomainCertificatesMetadata VerifiedCustomDomainCertificatesMetadata { get; set; }
    
        /// <summary>
        /// Gets or sets verifiedCustomDomainKeyCredential.
        /// The associated key credential for the custom domain used.
        /// </summary>
        [JsonPropertyName("verifiedCustomDomainKeyCredential")]
        public KeyCredential VerifiedCustomDomainKeyCredential { get; set; }
    
        /// <summary>
        /// Gets or sets verifiedCustomDomainPasswordCredential.
        /// The associated password credential for the custom domain used.
        /// </summary>
        [JsonPropertyName("verifiedCustomDomainPasswordCredential")]
        public PasswordCredential VerifiedCustomDomainPasswordCredential { get; set; }
    
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
