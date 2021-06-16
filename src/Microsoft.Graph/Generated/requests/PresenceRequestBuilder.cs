// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type PresenceRequestBuilder.
    /// </summary>
    public partial class PresenceRequestBuilder : EntityRequestBuilder, IPresenceRequestBuilder
    {

        /// <summary>
        /// Constructs a new PresenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public PresenceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IPresenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IPresenceRequest Request(IEnumerable<Option> options)
        {
            return new PresenceRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for PresenceClearPresence.
        /// </summary>
        /// <returns>The <see cref="IPresenceClearPresenceRequestBuilder"/>.</returns>
        public IPresenceClearPresenceRequestBuilder ClearPresence(
            string sessionId)
        {
            return new PresenceClearPresenceRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.clearPresence"),
                this.Client,
                sessionId);
        }

        /// <summary>
        /// Gets the request builder for PresenceSetPresence.
        /// </summary>
        /// <returns>The <see cref="IPresenceSetPresenceRequestBuilder"/>.</returns>
        public IPresenceSetPresenceRequestBuilder SetPresence(
            string sessionId,
            string availability,
            string activity,
            Duration expirationDuration = null)
        {
            return new PresenceSetPresenceRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.setPresence"),
                this.Client,
                sessionId,
                availability,
                activity,
                expirationDuration);
        }
    
    }
}
