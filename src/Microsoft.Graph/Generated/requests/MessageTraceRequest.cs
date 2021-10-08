// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type MessageTraceRequest.
    /// </summary>
    public partial class MessageTraceRequest : BaseRequest, IMessageTraceRequest
    {
        /// <summary>
        /// Constructs a new MessageTraceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public MessageTraceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified MessageTrace using POST.
        /// </summary>
        /// <param name="messageTraceToCreate">The MessageTrace to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MessageTrace.</returns>
        public async System.Threading.Tasks.Task<MessageTrace> CreateAsync(MessageTrace messageTraceToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<MessageTrace>(messageTraceToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified MessageTrace using POST and returns a <see cref="GraphResponse{MessageTrace}"/> object.
        /// </summary>
        /// <param name="messageTraceToCreate">The MessageTrace to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MessageTrace}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MessageTrace>> CreateResponseAsync(MessageTrace messageTraceToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<MessageTrace>(messageTraceToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified MessageTrace.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<MessageTrace>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified MessageTrace and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified MessageTrace.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MessageTrace.</returns>
        public async System.Threading.Tasks.Task<MessageTrace> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<MessageTrace>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified MessageTrace and returns a <see cref="GraphResponse{MessageTrace}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MessageTrace}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MessageTrace>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<MessageTrace>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified MessageTrace using PATCH.
        /// </summary>
        /// <param name="messageTraceToUpdate">The MessageTrace to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MessageTrace.</returns>
        public async System.Threading.Tasks.Task<MessageTrace> UpdateAsync(MessageTrace messageTraceToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<MessageTrace>(messageTraceToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified MessageTrace using PATCH and returns a <see cref="GraphResponse{MessageTrace}"/> object.
        /// </summary>
        /// <param name="messageTraceToUpdate">The MessageTrace to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MessageTrace}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MessageTrace>> UpdateResponseAsync(MessageTrace messageTraceToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<MessageTrace>(messageTraceToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified MessageTrace using PUT.
        /// </summary>
        /// <param name="messageTraceToUpdate">The MessageTrace object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<MessageTrace> PutAsync(MessageTrace messageTraceToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<MessageTrace>(messageTraceToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified MessageTrace using PUT and returns a <see cref="GraphResponse{MessageTrace}"/> object.
        /// </summary>
        /// <param name="messageTraceToUpdate">The MessageTrace object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{MessageTrace}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MessageTrace>> PutResponseAsync(MessageTrace messageTraceToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<MessageTrace>(messageTraceToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMessageTraceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMessageTraceRequest Expand(Expression<Func<MessageTrace, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IMessageTraceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IMessageTraceRequest Select(Expression<Func<MessageTrace, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="messageTraceToInitialize">The <see cref="MessageTrace"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(MessageTrace messageTraceToInitialize)
        {

            if (messageTraceToInitialize != null)
            {
                if (messageTraceToInitialize.Recipients != null && messageTraceToInitialize.Recipients.CurrentPage != null)
                {
                    messageTraceToInitialize.Recipients.InitializeNextPageRequest(this.Client, messageTraceToInitialize.RecipientsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    messageTraceToInitialize.Recipients.AdditionalData = messageTraceToInitialize.AdditionalData;
                }

            }


        }
    }
}
