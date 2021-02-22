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
    /// The type PrivilegedRoleSettingsWithReferenceRequest.
    /// </summary>
    public partial class PrivilegedRoleSettingsWithReferenceRequest : BaseRequest, IPrivilegedRoleSettingsWithReferenceRequest
    {
        /// <summary>
        /// Constructs a new PrivilegedRoleSettingsWithReferenceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public PrivilegedRoleSettingsWithReferenceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the specified PrivilegedRoleSettings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PrivilegedRoleSettings.</returns>
        public async System.Threading.Tasks.Task<PrivilegedRoleSettings> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Get;
            var retrievedEntity = await this.SendAsync<PrivilegedRoleSettings>(null, cancellationToken).ConfigureAwait(false);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified PrivilegedRoleSettings and returns a <see cref="GraphResponse{PrivilegedRoleSettings}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PrivilegedRoleSettings}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PrivilegedRoleSettings>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Get;
            return this.SendAsyncWithGraphResponse<PrivilegedRoleSettings>(null, cancellationToken);
        }

		/// <summary>
        /// Creates the specified PrivilegedRoleSettings using POST.
        /// </summary>
        /// <param name="privilegedRoleSettingsToCreate">The PrivilegedRoleSettings to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PrivilegedRoleSettings.</returns>
        public async System.Threading.Tasks.Task<PrivilegedRoleSettings> CreateAsync(PrivilegedRoleSettings privilegedRoleSettingsToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Post;
            var newEntity = await this.SendAsync<PrivilegedRoleSettings>(privilegedRoleSettingsToCreate, cancellationToken).ConfigureAwait(false);
            return newEntity;
        }

		/// <summary>
        /// Creates the specified PrivilegedRoleSettings using POST and returns a <see cref="GraphResponse{PrivilegedRoleSettings}"/> object.
        /// </summary>
        /// <param name="privilegedRoleSettingsToCreate">The PrivilegedRoleSettings to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PrivilegedRoleSettings}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PrivilegedRoleSettings>> CreateResponseAsync(PrivilegedRoleSettings privilegedRoleSettingsToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Post;
            return this.SendAsyncWithGraphResponse<PrivilegedRoleSettings>(privilegedRoleSettingsToCreate, cancellationToken);
        }

		/// <summary>
        /// Updates the specified PrivilegedRoleSettings using PATCH.
        /// </summary>
        /// <param name="privilegedRoleSettingsToUpdate">The PrivilegedRoleSettings to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PrivilegedRoleSettings.</returns>
        public async System.Threading.Tasks.Task<PrivilegedRoleSettings> UpdateAsync(PrivilegedRoleSettings privilegedRoleSettingsToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Patch;
            var updatedEntity = await this.SendAsync<PrivilegedRoleSettings>(privilegedRoleSettingsToUpdate, cancellationToken).ConfigureAwait(false);
            return updatedEntity;
        }

		/// <summary>
        /// Updates the specified PrivilegedRoleSettings using PATCH and returns a <see cref="GraphResponse{PrivilegedRoleSettings}"/> object.
        /// </summary>
        /// <param name="privilegedRoleSettingsToUpdate">The PrivilegedRoleSettings to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{PrivilegedRoleSettings}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PrivilegedRoleSettings>> UpdateResponseAsync(PrivilegedRoleSettings privilegedRoleSettingsToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Patch;
            return this.SendAsyncWithGraphResponse<PrivilegedRoleSettings>(privilegedRoleSettingsToUpdate, cancellationToken);
        }

		/// <summary>
        /// Deletes the specified PrivilegedRoleSettings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Delete;
            await this.SendAsync<PrivilegedRoleSettings>(null, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Deletes the specified PrivilegedRoleSettings and returns a <see cref="GraphResponse"/> object.
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
        public IPrivilegedRoleSettingsWithReferenceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPrivilegedRoleSettingsWithReferenceRequest Expand(Expression<Func<PrivilegedRoleSettings, object>> expandExpression)
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
        public IPrivilegedRoleSettingsWithReferenceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IPrivilegedRoleSettingsWithReferenceRequest Select(Expression<Func<PrivilegedRoleSettings, object>> selectExpression)
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
