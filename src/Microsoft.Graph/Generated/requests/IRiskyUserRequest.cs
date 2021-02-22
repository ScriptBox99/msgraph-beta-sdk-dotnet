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
    /// The interface IRiskyUserRequest.
    /// </summary>
    public partial interface IRiskyUserRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified RiskyUser using POST.
        /// </summary>
        /// <param name="riskyUserToCreate">The RiskyUser to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created RiskyUser.</returns>
        System.Threading.Tasks.Task<RiskyUser> CreateAsync(RiskyUser riskyUserToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified RiskyUser using POST and returns a <see cref="GraphResponse{RiskyUser}"/> object.
        /// </summary>
        /// <param name="riskyUserToCreate">The RiskyUser to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{RiskyUser}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<RiskyUser>> CreateResponseAsync(RiskyUser riskyUserToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified RiskyUser.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified RiskyUser and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified RiskyUser.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The RiskyUser.</returns>
        System.Threading.Tasks.Task<RiskyUser> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified RiskyUser and returns a <see cref="GraphResponse{RiskyUser}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{RiskyUser}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<RiskyUser>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified RiskyUser using PATCH.
        /// </summary>
        /// <param name="riskyUserToUpdate">The RiskyUser to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated RiskyUser.</returns>
        System.Threading.Tasks.Task<RiskyUser> UpdateAsync(RiskyUser riskyUserToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified RiskyUser using PATCH and returns a <see cref="GraphResponse{RiskyUser}"/> object.
        /// </summary>
        /// <param name="riskyUserToUpdate">The RiskyUser to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{RiskyUser}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<RiskyUser>> UpdateResponseAsync(RiskyUser riskyUserToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IRiskyUserRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IRiskyUserRequest Expand(Expression<Func<RiskyUser, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IRiskyUserRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IRiskyUserRequest Select(Expression<Func<RiskyUser, object>> selectExpression);

    }
}
