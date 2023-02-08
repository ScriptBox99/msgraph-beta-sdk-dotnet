// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph.WindowsUpdates
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type DriverUpdateCatalogEntryRequest.
    /// </summary>
    public partial class DriverUpdateCatalogEntryRequest : Microsoft.Graph.BaseRequest, IDriverUpdateCatalogEntryRequest
    {
        /// <summary>
        /// Constructs a new DriverUpdateCatalogEntryRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DriverUpdateCatalogEntryRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DriverUpdateCatalogEntry using POST.
        /// </summary>
        /// <param name="driverUpdateCatalogEntryToCreate">The DriverUpdateCatalogEntry to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DriverUpdateCatalogEntry.</returns>
        public async System.Threading.Tasks.Task<DriverUpdateCatalogEntry> CreateAsync(DriverUpdateCatalogEntry driverUpdateCatalogEntryToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<DriverUpdateCatalogEntry>(driverUpdateCatalogEntryToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified DriverUpdateCatalogEntry using POST and returns a <see cref="GraphResponse{DriverUpdateCatalogEntry}"/> object.
        /// </summary>
        /// <param name="driverUpdateCatalogEntryToCreate">The DriverUpdateCatalogEntry to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DriverUpdateCatalogEntry}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DriverUpdateCatalogEntry>> CreateResponseAsync(DriverUpdateCatalogEntry driverUpdateCatalogEntryToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<DriverUpdateCatalogEntry>(driverUpdateCatalogEntryToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified DriverUpdateCatalogEntry.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<DriverUpdateCatalogEntry>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DriverUpdateCatalogEntry and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified DriverUpdateCatalogEntry.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DriverUpdateCatalogEntry.</returns>
        public async System.Threading.Tasks.Task<DriverUpdateCatalogEntry> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<DriverUpdateCatalogEntry>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified DriverUpdateCatalogEntry and returns a <see cref="GraphResponse{DriverUpdateCatalogEntry}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DriverUpdateCatalogEntry}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DriverUpdateCatalogEntry>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<DriverUpdateCatalogEntry>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified DriverUpdateCatalogEntry using PATCH.
        /// </summary>
        /// <param name="driverUpdateCatalogEntryToUpdate">The DriverUpdateCatalogEntry to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DriverUpdateCatalogEntry.</returns>
        public async System.Threading.Tasks.Task<DriverUpdateCatalogEntry> UpdateAsync(DriverUpdateCatalogEntry driverUpdateCatalogEntryToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<DriverUpdateCatalogEntry>(driverUpdateCatalogEntryToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DriverUpdateCatalogEntry using PATCH and returns a <see cref="GraphResponse{DriverUpdateCatalogEntry}"/> object.
        /// </summary>
        /// <param name="driverUpdateCatalogEntryToUpdate">The DriverUpdateCatalogEntry to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DriverUpdateCatalogEntry}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DriverUpdateCatalogEntry>> UpdateResponseAsync(DriverUpdateCatalogEntry driverUpdateCatalogEntryToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<DriverUpdateCatalogEntry>(driverUpdateCatalogEntryToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified DriverUpdateCatalogEntry using PUT.
        /// </summary>
        /// <param name="driverUpdateCatalogEntryToUpdate">The DriverUpdateCatalogEntry object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<DriverUpdateCatalogEntry> PutAsync(DriverUpdateCatalogEntry driverUpdateCatalogEntryToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<DriverUpdateCatalogEntry>(driverUpdateCatalogEntryToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DriverUpdateCatalogEntry using PUT and returns a <see cref="GraphResponse{DriverUpdateCatalogEntry}"/> object.
        /// </summary>
        /// <param name="driverUpdateCatalogEntryToUpdate">The DriverUpdateCatalogEntry object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{DriverUpdateCatalogEntry}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DriverUpdateCatalogEntry>> PutResponseAsync(DriverUpdateCatalogEntry driverUpdateCatalogEntryToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<DriverUpdateCatalogEntry>(driverUpdateCatalogEntryToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDriverUpdateCatalogEntryRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDriverUpdateCatalogEntryRequest Expand(Expression<Func<DriverUpdateCatalogEntry, object>> expandExpression)
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
        public IDriverUpdateCatalogEntryRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDriverUpdateCatalogEntryRequest Select(Expression<Func<DriverUpdateCatalogEntry, object>> selectExpression)
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
        /// <param name="driverUpdateCatalogEntryToInitialize">The <see cref="DriverUpdateCatalogEntry"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DriverUpdateCatalogEntry driverUpdateCatalogEntryToInitialize)
        {

        }
    }
}
