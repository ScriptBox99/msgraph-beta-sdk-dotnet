// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ILookupResultRowRequest.
    /// </summary>
    public partial interface ILookupResultRowRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified LookupResultRow using POST.
        /// </summary>
        /// <param name="lookupResultRowToCreate">The LookupResultRow to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created LookupResultRow.</returns>
        System.Threading.Tasks.Task<LookupResultRow> CreateAsync(LookupResultRow lookupResultRowToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified LookupResultRow using POST and returns a <see cref="GraphResponse{LookupResultRow}"/> object.
        /// </summary>
        /// <param name="lookupResultRowToCreate">The LookupResultRow to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{LookupResultRow}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<LookupResultRow>> CreateResponseAsync(LookupResultRow lookupResultRowToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified LookupResultRow.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified LookupResultRow and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified LookupResultRow.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The LookupResultRow.</returns>
        System.Threading.Tasks.Task<LookupResultRow> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified LookupResultRow and returns a <see cref="GraphResponse{LookupResultRow}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{LookupResultRow}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<LookupResultRow>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified LookupResultRow using PATCH.
        /// </summary>
        /// <param name="lookupResultRowToUpdate">The LookupResultRow to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated LookupResultRow.</returns>
        System.Threading.Tasks.Task<LookupResultRow> UpdateAsync(LookupResultRow lookupResultRowToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified LookupResultRow using PATCH and returns a <see cref="GraphResponse{LookupResultRow}"/> object.
        /// </summary>
        /// <param name="lookupResultRowToUpdate">The LookupResultRow to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{LookupResultRow}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<LookupResultRow>> UpdateResponseAsync(LookupResultRow lookupResultRowToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ILookupResultRowRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ILookupResultRowRequest Expand(Expression<Func<LookupResultRow, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ILookupResultRowRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ILookupResultRowRequest Select(Expression<Func<LookupResultRow, object>> selectExpression);

    }
}
