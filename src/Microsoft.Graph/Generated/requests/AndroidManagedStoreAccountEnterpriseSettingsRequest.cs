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
    /// The type AndroidManagedStoreAccountEnterpriseSettingsRequest.
    /// </summary>
    public partial class AndroidManagedStoreAccountEnterpriseSettingsRequest : BaseRequest, IAndroidManagedStoreAccountEnterpriseSettingsRequest
    {
        /// <summary>
        /// Constructs a new AndroidManagedStoreAccountEnterpriseSettingsRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AndroidManagedStoreAccountEnterpriseSettingsRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified AndroidManagedStoreAccountEnterpriseSettings using POST.
        /// </summary>
        /// <param name="androidManagedStoreAccountEnterpriseSettingsToCreate">The AndroidManagedStoreAccountEnterpriseSettings to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidManagedStoreAccountEnterpriseSettings.</returns>
        public async System.Threading.Tasks.Task<AndroidManagedStoreAccountEnterpriseSettings> CreateAsync(AndroidManagedStoreAccountEnterpriseSettings androidManagedStoreAccountEnterpriseSettingsToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Post;
            var newEntity = await this.SendAsync<AndroidManagedStoreAccountEnterpriseSettings>(androidManagedStoreAccountEnterpriseSettingsToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified AndroidManagedStoreAccountEnterpriseSettings using POST and returns a <see cref="GraphResponse{AndroidManagedStoreAccountEnterpriseSettings}"/> object.
        /// </summary>
        /// <param name="androidManagedStoreAccountEnterpriseSettingsToCreate">The AndroidManagedStoreAccountEnterpriseSettings to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidManagedStoreAccountEnterpriseSettings}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AndroidManagedStoreAccountEnterpriseSettings>> CreateResponseAsync(AndroidManagedStoreAccountEnterpriseSettings androidManagedStoreAccountEnterpriseSettingsToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Post;
            return this.SendAsyncWithGraphResponse<AndroidManagedStoreAccountEnterpriseSettings>(androidManagedStoreAccountEnterpriseSettingsToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified AndroidManagedStoreAccountEnterpriseSettings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Delete;
            await this.SendAsync<AndroidManagedStoreAccountEnterpriseSettings>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified AndroidManagedStoreAccountEnterpriseSettings and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Delete;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified AndroidManagedStoreAccountEnterpriseSettings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidManagedStoreAccountEnterpriseSettings.</returns>
        public async System.Threading.Tasks.Task<AndroidManagedStoreAccountEnterpriseSettings> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Get;
            var retrievedEntity = await this.SendAsync<AndroidManagedStoreAccountEnterpriseSettings>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified AndroidManagedStoreAccountEnterpriseSettings and returns a <see cref="GraphResponse{AndroidManagedStoreAccountEnterpriseSettings}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidManagedStoreAccountEnterpriseSettings}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AndroidManagedStoreAccountEnterpriseSettings>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Get;
            return this.SendAsyncWithGraphResponse<AndroidManagedStoreAccountEnterpriseSettings>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified AndroidManagedStoreAccountEnterpriseSettings using PATCH.
        /// </summary>
        /// <param name="androidManagedStoreAccountEnterpriseSettingsToUpdate">The AndroidManagedStoreAccountEnterpriseSettings to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidManagedStoreAccountEnterpriseSettings.</returns>
        public async System.Threading.Tasks.Task<AndroidManagedStoreAccountEnterpriseSettings> UpdateAsync(AndroidManagedStoreAccountEnterpriseSettings androidManagedStoreAccountEnterpriseSettingsToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Patch;
            var updatedEntity = await this.SendAsync<AndroidManagedStoreAccountEnterpriseSettings>(androidManagedStoreAccountEnterpriseSettingsToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AndroidManagedStoreAccountEnterpriseSettings using PATCH and returns a <see cref="GraphResponse{AndroidManagedStoreAccountEnterpriseSettings}"/> object.
        /// </summary>
        /// <param name="androidManagedStoreAccountEnterpriseSettingsToUpdate">The AndroidManagedStoreAccountEnterpriseSettings to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AndroidManagedStoreAccountEnterpriseSettings}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AndroidManagedStoreAccountEnterpriseSettings>> UpdateResponseAsync(AndroidManagedStoreAccountEnterpriseSettings androidManagedStoreAccountEnterpriseSettingsToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Patch;
            return this.SendAsyncWithGraphResponse<AndroidManagedStoreAccountEnterpriseSettings>(androidManagedStoreAccountEnterpriseSettingsToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidManagedStoreAccountEnterpriseSettingsRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidManagedStoreAccountEnterpriseSettingsRequest Expand(Expression<Func<AndroidManagedStoreAccountEnterpriseSettings, object>> expandExpression)
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
        public IAndroidManagedStoreAccountEnterpriseSettingsRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidManagedStoreAccountEnterpriseSettingsRequest Select(Expression<Func<AndroidManagedStoreAccountEnterpriseSettings, object>> selectExpression)
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
        /// <param name="androidManagedStoreAccountEnterpriseSettingsToInitialize">The <see cref="AndroidManagedStoreAccountEnterpriseSettings"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(AndroidManagedStoreAccountEnterpriseSettings androidManagedStoreAccountEnterpriseSettingsToInitialize)
        {

        }
    }
}
