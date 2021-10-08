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
    /// The type MessageRecipientEventsCollectionRequestBuilder.
    /// </summary>
    public partial class MessageRecipientEventsCollectionRequestBuilder : BaseRequestBuilder, IMessageRecipientEventsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new MessageRecipientEventsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public MessageRecipientEventsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IMessageRecipientEventsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IMessageRecipientEventsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new MessageRecipientEventsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IMessageEventRequestBuilder"/> for the specified MessageRecipientMessageEvent.
        /// </summary>
        /// <param name="id">The ID for the MessageRecipientMessageEvent.</param>
        /// <returns>The <see cref="IMessageEventRequestBuilder"/>.</returns>
        public IMessageEventRequestBuilder this[string id]
        {
            get
            {
                return new MessageEventRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
