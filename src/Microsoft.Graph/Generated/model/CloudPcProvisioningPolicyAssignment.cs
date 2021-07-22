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
    /// The type Cloud Pc Provisioning Policy Assignment.
    /// </summary>
    public partial class CloudPcProvisioningPolicyAssignment : Entity
    {
    
        /// <summary>
        /// Gets or sets target.
        /// The assignment target for the provisioning policy. Currently, the only target supported for this policy is a user group. For details, see cloudPcManagementGroupAssignmentTarget.
        /// </summary>
        [JsonPropertyName("target")]
        public CloudPcManagementAssignmentTarget Target { get; set; }
    
    }
}

