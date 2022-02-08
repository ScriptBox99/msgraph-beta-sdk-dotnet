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
    /// The type LogicAppTriggerEndpointConfiguration.
    /// </summary>
    public partial class LogicAppTriggerEndpointConfiguration : CustomExtensionEndpointConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogicAppTriggerEndpointConfiguration"/> class.
        /// </summary>
        public LogicAppTriggerEndpointConfiguration()
        {
            this.ODataType = "microsoft.graph.logicAppTriggerEndpointConfiguration";
        }

        /// <summary>
        /// Gets or sets logicAppWorkflowName.
        /// </summary>
        [JsonPropertyName("logicAppWorkflowName")]
        public string LogicAppWorkflowName { get; set; }
    
        /// <summary>
        /// Gets or sets resourceGroupName.
        /// </summary>
        [JsonPropertyName("resourceGroupName")]
        public string ResourceGroupName { get; set; }
    
        /// <summary>
        /// Gets or sets subscriptionId.
        /// </summary>
        [JsonPropertyName("subscriptionId")]
        public string SubscriptionId { get; set; }
    
    }
}
