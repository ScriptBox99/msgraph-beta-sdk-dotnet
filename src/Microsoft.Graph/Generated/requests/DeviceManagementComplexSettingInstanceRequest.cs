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
    /// The type DeviceManagementComplexSettingInstanceRequest.
    /// </summary>
    public partial class DeviceManagementComplexSettingInstanceRequest : BaseRequest, IDeviceManagementComplexSettingInstanceRequest
    {
        /// <summary>
        /// Constructs a new DeviceManagementComplexSettingInstanceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceManagementComplexSettingInstanceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DeviceManagementComplexSettingInstance using POST.
        /// </summary>
        /// <param name="deviceManagementComplexSettingInstanceToCreate">The DeviceManagementComplexSettingInstance to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementComplexSettingInstance.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementComplexSettingInstance> CreateAsync(DeviceManagementComplexSettingInstance deviceManagementComplexSettingInstanceToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Post;
            var newEntity = await this.SendAsync<DeviceManagementComplexSettingInstance>(deviceManagementComplexSettingInstanceToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified DeviceManagementComplexSettingInstance using POST and returns a <see cref="GraphResponse{DeviceManagementComplexSettingInstance}"/> object.
        /// </summary>
        /// <param name="deviceManagementComplexSettingInstanceToCreate">The DeviceManagementComplexSettingInstance to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementComplexSettingInstance}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementComplexSettingInstance>> CreateResponseAsync(DeviceManagementComplexSettingInstance deviceManagementComplexSettingInstanceToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Post;
            return this.SendAsyncWithGraphResponse<DeviceManagementComplexSettingInstance>(deviceManagementComplexSettingInstanceToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementComplexSettingInstance.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Delete;
            await this.SendAsync<DeviceManagementComplexSettingInstance>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementComplexSettingInstance and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Delete;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified DeviceManagementComplexSettingInstance.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementComplexSettingInstance.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementComplexSettingInstance> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Get;
            var retrievedEntity = await this.SendAsync<DeviceManagementComplexSettingInstance>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified DeviceManagementComplexSettingInstance and returns a <see cref="GraphResponse{DeviceManagementComplexSettingInstance}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementComplexSettingInstance}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementComplexSettingInstance>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Get;
            return this.SendAsyncWithGraphResponse<DeviceManagementComplexSettingInstance>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified DeviceManagementComplexSettingInstance using PATCH.
        /// </summary>
        /// <param name="deviceManagementComplexSettingInstanceToUpdate">The DeviceManagementComplexSettingInstance to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementComplexSettingInstance.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementComplexSettingInstance> UpdateAsync(DeviceManagementComplexSettingInstance deviceManagementComplexSettingInstanceToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Patch;
            var updatedEntity = await this.SendAsync<DeviceManagementComplexSettingInstance>(deviceManagementComplexSettingInstanceToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceManagementComplexSettingInstance using PATCH and returns a <see cref="GraphResponse{DeviceManagementComplexSettingInstance}"/> object.
        /// </summary>
        /// <param name="deviceManagementComplexSettingInstanceToUpdate">The DeviceManagementComplexSettingInstance to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementComplexSettingInstance}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementComplexSettingInstance>> UpdateResponseAsync(DeviceManagementComplexSettingInstance deviceManagementComplexSettingInstanceToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Patch;
            return this.SendAsyncWithGraphResponse<DeviceManagementComplexSettingInstance>(deviceManagementComplexSettingInstanceToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementComplexSettingInstanceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementComplexSettingInstanceRequest Expand(Expression<Func<DeviceManagementComplexSettingInstance, object>> expandExpression)
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
        public IDeviceManagementComplexSettingInstanceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementComplexSettingInstanceRequest Select(Expression<Func<DeviceManagementComplexSettingInstance, object>> selectExpression)
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
        /// <param name="deviceManagementComplexSettingInstanceToInitialize">The <see cref="DeviceManagementComplexSettingInstance"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DeviceManagementComplexSettingInstance deviceManagementComplexSettingInstanceToInitialize)
        {

            if (deviceManagementComplexSettingInstanceToInitialize != null && deviceManagementComplexSettingInstanceToInitialize.AdditionalData != null)
            {

                if (deviceManagementComplexSettingInstanceToInitialize.Value != null && deviceManagementComplexSettingInstanceToInitialize.Value.CurrentPage != null)
                {
                    deviceManagementComplexSettingInstanceToInitialize.Value.AdditionalData = deviceManagementComplexSettingInstanceToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceManagementComplexSettingInstanceToInitialize.AdditionalData.TryGetValue("value@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceManagementComplexSettingInstanceToInitialize.Value.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
