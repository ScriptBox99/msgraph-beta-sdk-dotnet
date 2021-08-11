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
    /// The type Authentication.
    /// </summary>
    public partial class Authentication : Entity
    {
    
        /// <summary>
        /// Gets or sets email methods.
        /// </summary>
        [JsonPropertyName("emailMethods")]
        public IAuthenticationEmailMethodsCollectionPage EmailMethods { get; set; }

        /// <summary>
        /// Gets or sets emailMethodsNextLink.
        /// </summary>
        [JsonPropertyName("emailMethods@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string EmailMethodsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets fido2methods.
        /// </summary>
        [JsonPropertyName("fido2Methods")]
        public IAuthenticationFido2MethodsCollectionPage Fido2Methods { get; set; }

        /// <summary>
        /// Gets or sets fido2MethodsNextLink.
        /// </summary>
        [JsonPropertyName("fido2Methods@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string Fido2MethodsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets methods.
        /// </summary>
        [JsonPropertyName("methods")]
        public IAuthenticationMethodsCollectionPage Methods { get; set; }

        /// <summary>
        /// Gets or sets methodsNextLink.
        /// </summary>
        [JsonPropertyName("methods@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string MethodsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets microsoft authenticator methods.
        /// </summary>
        [Obsolete("")]
        [JsonPropertyName("microsoftAuthenticatorMethods")]
        public IAuthenticationMicrosoftAuthenticatorMethodsCollectionPage MicrosoftAuthenticatorMethods { get; set; }

        /// <summary>
        /// Gets or sets microsoftAuthenticatorMethodsNextLink.
        /// </summary>
        [JsonPropertyName("microsoftAuthenticatorMethods@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string MicrosoftAuthenticatorMethodsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets operations.
        /// </summary>
        [JsonPropertyName("operations")]
        public IAuthenticationOperationsCollectionPage Operations { get; set; }

        /// <summary>
        /// Gets or sets operationsNextLink.
        /// </summary>
        [JsonPropertyName("operations@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string OperationsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets passwordless microsoft authenticator methods.
        /// </summary>
        [JsonPropertyName("passwordlessMicrosoftAuthenticatorMethods")]
        public IAuthenticationPasswordlessMicrosoftAuthenticatorMethodsCollectionPage PasswordlessMicrosoftAuthenticatorMethods { get; set; }

        /// <summary>
        /// Gets or sets passwordlessMicrosoftAuthenticatorMethodsNextLink.
        /// </summary>
        [JsonPropertyName("passwordlessMicrosoftAuthenticatorMethods@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string PasswordlessMicrosoftAuthenticatorMethodsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets password methods.
        /// </summary>
        [JsonPropertyName("passwordMethods")]
        public IAuthenticationPasswordMethodsCollectionPage PasswordMethods { get; set; }

        /// <summary>
        /// Gets or sets passwordMethodsNextLink.
        /// </summary>
        [JsonPropertyName("passwordMethods@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string PasswordMethodsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets phone methods.
        /// </summary>
        [JsonPropertyName("phoneMethods")]
        public IAuthenticationPhoneMethodsCollectionPage PhoneMethods { get; set; }

        /// <summary>
        /// Gets or sets phoneMethodsNextLink.
        /// </summary>
        [JsonPropertyName("phoneMethods@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string PhoneMethodsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets temporary access pass methods.
        /// </summary>
        [JsonPropertyName("temporaryAccessPassMethods")]
        public IAuthenticationTemporaryAccessPassMethodsCollectionPage TemporaryAccessPassMethods { get; set; }

        /// <summary>
        /// Gets or sets temporaryAccessPassMethodsNextLink.
        /// </summary>
        [JsonPropertyName("temporaryAccessPassMethods@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string TemporaryAccessPassMethodsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets windows hello for business methods.
        /// </summary>
        [JsonPropertyName("windowsHelloForBusinessMethods")]
        public IAuthenticationWindowsHelloForBusinessMethodsCollectionPage WindowsHelloForBusinessMethods { get; set; }

        /// <summary>
        /// Gets or sets windowsHelloForBusinessMethodsNextLink.
        /// </summary>
        [JsonPropertyName("windowsHelloForBusinessMethods@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string WindowsHelloForBusinessMethodsNextLink { get; set; }
    
    }
}

