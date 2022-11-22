// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Management Template Step Tenant Summary.
    /// </summary>
    public partial class ManagementTemplateStepTenantSummary : Microsoft.Graph.Entity
    {
    
        /// <summary>
        /// Gets or sets assigned tenants count.
        /// </summary>
        [JsonPropertyName("assignedTenantsCount")]
        public Int32? AssignedTenantsCount { get; set; }
    
        /// <summary>
        /// Gets or sets compliant tenants count.
        /// </summary>
        [JsonPropertyName("compliantTenantsCount")]
        public Int32? CompliantTenantsCount { get; set; }
    
        /// <summary>
        /// Gets or sets created by user id.
        /// </summary>
        [JsonPropertyName("createdByUserId")]
        public string CreatedByUserId { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets dismissed tenants count.
        /// </summary>
        [JsonPropertyName("dismissedTenantsCount")]
        public Int32? DismissedTenantsCount { get; set; }
    
        /// <summary>
        /// Gets or sets ineligible tenants count.
        /// </summary>
        [JsonPropertyName("ineligibleTenantsCount")]
        public Int32? IneligibleTenantsCount { get; set; }
    
        /// <summary>
        /// Gets or sets last action by user id.
        /// </summary>
        [JsonPropertyName("lastActionByUserId")]
        public string LastActionByUserId { get; set; }
    
        /// <summary>
        /// Gets or sets last action date time.
        /// </summary>
        [JsonPropertyName("lastActionDateTime")]
        public DateTimeOffset? LastActionDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets management template collection display name.
        /// </summary>
        [JsonPropertyName("managementTemplateCollectionDisplayName")]
        public string ManagementTemplateCollectionDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets management template collection id.
        /// </summary>
        [JsonPropertyName("managementTemplateCollectionId")]
        public string ManagementTemplateCollectionId { get; set; }
    
        /// <summary>
        /// Gets or sets management template display name.
        /// </summary>
        [JsonPropertyName("managementTemplateDisplayName")]
        public string ManagementTemplateDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets management template id.
        /// </summary>
        [JsonPropertyName("managementTemplateId")]
        public string ManagementTemplateId { get; set; }
    
        /// <summary>
        /// Gets or sets management template step display name.
        /// </summary>
        [JsonPropertyName("managementTemplateStepDisplayName")]
        public string ManagementTemplateStepDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets management template step id.
        /// </summary>
        [JsonPropertyName("managementTemplateStepId")]
        public string ManagementTemplateStepId { get; set; }
    
        /// <summary>
        /// Gets or sets not compliant tenants count.
        /// </summary>
        [JsonPropertyName("notCompliantTenantsCount")]
        public Int32? NotCompliantTenantsCount { get; set; }
    
    }
}

