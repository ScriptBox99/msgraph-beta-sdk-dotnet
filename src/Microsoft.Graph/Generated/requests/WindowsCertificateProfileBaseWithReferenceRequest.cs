// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type WindowsCertificateProfileBaseWithReferenceRequest.
    /// </summary>
    public partial class WindowsCertificateProfileBaseWithReferenceRequest : BaseRequest, IWindowsCertificateProfileBaseWithReferenceRequest
    {
        /// <summary>
        /// Constructs a new WindowsCertificateProfileBaseWithReferenceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WindowsCertificateProfileBaseWithReferenceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the specified WindowsCertificateProfileBase.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsCertificateProfileBase.</returns>
        public async System.Threading.Tasks.Task<WindowsCertificateProfileBase> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Get;
            var retrievedEntity = await this.SendAsync<WindowsCertificateProfileBase>(null, cancellationToken).ConfigureAwait(false);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified WindowsCertificateProfileBase and returns a <see cref="GraphResponse{WindowsCertificateProfileBase}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsCertificateProfileBase}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WindowsCertificateProfileBase>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Get;
            return this.SendAsyncWithGraphResponse<WindowsCertificateProfileBase>(null, cancellationToken);
        }

		/// <summary>
        /// Creates the specified WindowsCertificateProfileBase using POST.
        /// </summary>
        /// <param name="windowsCertificateProfileBaseToCreate">The WindowsCertificateProfileBase to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsCertificateProfileBase.</returns>
        public async System.Threading.Tasks.Task<WindowsCertificateProfileBase> CreateAsync(WindowsCertificateProfileBase windowsCertificateProfileBaseToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Post;
            var newEntity = await this.SendAsync<WindowsCertificateProfileBase>(windowsCertificateProfileBaseToCreate, cancellationToken).ConfigureAwait(false);
            return newEntity;
        }

		/// <summary>
        /// Creates the specified WindowsCertificateProfileBase using POST and returns a <see cref="GraphResponse{WindowsCertificateProfileBase}"/> object.
        /// </summary>
        /// <param name="windowsCertificateProfileBaseToCreate">The WindowsCertificateProfileBase to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsCertificateProfileBase}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WindowsCertificateProfileBase>> CreateResponseAsync(WindowsCertificateProfileBase windowsCertificateProfileBaseToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Post;
            return this.SendAsyncWithGraphResponse<WindowsCertificateProfileBase>(windowsCertificateProfileBaseToCreate, cancellationToken);
        }

		/// <summary>
        /// Updates the specified WindowsCertificateProfileBase using PATCH.
        /// </summary>
        /// <param name="windowsCertificateProfileBaseToUpdate">The WindowsCertificateProfileBase to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsCertificateProfileBase.</returns>
        public async System.Threading.Tasks.Task<WindowsCertificateProfileBase> UpdateAsync(WindowsCertificateProfileBase windowsCertificateProfileBaseToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Patch;
            var updatedEntity = await this.SendAsync<WindowsCertificateProfileBase>(windowsCertificateProfileBaseToUpdate, cancellationToken).ConfigureAwait(false);
            return updatedEntity;
        }

		/// <summary>
        /// Updates the specified WindowsCertificateProfileBase using PATCH and returns a <see cref="GraphResponse{WindowsCertificateProfileBase}"/> object.
        /// </summary>
        /// <param name="windowsCertificateProfileBaseToUpdate">The WindowsCertificateProfileBase to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WindowsCertificateProfileBase}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WindowsCertificateProfileBase>> UpdateResponseAsync(WindowsCertificateProfileBase windowsCertificateProfileBaseToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Patch;
            return this.SendAsyncWithGraphResponse<WindowsCertificateProfileBase>(windowsCertificateProfileBaseToUpdate, cancellationToken);
        }

		/// <summary>
        /// Deletes the specified WindowsCertificateProfileBase.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Delete;
            await this.SendAsync<WindowsCertificateProfileBase>(null, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Deletes the specified WindowsCertificateProfileBase and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Delete;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsCertificateProfileBaseWithReferenceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsCertificateProfileBaseWithReferenceRequest Expand(Expression<Func<WindowsCertificateProfileBase, object>> expandExpression)
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
        public IWindowsCertificateProfileBaseWithReferenceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsCertificateProfileBaseWithReferenceRequest Select(Expression<Func<WindowsCertificateProfileBase, object>> selectExpression)
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

    }
}
