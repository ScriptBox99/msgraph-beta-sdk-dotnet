// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ManagedTenantTenantsCollectionRequestBuilder.
    /// </summary>
    public partial class ManagedTenantTenantsCollectionRequestBuilder : Microsoft.Graph.BaseRequestBuilder, IManagedTenantTenantsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ManagedTenantTenantsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public ManagedTenantTenantsCollectionRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IManagedTenantTenantsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IManagedTenantTenantsCollectionRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new ManagedTenantTenantsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ITenantRequestBuilder"/> for the specified ManagedTenantTenant.
        /// </summary>
        /// <param name="id">The ID for the ManagedTenantTenant.</param>
        /// <returns>The <see cref="ITenantRequestBuilder"/>.</returns>
        public ITenantRequestBuilder this[string id]
        {
            get
            {
                return new TenantRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
