// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum ClientCredentialType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ClientCredentialType
    {
    
        /// <summary>
        /// None
        /// </summary>
        None = 0,
	
        /// <summary>
        /// Client Secret
        /// </summary>
        ClientSecret = 1,
	
        /// <summary>
        /// Client Assertion
        /// </summary>
        ClientAssertion = 2,
	
        /// <summary>
        /// Federated Identity Credential
        /// </summary>
        FederatedIdentityCredential = 3,
	
        /// <summary>
        /// Managed Identity
        /// </summary>
        ManagedIdentity = 4,
	
        /// <summary>
        /// Certificate
        /// </summary>
        Certificate = 5,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 6,
	
    }
}
