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
    /// The type Strong Authentication Detail.
    /// </summary>
    public partial class StrongAuthenticationDetail : Entity
    {
    
        /// <summary>
        /// Gets or sets encrypted pin hash history.
        /// </summary>
        [JsonPropertyName("encryptedPinHashHistory")]
        public byte[] EncryptedPinHashHistory { get; set; }
    
        /// <summary>
        /// Gets or sets proofup time.
        /// </summary>
        [JsonPropertyName("proofupTime")]
        public Int64? ProofupTime { get; set; }
    
    }
}

