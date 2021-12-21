// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph.ExternalConnectors
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IConnectionQuotaRequest.
    /// </summary>
    public partial interface IConnectionQuotaRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Creates the specified ConnectionQuota using POST.
        /// </summary>
        /// <param name="connectionQuotaToCreate">The ConnectionQuota to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ConnectionQuota.</returns>
        System.Threading.Tasks.Task<ConnectionQuota> CreateAsync(ConnectionQuota connectionQuotaToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified ConnectionQuota using POST and returns a <see cref="GraphResponse{ConnectionQuota}"/> object.
        /// </summary>
        /// <param name="connectionQuotaToCreate">The ConnectionQuota to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ConnectionQuota}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ConnectionQuota>> CreateResponseAsync(ConnectionQuota connectionQuotaToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ConnectionQuota.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ConnectionQuota and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ConnectionQuota.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ConnectionQuota.</returns>
        System.Threading.Tasks.Task<ConnectionQuota> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ConnectionQuota and returns a <see cref="GraphResponse{ConnectionQuota}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ConnectionQuota}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ConnectionQuota>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ConnectionQuota using PATCH.
        /// </summary>
        /// <param name="connectionQuotaToUpdate">The ConnectionQuota to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ConnectionQuota.</returns>
        System.Threading.Tasks.Task<ConnectionQuota> UpdateAsync(ConnectionQuota connectionQuotaToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ConnectionQuota using PATCH and returns a <see cref="GraphResponse{ConnectionQuota}"/> object.
        /// </summary>
        /// <param name="connectionQuotaToUpdate">The ConnectionQuota to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ConnectionQuota}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ConnectionQuota>> UpdateResponseAsync(ConnectionQuota connectionQuotaToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ConnectionQuota using PUT.
        /// </summary>
        /// <param name="connectionQuotaToUpdate">The ConnectionQuota object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<ConnectionQuota> PutAsync(ConnectionQuota connectionQuotaToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ConnectionQuota using PUT and returns a <see cref="GraphResponse{ConnectionQuota}"/> object.
        /// </summary>
        /// <param name="connectionQuotaToUpdate">The ConnectionQuota object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{ConnectionQuota}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<ConnectionQuota>> PutResponseAsync(ConnectionQuota connectionQuotaToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IConnectionQuotaRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IConnectionQuotaRequest Expand(Expression<Func<ConnectionQuota, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IConnectionQuotaRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IConnectionQuotaRequest Select(Expression<Func<ConnectionQuota, object>> selectExpression);

    }
}
