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
    /// The type GraphServiceMessageRecipientsCollectionRequestBuilder.
    /// </summary>
    public partial class GraphServiceMessageRecipientsCollectionRequestBuilder : BaseRequestBuilder, IGraphServiceMessageRecipientsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GraphServiceMessageRecipientsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GraphServiceMessageRecipientsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGraphServiceMessageRecipientsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGraphServiceMessageRecipientsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GraphServiceMessageRecipientsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IMessageRecipientRequestBuilder"/> for the specified GraphServiceMessageRecipient.
        /// </summary>
        /// <param name="id">The ID for the GraphServiceMessageRecipient.</param>
        /// <returns>The <see cref="IMessageRecipientRequestBuilder"/>.</returns>
        public IMessageRecipientRequestBuilder this[string id]
        {
            get
            {
                return new MessageRecipientRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
