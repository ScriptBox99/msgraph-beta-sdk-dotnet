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
    /// The type ServiceHealthIssuesCollectionRequestBuilder.
    /// </summary>
    public partial class ServiceHealthIssuesCollectionRequestBuilder : BaseRequestBuilder, IServiceHealthIssuesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ServiceHealthIssuesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ServiceHealthIssuesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IServiceHealthIssuesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IServiceHealthIssuesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new ServiceHealthIssuesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IServiceHealthIssueRequestBuilder"/> for the specified ServiceHealthServiceHealthIssue.
        /// </summary>
        /// <param name="id">The ID for the ServiceHealthServiceHealthIssue.</param>
        /// <returns>The <see cref="IServiceHealthIssueRequestBuilder"/>.</returns>
        public IServiceHealthIssueRequestBuilder this[string id]
        {
            get
            {
                return new ServiceHealthIssueRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
