// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type ManagementActionDeploymentStatus.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<ManagementActionDeploymentStatus>))]
    public partial class ManagementActionDeploymentStatus
    {

        /// <summary>
        /// Gets or sets managementActionId.
        /// The identifier for the management action. Required. Read-only.
        /// </summary>
        [JsonPropertyName("managementActionId")]
        public string ManagementActionId { get; set; }
    
        /// <summary>
        /// Gets or sets managementTemplateId.
        /// The management template identifier that was used to generate the management action. Required. Read-only.
        /// </summary>
        [JsonPropertyName("managementTemplateId")]
        public string ManagementTemplateId { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// The status of the management action. Possible values are: toAddress, completed, error, timeOut, inProgress, planned, resolvedBy3rdParty, resolvedThroughAlternateMitigation, riskAccepted, unknownFutureValue. Required.
        /// </summary>
        [JsonPropertyName("status")]
        public ManagementActionStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets workloadActionDeploymentStatuses.
        /// The collection of workload action deployment statues for the given management action. Optional.
        /// </summary>
        [JsonPropertyName("workloadActionDeploymentStatuses")]
        public IEnumerable<WorkloadActionDeploymentStatus> WorkloadActionDeploymentStatuses { get; set; }
    
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
