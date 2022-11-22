// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IManagedTenantManagementTemplateStepTenantSummariesCollectionRequestBuilder.
    /// </summary>
    public partial interface IManagedTenantManagementTemplateStepTenantSummariesCollectionRequestBuilder : Microsoft.Graph.IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IManagedTenantManagementTemplateStepTenantSummariesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IManagedTenantManagementTemplateStepTenantSummariesCollectionRequest Request(IEnumerable<Microsoft.Graph.Option> options);

        /// <summary>
        /// Gets an <see cref="IManagementTemplateStepTenantSummaryRequestBuilder"/> for the specified ManagementTemplateStepTenantSummary.
        /// </summary>
        /// <param name="id">The ID for the ManagementTemplateStepTenantSummary.</param>
        /// <returns>The <see cref="IManagementTemplateStepTenantSummaryRequestBuilder"/>.</returns>
        IManagementTemplateStepTenantSummaryRequestBuilder this[string id] { get; }

        
    }
}
