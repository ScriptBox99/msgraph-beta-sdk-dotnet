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
    /// The type Android Work Profile Eas Email Profile Base.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AndroidWorkProfileEasEmailProfileBase>))]
    public partial class AndroidWorkProfileEasEmailProfileBase : DeviceConfiguration
    {
    
		///<summary>
		/// The internal AndroidWorkProfileEasEmailProfileBase constructor
		///</summary>
        protected internal AndroidWorkProfileEasEmailProfileBase()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets authentication method.
        /// Authentication method for Exchange ActiveSync. Possible values are: usernameAndPassword, certificate, derivedCredential.
        /// </summary>
        [JsonPropertyName("authenticationMethod")]
        public EasAuthenticationMethod? AuthenticationMethod { get; set; }
    
        /// <summary>
        /// Gets or sets duration of email to sync.
        /// Duration of time email should be synced to. Possible values are: userDefined, oneDay, threeDays, oneWeek, twoWeeks, oneMonth, unlimited.
        /// </summary>
        [JsonPropertyName("durationOfEmailToSync")]
        public EmailSyncDuration? DurationOfEmailToSync { get; set; }
    
        /// <summary>
        /// Gets or sets email address source.
        /// Email attribute that is picked from AAD and injected into this profile before installing on the device. Possible values are: userPrincipalName, primarySmtpAddress.
        /// </summary>
        [JsonPropertyName("emailAddressSource")]
        public UserEmailSource? EmailAddressSource { get; set; }
    
        /// <summary>
        /// Gets or sets host name.
        /// Exchange location (URL) that the mail app connects to.
        /// </summary>
        [JsonPropertyName("hostName")]
        public string HostName { get; set; }
    
        /// <summary>
        /// Gets or sets require ssl.
        /// Indicates whether or not to use SSL.
        /// </summary>
        [JsonPropertyName("requireSsl")]
        public bool? RequireSsl { get; set; }
    
        /// <summary>
        /// Gets or sets username source.
        /// Username attribute that is picked from AAD and injected into this profile before installing on the device. Possible values are: username, userPrincipalName, samAccountName, primarySmtpAddress.
        /// </summary>
        [JsonPropertyName("usernameSource")]
        public AndroidUsernameSource? UsernameSource { get; set; }
    
        /// <summary>
        /// Gets or sets identity certificate.
        /// Identity certificate.
        /// </summary>
        [JsonPropertyName("identityCertificate")]
        public AndroidWorkProfileCertificateProfileBase IdentityCertificate { get; set; }
    
    }
}

