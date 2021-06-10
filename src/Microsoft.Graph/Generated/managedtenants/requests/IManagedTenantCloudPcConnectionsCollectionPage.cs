// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionPage.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;

    using Newtonsoft.Json;

    /// <summary>
    /// The interface IManagedTenantCloudPcConnectionsCollectionPage.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.InterfaceConverter<ManagedTenantCloudPcConnectionsCollectionPage>))]
    public interface IManagedTenantCloudPcConnectionsCollectionPage : Microsoft.Graph.ICollectionPage<CloudPcConnection>
    {
        /// <summary>
        /// Gets the next page <see cref="IManagedTenantCloudPcConnectionsCollectionRequest"/> instance.
        /// </summary>
        IManagedTenantCloudPcConnectionsCollectionRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(Microsoft.Graph.IBaseClient client, string nextPageLinkString);
    }
}
