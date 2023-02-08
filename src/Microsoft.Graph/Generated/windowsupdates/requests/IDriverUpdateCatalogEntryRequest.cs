// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph.WindowsUpdates
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IDriverUpdateCatalogEntryRequest.
    /// </summary>
    public partial interface IDriverUpdateCatalogEntryRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Creates the specified DriverUpdateCatalogEntry using POST.
        /// </summary>
        /// <param name="driverUpdateCatalogEntryToCreate">The DriverUpdateCatalogEntry to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DriverUpdateCatalogEntry.</returns>
        System.Threading.Tasks.Task<DriverUpdateCatalogEntry> CreateAsync(DriverUpdateCatalogEntry driverUpdateCatalogEntryToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified DriverUpdateCatalogEntry using POST and returns a <see cref="GraphResponse{DriverUpdateCatalogEntry}"/> object.
        /// </summary>
        /// <param name="driverUpdateCatalogEntryToCreate">The DriverUpdateCatalogEntry to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DriverUpdateCatalogEntry}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DriverUpdateCatalogEntry>> CreateResponseAsync(DriverUpdateCatalogEntry driverUpdateCatalogEntryToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DriverUpdateCatalogEntry.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified DriverUpdateCatalogEntry and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DriverUpdateCatalogEntry.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DriverUpdateCatalogEntry.</returns>
        System.Threading.Tasks.Task<DriverUpdateCatalogEntry> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DriverUpdateCatalogEntry and returns a <see cref="GraphResponse{DriverUpdateCatalogEntry}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DriverUpdateCatalogEntry}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DriverUpdateCatalogEntry>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DriverUpdateCatalogEntry using PATCH.
        /// </summary>
        /// <param name="driverUpdateCatalogEntryToUpdate">The DriverUpdateCatalogEntry to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DriverUpdateCatalogEntry.</returns>
        System.Threading.Tasks.Task<DriverUpdateCatalogEntry> UpdateAsync(DriverUpdateCatalogEntry driverUpdateCatalogEntryToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DriverUpdateCatalogEntry using PATCH and returns a <see cref="GraphResponse{DriverUpdateCatalogEntry}"/> object.
        /// </summary>
        /// <param name="driverUpdateCatalogEntryToUpdate">The DriverUpdateCatalogEntry to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DriverUpdateCatalogEntry}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DriverUpdateCatalogEntry>> UpdateResponseAsync(DriverUpdateCatalogEntry driverUpdateCatalogEntryToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DriverUpdateCatalogEntry using PUT.
        /// </summary>
        /// <param name="driverUpdateCatalogEntryToUpdate">The DriverUpdateCatalogEntry object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<DriverUpdateCatalogEntry> PutAsync(DriverUpdateCatalogEntry driverUpdateCatalogEntryToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified DriverUpdateCatalogEntry using PUT and returns a <see cref="GraphResponse{DriverUpdateCatalogEntry}"/> object.
        /// </summary>
        /// <param name="driverUpdateCatalogEntryToUpdate">The DriverUpdateCatalogEntry object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{DriverUpdateCatalogEntry}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<DriverUpdateCatalogEntry>> PutResponseAsync(DriverUpdateCatalogEntry driverUpdateCatalogEntryToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDriverUpdateCatalogEntryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDriverUpdateCatalogEntryRequest Expand(Expression<Func<DriverUpdateCatalogEntry, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDriverUpdateCatalogEntryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDriverUpdateCatalogEntryRequest Select(Expression<Func<DriverUpdateCatalogEntry, object>> selectExpression);

    }
}
