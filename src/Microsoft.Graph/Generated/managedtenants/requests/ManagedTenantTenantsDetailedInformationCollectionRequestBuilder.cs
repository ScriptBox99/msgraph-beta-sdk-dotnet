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
    /// The type ManagedTenantTenantsDetailedInformationCollectionRequestBuilder.
    /// </summary>
    public partial class ManagedTenantTenantsDetailedInformationCollectionRequestBuilder : Microsoft.Graph.BaseRequestBuilder, IManagedTenantTenantsDetailedInformationCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ManagedTenantTenantsDetailedInformationCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public ManagedTenantTenantsDetailedInformationCollectionRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IManagedTenantTenantsDetailedInformationCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IManagedTenantTenantsDetailedInformationCollectionRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new ManagedTenantTenantsDetailedInformationCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ITenantDetailedInformationRequestBuilder"/> for the specified ManagedTenantTenantDetailedInformation.
        /// </summary>
        /// <param name="id">The ID for the ManagedTenantTenantDetailedInformation.</param>
        /// <returns>The <see cref="ITenantDetailedInformationRequestBuilder"/>.</returns>
        public ITenantDetailedInformationRequestBuilder this[string id]
        {
            get
            {
                return new TenantDetailedInformationRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
