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
    /// The interface ISkypeForBusinessOrganizerActivityCountsRequest.
    /// </summary>
    public partial interface ISkypeForBusinessOrganizerActivityCountsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SkypeForBusinessOrganizerActivityCounts using POST.
        /// </summary>
        /// <param name="skypeForBusinessOrganizerActivityCountsToCreate">The SkypeForBusinessOrganizerActivityCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SkypeForBusinessOrganizerActivityCounts.</returns>
        System.Threading.Tasks.Task<SkypeForBusinessOrganizerActivityCounts> CreateAsync(SkypeForBusinessOrganizerActivityCounts skypeForBusinessOrganizerActivityCountsToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified SkypeForBusinessOrganizerActivityCounts using POST and returns a <see cref="GraphResponse{SkypeForBusinessOrganizerActivityCounts}"/> object.
        /// </summary>
        /// <param name="skypeForBusinessOrganizerActivityCountsToCreate">The SkypeForBusinessOrganizerActivityCounts to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SkypeForBusinessOrganizerActivityCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SkypeForBusinessOrganizerActivityCounts>> CreateResponseAsync(SkypeForBusinessOrganizerActivityCounts skypeForBusinessOrganizerActivityCountsToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified SkypeForBusinessOrganizerActivityCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified SkypeForBusinessOrganizerActivityCounts and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified SkypeForBusinessOrganizerActivityCounts.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SkypeForBusinessOrganizerActivityCounts.</returns>
        System.Threading.Tasks.Task<SkypeForBusinessOrganizerActivityCounts> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified SkypeForBusinessOrganizerActivityCounts and returns a <see cref="GraphResponse{SkypeForBusinessOrganizerActivityCounts}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SkypeForBusinessOrganizerActivityCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SkypeForBusinessOrganizerActivityCounts>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified SkypeForBusinessOrganizerActivityCounts using PATCH.
        /// </summary>
        /// <param name="skypeForBusinessOrganizerActivityCountsToUpdate">The SkypeForBusinessOrganizerActivityCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SkypeForBusinessOrganizerActivityCounts.</returns>
        System.Threading.Tasks.Task<SkypeForBusinessOrganizerActivityCounts> UpdateAsync(SkypeForBusinessOrganizerActivityCounts skypeForBusinessOrganizerActivityCountsToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified SkypeForBusinessOrganizerActivityCounts using PATCH and returns a <see cref="GraphResponse{SkypeForBusinessOrganizerActivityCounts}"/> object.
        /// </summary>
        /// <param name="skypeForBusinessOrganizerActivityCountsToUpdate">The SkypeForBusinessOrganizerActivityCounts to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SkypeForBusinessOrganizerActivityCounts}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SkypeForBusinessOrganizerActivityCounts>> UpdateResponseAsync(SkypeForBusinessOrganizerActivityCounts skypeForBusinessOrganizerActivityCountsToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISkypeForBusinessOrganizerActivityCountsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISkypeForBusinessOrganizerActivityCountsRequest Expand(Expression<Func<SkypeForBusinessOrganizerActivityCounts, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISkypeForBusinessOrganizerActivityCountsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISkypeForBusinessOrganizerActivityCountsRequest Select(Expression<Func<SkypeForBusinessOrganizerActivityCounts, object>> selectExpression);

    }
}
