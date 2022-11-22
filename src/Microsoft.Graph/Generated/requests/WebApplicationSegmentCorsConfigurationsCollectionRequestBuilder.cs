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
    /// The type WebApplicationSegmentCorsConfigurationsCollectionRequestBuilder.
    /// </summary>
    public partial class WebApplicationSegmentCorsConfigurationsCollectionRequestBuilder : BaseRequestBuilder, IWebApplicationSegmentCorsConfigurationsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new WebApplicationSegmentCorsConfigurationsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WebApplicationSegmentCorsConfigurationsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IWebApplicationSegmentCorsConfigurationsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IWebApplicationSegmentCorsConfigurationsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new WebApplicationSegmentCorsConfigurationsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ICorsConfiguration_v2RequestBuilder"/> for the specified WebApplicationSegmentCorsConfiguration_v2.
        /// </summary>
        /// <param name="id">The ID for the WebApplicationSegmentCorsConfiguration_v2.</param>
        /// <returns>The <see cref="ICorsConfiguration_v2RequestBuilder"/>.</returns>
        public ICorsConfiguration_v2RequestBuilder this[string id]
        {
            get
            {
                return new CorsConfiguration_v2RequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
