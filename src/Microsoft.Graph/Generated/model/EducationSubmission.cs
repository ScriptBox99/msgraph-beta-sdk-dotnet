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
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Education Submission.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class EducationSubmission : Entity
    {
    
		///<summary>
		/// The EducationSubmission constructor
		///</summary>
        public EducationSubmission()
        {
            this.ODataType = "microsoft.graph.educationSubmission";
        }
	
        /// <summary>
        /// Gets or sets recipient.
        /// Who this submission is assigned to.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recipient", Required = Newtonsoft.Json.Required.Default)]
        public EducationSubmissionRecipient Recipient { get; set; }
    
        /// <summary>
        /// Gets or sets resources folder url.
        /// Folder where all file resources for this submission need to be stored.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resourcesFolderUrl", Required = Newtonsoft.Json.Required.Default)]
        public string ResourcesFolderUrl { get; set; }
    
        /// <summary>
        /// Gets or sets returned by.
        /// User who moved the status of this submission to returned.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "returnedBy", Required = Newtonsoft.Json.Required.Default)]
        public IdentitySet ReturnedBy { get; set; }
    
        /// <summary>
        /// Gets or sets returned date time.
        /// Moment in time when the submission was returned. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "returnedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ReturnedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// Read-Only. Possible values are: working, submitted, released, returned.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public EducationSubmissionStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets submitted by.
        /// User who moved the resource into the submitted state.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "submittedBy", Required = Newtonsoft.Json.Required.Default)]
        public IdentitySet SubmittedBy { get; set; }
    
        /// <summary>
        /// Gets or sets submitted date time.
        /// Moment in time when the submission was moved into the submitted state. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "submittedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? SubmittedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets unsubmitted by.
        /// User who moved the resource from submitted into the working state.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unsubmittedBy", Required = Newtonsoft.Json.Required.Default)]
        public IdentitySet UnsubmittedBy { get; set; }
    
        /// <summary>
        /// Gets or sets unsubmitted date time.
        /// Moment in time when the submission was moved from submitted into the working state. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unsubmittedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? UnsubmittedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets outcomes.
        /// Read-Write. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "outcomes", Required = Newtonsoft.Json.Required.Default)]
        public IEducationSubmissionOutcomesCollectionPage Outcomes { get; set; }
    
        /// <summary>
        /// Gets or sets resources.
        /// Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resources", Required = Newtonsoft.Json.Required.Default)]
        public IEducationSubmissionResourcesCollectionPage Resources { get; set; }
    
        /// <summary>
        /// Gets or sets submitted resources.
        /// Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "submittedResources", Required = Newtonsoft.Json.Required.Default)]
        public IEducationSubmissionSubmittedResourcesCollectionPage SubmittedResources { get; set; }
    
    }
}

