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
    /// The interface IUserActivityRequest.
    /// </summary>
    public partial interface IUserActivityRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified UserActivity using POST.
        /// </summary>
        /// <param name="userActivityToCreate">The UserActivity to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UserActivity.</returns>
        System.Threading.Tasks.Task<UserActivity> CreateAsync(UserActivity userActivityToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified UserActivity using POST and returns a <see cref="GraphResponse{UserActivity}"/> object.
        /// </summary>
        /// <param name="userActivityToCreate">The UserActivity to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserActivity}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserActivity>> CreateResponseAsync(UserActivity userActivityToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified UserActivity.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified UserActivity and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified UserActivity.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UserActivity.</returns>
        System.Threading.Tasks.Task<UserActivity> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified UserActivity and returns a <see cref="GraphResponse{UserActivity}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserActivity}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserActivity>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified UserActivity using PATCH.
        /// </summary>
        /// <param name="userActivityToUpdate">The UserActivity to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UserActivity.</returns>
        System.Threading.Tasks.Task<UserActivity> UpdateAsync(UserActivity userActivityToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified UserActivity using PATCH and returns a <see cref="GraphResponse{UserActivity}"/> object.
        /// </summary>
        /// <param name="userActivityToUpdate">The UserActivity to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UserActivity}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserActivity>> UpdateResponseAsync(UserActivity userActivityToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserActivityRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserActivityRequest Expand(Expression<Func<UserActivity, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUserActivityRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUserActivityRequest Select(Expression<Func<UserActivity, object>> selectExpression);

    }
}
