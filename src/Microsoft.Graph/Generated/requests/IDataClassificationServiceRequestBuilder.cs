// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IDataClassificationServiceRequestBuilder.
    /// </summary>
    public partial interface IDataClassificationServiceRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IDataClassificationServiceRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IDataClassificationServiceRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for ExactMatchDataStores.
        /// </summary>
        /// <returns>The <see cref="IDataClassificationServiceExactMatchDataStoresCollectionRequestBuilder"/>.</returns>
        IDataClassificationServiceExactMatchDataStoresCollectionRequestBuilder ExactMatchDataStores { get; }

        /// <summary>
        /// Gets the request builder for ClassifyFileJobs.
        /// </summary>
        /// <returns>The <see cref="IDataClassificationServiceClassifyFileJobsCollectionRequestBuilder"/>.</returns>
        IDataClassificationServiceClassifyFileJobsCollectionRequestBuilder ClassifyFileJobs { get; }

        /// <summary>
        /// Gets the request builder for ClassifyTextJobs.
        /// </summary>
        /// <returns>The <see cref="IDataClassificationServiceClassifyTextJobsCollectionRequestBuilder"/>.</returns>
        IDataClassificationServiceClassifyTextJobsCollectionRequestBuilder ClassifyTextJobs { get; }

        /// <summary>
        /// Gets the request builder for EvaluateDlpPoliciesJobs.
        /// </summary>
        /// <returns>The <see cref="IDataClassificationServiceEvaluateDlpPoliciesJobsCollectionRequestBuilder"/>.</returns>
        IDataClassificationServiceEvaluateDlpPoliciesJobsCollectionRequestBuilder EvaluateDlpPoliciesJobs { get; }

        /// <summary>
        /// Gets the request builder for EvaluateLabelJobs.
        /// </summary>
        /// <returns>The <see cref="IDataClassificationServiceEvaluateLabelJobsCollectionRequestBuilder"/>.</returns>
        IDataClassificationServiceEvaluateLabelJobsCollectionRequestBuilder EvaluateLabelJobs { get; }

        /// <summary>
        /// Gets the request builder for Jobs.
        /// </summary>
        /// <returns>The <see cref="IDataClassificationServiceJobsCollectionRequestBuilder"/>.</returns>
        IDataClassificationServiceJobsCollectionRequestBuilder Jobs { get; }

        /// <summary>
        /// Gets the request builder for SensitiveTypes.
        /// </summary>
        /// <returns>The <see cref="IDataClassificationServiceSensitiveTypesCollectionRequestBuilder"/>.</returns>
        IDataClassificationServiceSensitiveTypesCollectionRequestBuilder SensitiveTypes { get; }

        /// <summary>
        /// Gets the request builder for SensitivityLabels.
        /// </summary>
        /// <returns>The <see cref="IDataClassificationServiceSensitivityLabelsCollectionRequestBuilder"/>.</returns>
        IDataClassificationServiceSensitivityLabelsCollectionRequestBuilder SensitivityLabels { get; }

        /// <summary>
        /// Gets the request builder for ExactMatchUploadAgents.
        /// </summary>
        /// <returns>The <see cref="IDataClassificationServiceExactMatchUploadAgentsCollectionRequestBuilder"/>.</returns>
        IDataClassificationServiceExactMatchUploadAgentsCollectionRequestBuilder ExactMatchUploadAgents { get; }
    
        /// <summary>
        /// Gets the request builder for DataClassificationServiceClassifyFile.
        /// </summary>
        /// <returns>The <see cref="IDataClassificationServiceClassifyFileRequestBuilder"/>.</returns>
        IDataClassificationServiceClassifyFileRequestBuilder ClassifyFile(
            Stream file = null,
            IEnumerable<string> sensitiveTypeIds = null);

        /// <summary>
        /// Gets the request builder for DataClassificationServiceClassifyExactMatches.
        /// </summary>
        /// <returns>The <see cref="IDataClassificationServiceClassifyExactMatchesRequestBuilder"/>.</returns>
        IDataClassificationServiceClassifyExactMatchesRequestBuilder ClassifyExactMatches(
            IEnumerable<ContentClassification> contentClassifications,
            string text = null,
            string timeoutInMs = null,
            IEnumerable<string> sensitiveTypeIds = null);
    
    }
}
