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
    /// The type DeviceHealthScriptPolicyStateWithReferenceRequest.
    /// </summary>
    public partial class DeviceHealthScriptPolicyStateWithReferenceRequest : BaseRequest, IDeviceHealthScriptPolicyStateWithReferenceRequest
    {
        /// <summary>
        /// Constructs a new DeviceHealthScriptPolicyStateWithReferenceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceHealthScriptPolicyStateWithReferenceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the specified DeviceHealthScriptPolicyState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceHealthScriptPolicyState.</returns>
        public async System.Threading.Tasks.Task<DeviceHealthScriptPolicyState> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<DeviceHealthScriptPolicyState>(null, cancellationToken).ConfigureAwait(false);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified DeviceHealthScriptPolicyState and returns a <see cref="GraphResponse{DeviceHealthScriptPolicyState}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceHealthScriptPolicyState}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceHealthScriptPolicyState>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<DeviceHealthScriptPolicyState>(null, cancellationToken);
        }

		/// <summary>
        /// Creates the specified DeviceHealthScriptPolicyState using POST.
        /// </summary>
        /// <param name="deviceHealthScriptPolicyStateToCreate">The DeviceHealthScriptPolicyState to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceHealthScriptPolicyState.</returns>
        public async System.Threading.Tasks.Task<DeviceHealthScriptPolicyState> CreateAsync(DeviceHealthScriptPolicyState deviceHealthScriptPolicyStateToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<DeviceHealthScriptPolicyState>(deviceHealthScriptPolicyStateToCreate, cancellationToken).ConfigureAwait(false);
            return newEntity;
        }

		/// <summary>
        /// Creates the specified DeviceHealthScriptPolicyState using POST and returns a <see cref="GraphResponse{DeviceHealthScriptPolicyState}"/> object.
        /// </summary>
        /// <param name="deviceHealthScriptPolicyStateToCreate">The DeviceHealthScriptPolicyState to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceHealthScriptPolicyState}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceHealthScriptPolicyState>> CreateResponseAsync(DeviceHealthScriptPolicyState deviceHealthScriptPolicyStateToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<DeviceHealthScriptPolicyState>(deviceHealthScriptPolicyStateToCreate, cancellationToken);
        }

		/// <summary>
        /// Updates the specified DeviceHealthScriptPolicyState using PATCH.
        /// </summary>
        /// <param name="deviceHealthScriptPolicyStateToUpdate">The DeviceHealthScriptPolicyState to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceHealthScriptPolicyState.</returns>
        public async System.Threading.Tasks.Task<DeviceHealthScriptPolicyState> UpdateAsync(DeviceHealthScriptPolicyState deviceHealthScriptPolicyStateToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<DeviceHealthScriptPolicyState>(deviceHealthScriptPolicyStateToUpdate, cancellationToken).ConfigureAwait(false);
            return updatedEntity;
        }

		/// <summary>
        /// Updates the specified DeviceHealthScriptPolicyState using PATCH and returns a <see cref="GraphResponse{DeviceHealthScriptPolicyState}"/> object.
        /// </summary>
        /// <param name="deviceHealthScriptPolicyStateToUpdate">The DeviceHealthScriptPolicyState to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceHealthScriptPolicyState}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceHealthScriptPolicyState>> UpdateResponseAsync(DeviceHealthScriptPolicyState deviceHealthScriptPolicyStateToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<DeviceHealthScriptPolicyState>(deviceHealthScriptPolicyStateToUpdate, cancellationToken);
        }

		/// <summary>
        /// Deletes the specified DeviceHealthScriptPolicyState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<DeviceHealthScriptPolicyState>(null, cancellationToken).ConfigureAwait(false);
        }

		/// <summary>
        /// Deletes the specified DeviceHealthScriptPolicyState and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceHealthScriptPolicyStateWithReferenceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceHealthScriptPolicyStateWithReferenceRequest Expand(Expression<Func<DeviceHealthScriptPolicyState, object>> expandExpression)
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
        public IDeviceHealthScriptPolicyStateWithReferenceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceHealthScriptPolicyStateWithReferenceRequest Select(Expression<Func<DeviceHealthScriptPolicyState, object>> selectExpression)
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
