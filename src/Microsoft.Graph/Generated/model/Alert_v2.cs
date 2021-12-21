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
    /// The type Alert_v2.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Alert_v2>))]
    public partial class Alert_v2 : Entity
    {
    
        /// <summary>
        /// Gets or sets aad tenant id.
        /// </summary>
        [JsonPropertyName("aadTenantId")]
        public string AadTenantId { get; set; }
    
        /// <summary>
        /// Gets or sets actor display name.
        /// </summary>
        [JsonPropertyName("actorDisplayName")]
        public string ActorDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets alert web url.
        /// </summary>
        [JsonPropertyName("alertWebUrl")]
        public string AlertWebUrl { get; set; }
    
        /// <summary>
        /// Gets or sets assigned to.
        /// </summary>
        [JsonPropertyName("assignedTo")]
        public string AssignedTo { get; set; }
    
        /// <summary>
        /// Gets or sets category.
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; }
    
        /// <summary>
        /// Gets or sets classification.
        /// </summary>
        [JsonPropertyName("classification")]
        public AlertClassification_v2? Classification { get; set; }
    
        /// <summary>
        /// Gets or sets comments.
        /// </summary>
        [JsonPropertyName("comments")]
        public IEnumerable<AlertComment_v2> Comments { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets detector id.
        /// </summary>
        [JsonPropertyName("detectorId")]
        public string DetectorId { get; set; }
    
        /// <summary>
        /// Gets or sets determination.
        /// </summary>
        [JsonPropertyName("determination")]
        public AlertDetermination_v2? Determination { get; set; }
    
        /// <summary>
        /// Gets or sets first activity date time.
        /// </summary>
        [JsonPropertyName("firstActivityDateTime")]
        public DateTimeOffset? FirstActivityDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets incident id.
        /// </summary>
        [JsonPropertyName("incidentId")]
        public string IncidentId { get; set; }
    
        /// <summary>
        /// Gets or sets incident web url.
        /// </summary>
        [JsonPropertyName("incidentWebUrl")]
        public string IncidentWebUrl { get; set; }
    
        /// <summary>
        /// Gets or sets last activity date time.
        /// </summary>
        [JsonPropertyName("lastActivityDateTime")]
        public DateTimeOffset? LastActivityDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last update date time.
        /// </summary>
        [JsonPropertyName("lastUpdateDateTime")]
        public DateTimeOffset? LastUpdateDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets mitre techniques.
        /// </summary>
        [JsonPropertyName("mitreTechniques")]
        public IEnumerable<string> MitreTechniques { get; set; }
    
        /// <summary>
        /// Gets or sets provider alert id.
        /// </summary>
        [JsonPropertyName("providerAlertId")]
        public string ProviderAlertId { get; set; }
    
        /// <summary>
        /// Gets or sets resolved date time.
        /// </summary>
        [JsonPropertyName("resolvedDateTime")]
        public DateTimeOffset? ResolvedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets service source.
        /// </summary>
        [JsonPropertyName("serviceSource")]
        public ServiceSource? ServiceSource { get; set; }
    
        /// <summary>
        /// Gets or sets severity.
        /// </summary>
        [JsonPropertyName("severity")]
        public AlertSeverity_v2? Severity { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// </summary>
        [JsonPropertyName("status")]
        public AlertStatus_v2? Status { get; set; }
    
        /// <summary>
        /// Gets or sets threat display name.
        /// </summary>
        [JsonPropertyName("threatDisplayName")]
        public string ThreatDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets threat family name.
        /// </summary>
        [JsonPropertyName("threatFamilyName")]
        public string ThreatFamilyName { get; set; }
    
        /// <summary>
        /// Gets or sets title.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    
    }
}

