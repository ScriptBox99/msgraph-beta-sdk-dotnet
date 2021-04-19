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
    /// The type Data Classification Service.
    /// </summary>
    public partial class DataClassificationService : Entity
    {
    
		///<summary>
		/// The DataClassificationService constructor
		///</summary>
        public DataClassificationService()
        {
            this.ODataType = "microsoft.graph.dataClassificationService";
        }
	
        /// <summary>
        /// Gets or sets exact match data stores.
        /// </summary>
        [JsonPropertyName("exactMatchDataStores")]
        public IDataClassificationServiceExactMatchDataStoresCollectionPage ExactMatchDataStores { get; set; }

        /// <summary>
        /// Gets or sets exactMatchDataStoresNextLink.
        /// </summary>
        [JsonPropertyName("exactMatchDataStores@odata.nextLink")]
        public string ExactMatchDataStoresNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets classify file.
        /// </summary>
        [JsonPropertyName("classifyFile")]
        public IDataClassificationServiceClassifyFileCollectionPage ClassifyFile { get; set; }

        /// <summary>
        /// Gets or sets classifyFileNextLink.
        /// </summary>
        [JsonPropertyName("classifyFile@odata.nextLink")]
        public string ClassifyFileNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets classify file jobs.
        /// </summary>
        [JsonPropertyName("classifyFileJobs")]
        public IDataClassificationServiceClassifyFileJobsCollectionPage ClassifyFileJobs { get; set; }

        /// <summary>
        /// Gets or sets classifyFileJobsNextLink.
        /// </summary>
        [JsonPropertyName("classifyFileJobs@odata.nextLink")]
        public string ClassifyFileJobsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets classify text.
        /// </summary>
        [JsonPropertyName("classifyText")]
        public IDataClassificationServiceClassifyTextCollectionPage ClassifyText { get; set; }

        /// <summary>
        /// Gets or sets classifyTextNextLink.
        /// </summary>
        [JsonPropertyName("classifyText@odata.nextLink")]
        public string ClassifyTextNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets classify text jobs.
        /// </summary>
        [JsonPropertyName("classifyTextJobs")]
        public IDataClassificationServiceClassifyTextJobsCollectionPage ClassifyTextJobs { get; set; }

        /// <summary>
        /// Gets or sets classifyTextJobsNextLink.
        /// </summary>
        [JsonPropertyName("classifyTextJobs@odata.nextLink")]
        public string ClassifyTextJobsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets evaluate dlp policies jobs.
        /// </summary>
        [JsonPropertyName("evaluateDlpPoliciesJobs")]
        public IDataClassificationServiceEvaluateDlpPoliciesJobsCollectionPage EvaluateDlpPoliciesJobs { get; set; }

        /// <summary>
        /// Gets or sets evaluateDlpPoliciesJobsNextLink.
        /// </summary>
        [JsonPropertyName("evaluateDlpPoliciesJobs@odata.nextLink")]
        public string EvaluateDlpPoliciesJobsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets evaluate label jobs.
        /// </summary>
        [JsonPropertyName("evaluateLabelJobs")]
        public IDataClassificationServiceEvaluateLabelJobsCollectionPage EvaluateLabelJobs { get; set; }

        /// <summary>
        /// Gets or sets evaluateLabelJobsNextLink.
        /// </summary>
        [JsonPropertyName("evaluateLabelJobs@odata.nextLink")]
        public string EvaluateLabelJobsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets jobs.
        /// </summary>
        [JsonPropertyName("jobs")]
        public IDataClassificationServiceJobsCollectionPage Jobs { get; set; }

        /// <summary>
        /// Gets or sets jobsNextLink.
        /// </summary>
        [JsonPropertyName("jobs@odata.nextLink")]
        public string JobsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets sensitive types.
        /// </summary>
        [JsonPropertyName("sensitiveTypes")]
        public IDataClassificationServiceSensitiveTypesCollectionPage SensitiveTypes { get; set; }

        /// <summary>
        /// Gets or sets sensitiveTypesNextLink.
        /// </summary>
        [JsonPropertyName("sensitiveTypes@odata.nextLink")]
        public string SensitiveTypesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets sensitivity labels.
        /// </summary>
        [JsonPropertyName("sensitivityLabels")]
        public IDataClassificationServiceSensitivityLabelsCollectionPage SensitivityLabels { get; set; }

        /// <summary>
        /// Gets or sets sensitivityLabelsNextLink.
        /// </summary>
        [JsonPropertyName("sensitivityLabels@odata.nextLink")]
        public string SensitivityLabelsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets exact match upload agents.
        /// </summary>
        [JsonPropertyName("exactMatchUploadAgents")]
        public IDataClassificationServiceExactMatchUploadAgentsCollectionPage ExactMatchUploadAgents { get; set; }

        /// <summary>
        /// Gets or sets exactMatchUploadAgentsNextLink.
        /// </summary>
        [JsonPropertyName("exactMatchUploadAgents@odata.nextLink")]
        public string ExactMatchUploadAgentsNextLink { get; set; }
    
    }
}

