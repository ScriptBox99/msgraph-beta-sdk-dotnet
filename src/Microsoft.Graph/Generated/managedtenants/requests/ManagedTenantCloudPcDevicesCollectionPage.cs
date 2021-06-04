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
    /// The type ManagedTenantCloudPcDevicesCollectionPage.
    /// </summary>
    public partial class ManagedTenantCloudPcDevicesCollectionPage : Microsoft.Graph.CollectionPage<CloudPcDevice>, IManagedTenantCloudPcDevicesCollectionPage
    {
        /// <summary>
        /// Gets the next page <see cref="IManagedTenantCloudPcDevicesCollectionRequest"/> instance.
        /// </summary>
        public IManagedTenantCloudPcDevicesCollectionRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(Microsoft.Graph.IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new ManagedTenantCloudPcDevicesCollectionRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}
