// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type AdminWindowsUpdatesResourceConnectionsCollectionRequestBuilder.
    /// </summary>
    public partial class AdminWindowsUpdatesResourceConnectionsCollectionRequestBuilder : BaseRequestBuilder, IAdminWindowsUpdatesResourceConnectionsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new AdminWindowsUpdatesResourceConnectionsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AdminWindowsUpdatesResourceConnectionsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IAdminWindowsUpdatesResourceConnectionsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IAdminWindowsUpdatesResourceConnectionsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new AdminWindowsUpdatesResourceConnectionsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="Microsoft.Graph.WindowsUpdates.IResourceConnectionRequestBuilder"/> for the specified AdminWindowsUpdatesMicrosoft.Graph.WindowsUpdates.ResourceConnection.
        /// </summary>
        /// <param name="id">The ID for the AdminWindowsUpdatesMicrosoft.Graph.WindowsUpdates.ResourceConnection.</param>
        /// <returns>The <see cref="Microsoft.Graph.WindowsUpdates.IResourceConnectionRequestBuilder"/>.</returns>
        public Microsoft.Graph.WindowsUpdates.IResourceConnectionRequestBuilder this[string id]
        {
            get
            {
                return new Microsoft.Graph.WindowsUpdates.ResourceConnectionRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
