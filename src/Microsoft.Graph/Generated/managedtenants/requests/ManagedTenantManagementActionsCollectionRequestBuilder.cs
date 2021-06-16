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
    /// The type ManagedTenantManagementActionsCollectionRequestBuilder.
    /// </summary>
    public partial class ManagedTenantManagementActionsCollectionRequestBuilder : Microsoft.Graph.BaseRequestBuilder, IManagedTenantManagementActionsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ManagedTenantManagementActionsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public ManagedTenantManagementActionsCollectionRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IManagedTenantManagementActionsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IManagedTenantManagementActionsCollectionRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new ManagedTenantManagementActionsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IManagementActionRequestBuilder"/> for the specified ManagedTenantManagementAction.
        /// </summary>
        /// <param name="id">The ID for the ManagedTenantManagementAction.</param>
        /// <returns>The <see cref="IManagementActionRequestBuilder"/>.</returns>
        public IManagementActionRequestBuilder this[string id]
        {
            get
            {
                return new ManagementActionRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
