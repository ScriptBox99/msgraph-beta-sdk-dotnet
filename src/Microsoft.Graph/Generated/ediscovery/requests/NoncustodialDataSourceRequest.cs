// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type NoncustodialDataSourceRequest.
    /// </summary>
    public partial class NoncustodialDataSourceRequest : Microsoft.Graph.BaseRequest, INoncustodialDataSourceRequest
    {
        /// <summary>
        /// Constructs a new NoncustodialDataSourceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public NoncustodialDataSourceRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified NoncustodialDataSource using POST.
        /// </summary>
        /// <param name="noncustodialDataSourceToCreate">The NoncustodialDataSource to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created NoncustodialDataSource.</returns>
        public async System.Threading.Tasks.Task<NoncustodialDataSource> CreateAsync(NoncustodialDataSource noncustodialDataSourceToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Post;
            var newEntity = await this.SendAsync<NoncustodialDataSource>(noncustodialDataSourceToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified NoncustodialDataSource using POST and returns a <see cref="GraphResponse{NoncustodialDataSource}"/> object.
        /// </summary>
        /// <param name="noncustodialDataSourceToCreate">The NoncustodialDataSource to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{NoncustodialDataSource}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<NoncustodialDataSource>> CreateResponseAsync(NoncustodialDataSource noncustodialDataSourceToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Post;
            return this.SendAsyncWithGraphResponse<NoncustodialDataSource>(noncustodialDataSourceToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified NoncustodialDataSource.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Delete;
            await this.SendAsync<NoncustodialDataSource>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified NoncustodialDataSource and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Delete;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified NoncustodialDataSource.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The NoncustodialDataSource.</returns>
        public async System.Threading.Tasks.Task<NoncustodialDataSource> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Get;
            var retrievedEntity = await this.SendAsync<NoncustodialDataSource>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified NoncustodialDataSource and returns a <see cref="GraphResponse{NoncustodialDataSource}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{NoncustodialDataSource}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<NoncustodialDataSource>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Get;
            return this.SendAsyncWithGraphResponse<NoncustodialDataSource>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified NoncustodialDataSource using PATCH.
        /// </summary>
        /// <param name="noncustodialDataSourceToUpdate">The NoncustodialDataSource to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated NoncustodialDataSource.</returns>
        public async System.Threading.Tasks.Task<NoncustodialDataSource> UpdateAsync(NoncustodialDataSource noncustodialDataSourceToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Patch;
            var updatedEntity = await this.SendAsync<NoncustodialDataSource>(noncustodialDataSourceToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified NoncustodialDataSource using PATCH and returns a <see cref="GraphResponse{NoncustodialDataSource}"/> object.
        /// </summary>
        /// <param name="noncustodialDataSourceToUpdate">The NoncustodialDataSource to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{NoncustodialDataSource}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<NoncustodialDataSource>> UpdateResponseAsync(NoncustodialDataSource noncustodialDataSourceToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Patch;
            return this.SendAsyncWithGraphResponse<NoncustodialDataSource>(noncustodialDataSourceToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public INoncustodialDataSourceRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public INoncustodialDataSourceRequest Expand(Expression<Func<NoncustodialDataSource, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public INoncustodialDataSourceRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public INoncustodialDataSourceRequest Select(Expression<Func<NoncustodialDataSource, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="noncustodialDataSourceToInitialize">The <see cref="NoncustodialDataSource"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(NoncustodialDataSource noncustodialDataSourceToInitialize)
        {

        }
    }
}
