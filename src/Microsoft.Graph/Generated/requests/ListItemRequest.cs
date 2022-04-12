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
    /// The type ListItemRequest.
    /// </summary>
    public partial class ListItemRequest : BaseRequest, IListItemRequest
    {
        /// <summary>
        /// Constructs a new ListItemRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ListItemRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ListItem using POST.
        /// </summary>
        /// <param name="listItemToCreate">The ListItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ListItem.</returns>
        public async System.Threading.Tasks.Task<ListItem> CreateAsync(ListItem listItemToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<ListItem>(listItemToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified ListItem using POST and returns a <see cref="GraphResponse{ListItem}"/> object.
        /// </summary>
        /// <param name="listItemToCreate">The ListItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ListItem}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ListItem>> CreateResponseAsync(ListItem listItemToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<ListItem>(listItemToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified ListItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<ListItem>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ListItem and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified ListItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ListItem.</returns>
        public async System.Threading.Tasks.Task<ListItem> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<ListItem>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified ListItem and returns a <see cref="GraphResponse{ListItem}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ListItem}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ListItem>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<ListItem>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ListItem using PATCH.
        /// </summary>
        /// <param name="listItemToUpdate">The ListItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ListItem.</returns>
        public async System.Threading.Tasks.Task<ListItem> UpdateAsync(ListItem listItemToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<ListItem>(listItemToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ListItem using PATCH and returns a <see cref="GraphResponse{ListItem}"/> object.
        /// </summary>
        /// <param name="listItemToUpdate">The ListItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ListItem}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ListItem>> UpdateResponseAsync(ListItem listItemToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<ListItem>(listItemToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ListItem using PUT.
        /// </summary>
        /// <param name="listItemToUpdate">The ListItem object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<ListItem> PutAsync(ListItem listItemToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<ListItem>(listItemToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ListItem using PUT and returns a <see cref="GraphResponse{ListItem}"/> object.
        /// </summary>
        /// <param name="listItemToUpdate">The ListItem object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{ListItem}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ListItem>> PutResponseAsync(ListItem listItemToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<ListItem>(listItemToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IListItemRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IListItemRequest Expand(Expression<Func<ListItem, object>> expandExpression)
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
        public IListItemRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IListItemRequest Select(Expression<Func<ListItem, object>> selectExpression)
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
        /// <param name="listItemToInitialize">The <see cref="ListItem"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ListItem listItemToInitialize)
        {

            if (listItemToInitialize != null)
            {
                if (listItemToInitialize.Activities != null && listItemToInitialize.Activities.CurrentPage != null)
                {
                    listItemToInitialize.Activities.InitializeNextPageRequest(this.Client, listItemToInitialize.ActivitiesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    listItemToInitialize.Activities.AdditionalData = listItemToInitialize.AdditionalData;
                }
                if (listItemToInitialize.DocumentSetVersions != null && listItemToInitialize.DocumentSetVersions.CurrentPage != null)
                {
                    listItemToInitialize.DocumentSetVersions.InitializeNextPageRequest(this.Client, listItemToInitialize.DocumentSetVersionsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    listItemToInitialize.DocumentSetVersions.AdditionalData = listItemToInitialize.AdditionalData;
                }
                if (listItemToInitialize.Versions != null && listItemToInitialize.Versions.CurrentPage != null)
                {
                    listItemToInitialize.Versions.InitializeNextPageRequest(this.Client, listItemToInitialize.VersionsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    listItemToInitialize.Versions.AdditionalData = listItemToInitialize.AdditionalData;
                }

            }


        }
    }
}
