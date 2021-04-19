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
    /// The type Connector.
    /// </summary>
    public partial class Connector : Entity
    {
    
		///<summary>
		/// The Connector constructor
		///</summary>
        public Connector()
        {
            this.ODataType = "microsoft.graph.connector";
        }
	
        /// <summary>
        /// Gets or sets external ip.
        /// The external IP address as detected by the the connector server. Read-only.
        /// </summary>
        [JsonPropertyName("externalIp")]
        public string ExternalIp { get; set; }
    
        /// <summary>
        /// Gets or sets machine name.
        /// The machine name the connector is installed and running on.
        /// </summary>
        [JsonPropertyName("machineName")]
        public string MachineName { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// Indicates the status of the connector. Possible values are: active, inactive. Read-only.
        /// </summary>
        [JsonPropertyName("status")]
        public ConnectorStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets member of.
        /// The connectorGroup that the connector is a member of. Read-only.
        /// </summary>
        [JsonPropertyName("memberOf")]
        public IConnectorMemberOfCollectionPage MemberOf { get; set; }

        /// <summary>
        /// Gets or sets memberOfNextLink.
        /// </summary>
        [JsonPropertyName("memberOf@odata.nextLink")]
        public string MemberOfNextLink { get; set; }
    
    }
}

