// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionPage.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;

    /// <summary>
    /// The type ManagedTenantManagementTemplateStepTenantSummariesCollectionPage.
    /// </summary>
    public partial class ManagedTenantManagementTemplateStepTenantSummariesCollectionPage : Microsoft.Graph.CollectionPage<ManagementTemplateStepTenantSummary>, IManagedTenantManagementTemplateStepTenantSummariesCollectionPage
    {
        /// <summary>
        /// Gets the next page <see cref="IManagedTenantManagementTemplateStepTenantSummariesCollectionRequest"/> instance.
        /// </summary>
        public IManagedTenantManagementTemplateStepTenantSummariesCollectionRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(Microsoft.Graph.IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new ManagedTenantManagementTemplateStepTenantSummariesCollectionRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}
