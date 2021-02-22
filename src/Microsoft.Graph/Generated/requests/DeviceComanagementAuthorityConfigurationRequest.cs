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
    /// The type DeviceComanagementAuthorityConfigurationRequest.
    /// </summary>
    public partial class DeviceComanagementAuthorityConfigurationRequest : BaseRequest, IDeviceComanagementAuthorityConfigurationRequest
    {
        /// <summary>
        /// Constructs a new DeviceComanagementAuthorityConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceComanagementAuthorityConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DeviceComanagementAuthorityConfiguration using POST.
        /// </summary>
        /// <param name="deviceComanagementAuthorityConfigurationToCreate">The DeviceComanagementAuthorityConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceComanagementAuthorityConfiguration.</returns>
        public async System.Threading.Tasks.Task<DeviceComanagementAuthorityConfiguration> CreateAsync(DeviceComanagementAuthorityConfiguration deviceComanagementAuthorityConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Post;
            var newEntity = await this.SendAsync<DeviceComanagementAuthorityConfiguration>(deviceComanagementAuthorityConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified DeviceComanagementAuthorityConfiguration using POST and returns a <see cref="GraphResponse{DeviceComanagementAuthorityConfiguration}"/> object.
        /// </summary>
        /// <param name="deviceComanagementAuthorityConfigurationToCreate">The DeviceComanagementAuthorityConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceComanagementAuthorityConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceComanagementAuthorityConfiguration>> CreateResponseAsync(DeviceComanagementAuthorityConfiguration deviceComanagementAuthorityConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Post;
            return this.SendAsyncWithGraphResponse<DeviceComanagementAuthorityConfiguration>(deviceComanagementAuthorityConfigurationToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified DeviceComanagementAuthorityConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Delete;
            await this.SendAsync<DeviceComanagementAuthorityConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceComanagementAuthorityConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Delete;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified DeviceComanagementAuthorityConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceComanagementAuthorityConfiguration.</returns>
        public async System.Threading.Tasks.Task<DeviceComanagementAuthorityConfiguration> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Get;
            var retrievedEntity = await this.SendAsync<DeviceComanagementAuthorityConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified DeviceComanagementAuthorityConfiguration and returns a <see cref="GraphResponse{DeviceComanagementAuthorityConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceComanagementAuthorityConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceComanagementAuthorityConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Get;
            return this.SendAsyncWithGraphResponse<DeviceComanagementAuthorityConfiguration>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified DeviceComanagementAuthorityConfiguration using PATCH.
        /// </summary>
        /// <param name="deviceComanagementAuthorityConfigurationToUpdate">The DeviceComanagementAuthorityConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceComanagementAuthorityConfiguration.</returns>
        public async System.Threading.Tasks.Task<DeviceComanagementAuthorityConfiguration> UpdateAsync(DeviceComanagementAuthorityConfiguration deviceComanagementAuthorityConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Patch;
            var updatedEntity = await this.SendAsync<DeviceComanagementAuthorityConfiguration>(deviceComanagementAuthorityConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceComanagementAuthorityConfiguration using PATCH and returns a <see cref="GraphResponse{DeviceComanagementAuthorityConfiguration}"/> object.
        /// </summary>
        /// <param name="deviceComanagementAuthorityConfigurationToUpdate">The DeviceComanagementAuthorityConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceComanagementAuthorityConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceComanagementAuthorityConfiguration>> UpdateResponseAsync(DeviceComanagementAuthorityConfiguration deviceComanagementAuthorityConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Patch;
            return this.SendAsyncWithGraphResponse<DeviceComanagementAuthorityConfiguration>(deviceComanagementAuthorityConfigurationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceComanagementAuthorityConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceComanagementAuthorityConfigurationRequest Expand(Expression<Func<DeviceComanagementAuthorityConfiguration, object>> expandExpression)
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
        public IDeviceComanagementAuthorityConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceComanagementAuthorityConfigurationRequest Select(Expression<Func<DeviceComanagementAuthorityConfiguration, object>> selectExpression)
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
        /// <param name="deviceComanagementAuthorityConfigurationToInitialize">The <see cref="DeviceComanagementAuthorityConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DeviceComanagementAuthorityConfiguration deviceComanagementAuthorityConfigurationToInitialize)
        {

        }
    }
}
