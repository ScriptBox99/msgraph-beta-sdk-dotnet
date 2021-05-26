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
    /// The type Domain Dns Mx Record.
    /// </summary>
    public partial class DomainDnsMxRecord : DomainDnsRecord
    {
    
        ///<summary>
        /// The DomainDnsMxRecord constructor
        ///</summary>
        public DomainDnsMxRecord()
        {
            this.ODataType = "microsoft.graph.domainDnsMxRecord";
        }
    
        /// <summary>
        /// Gets or sets mail exchange.
        /// Value used when configuring the answer/destination/value of the MX record at the DNS host.
        /// </summary>
        [JsonPropertyName("mailExchange")]
        public string MailExchange { get; set; }
    
        /// <summary>
        /// Gets or sets preference.
        /// Value used when configuring the Preference/Priority property of the MX record at the DNS host.
        /// </summary>
        [JsonPropertyName("preference")]
        public Int32? Preference { get; set; }
    
    }
}

