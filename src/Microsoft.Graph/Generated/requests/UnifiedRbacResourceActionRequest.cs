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
    /// The type UnifiedRbacResourceActionRequest.
    /// </summary>
    public partial class UnifiedRbacResourceActionRequest : BaseRequest, IUnifiedRbacResourceActionRequest
    {
        /// <summary>
        /// Constructs a new UnifiedRbacResourceActionRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public UnifiedRbacResourceActionRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified UnifiedRbacResourceAction using POST.
        /// </summary>
        /// <param name="unifiedRbacResourceActionToCreate">The UnifiedRbacResourceAction to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UnifiedRbacResourceAction.</returns>
        public async System.Threading.Tasks.Task<UnifiedRbacResourceAction> CreateAsync(UnifiedRbacResourceAction unifiedRbacResourceActionToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Post;
            var newEntity = await this.SendAsync<UnifiedRbacResourceAction>(unifiedRbacResourceActionToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified UnifiedRbacResourceAction using POST and returns a <see cref="GraphResponse{UnifiedRbacResourceAction}"/> object.
        /// </summary>
        /// <param name="unifiedRbacResourceActionToCreate">The UnifiedRbacResourceAction to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnifiedRbacResourceAction}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UnifiedRbacResourceAction>> CreateResponseAsync(UnifiedRbacResourceAction unifiedRbacResourceActionToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Post;
            return this.SendAsyncWithGraphResponse<UnifiedRbacResourceAction>(unifiedRbacResourceActionToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified UnifiedRbacResourceAction.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Delete;
            await this.SendAsync<UnifiedRbacResourceAction>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified UnifiedRbacResourceAction and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Delete;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified UnifiedRbacResourceAction.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UnifiedRbacResourceAction.</returns>
        public async System.Threading.Tasks.Task<UnifiedRbacResourceAction> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Get;
            var retrievedEntity = await this.SendAsync<UnifiedRbacResourceAction>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified UnifiedRbacResourceAction and returns a <see cref="GraphResponse{UnifiedRbacResourceAction}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnifiedRbacResourceAction}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UnifiedRbacResourceAction>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Get;
            return this.SendAsyncWithGraphResponse<UnifiedRbacResourceAction>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified UnifiedRbacResourceAction using PATCH.
        /// </summary>
        /// <param name="unifiedRbacResourceActionToUpdate">The UnifiedRbacResourceAction to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UnifiedRbacResourceAction.</returns>
        public async System.Threading.Tasks.Task<UnifiedRbacResourceAction> UpdateAsync(UnifiedRbacResourceAction unifiedRbacResourceActionToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Patch;
            var updatedEntity = await this.SendAsync<UnifiedRbacResourceAction>(unifiedRbacResourceActionToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified UnifiedRbacResourceAction using PATCH and returns a <see cref="GraphResponse{UnifiedRbacResourceAction}"/> object.
        /// </summary>
        /// <param name="unifiedRbacResourceActionToUpdate">The UnifiedRbacResourceAction to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UnifiedRbacResourceAction}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UnifiedRbacResourceAction>> UpdateResponseAsync(UnifiedRbacResourceAction unifiedRbacResourceActionToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Patch;
            return this.SendAsyncWithGraphResponse<UnifiedRbacResourceAction>(unifiedRbacResourceActionToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUnifiedRbacResourceActionRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IUnifiedRbacResourceActionRequest Expand(Expression<Func<UnifiedRbacResourceAction, object>> expandExpression)
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
        public IUnifiedRbacResourceActionRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IUnifiedRbacResourceActionRequest Select(Expression<Func<UnifiedRbacResourceAction, object>> selectExpression)
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
        /// <param name="unifiedRbacResourceActionToInitialize">The <see cref="UnifiedRbacResourceAction"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(UnifiedRbacResourceAction unifiedRbacResourceActionToInitialize)
        {

        }
    }
}
