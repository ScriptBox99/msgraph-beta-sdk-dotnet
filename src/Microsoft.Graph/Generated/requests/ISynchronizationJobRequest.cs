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
    /// The interface ISynchronizationJobRequest.
    /// </summary>
    public partial interface ISynchronizationJobRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SynchronizationJob using POST.
        /// </summary>
        /// <param name="synchronizationJobToCreate">The SynchronizationJob to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SynchronizationJob.</returns>
        System.Threading.Tasks.Task<SynchronizationJob> CreateAsync(SynchronizationJob synchronizationJobToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified SynchronizationJob using POST and returns a <see cref="GraphResponse{SynchronizationJob}"/> object.
        /// </summary>
        /// <param name="synchronizationJobToCreate">The SynchronizationJob to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SynchronizationJob}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SynchronizationJob>> CreateResponseAsync(SynchronizationJob synchronizationJobToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified SynchronizationJob.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified SynchronizationJob and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified SynchronizationJob.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SynchronizationJob.</returns>
        System.Threading.Tasks.Task<SynchronizationJob> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified SynchronizationJob and returns a <see cref="GraphResponse{SynchronizationJob}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SynchronizationJob}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SynchronizationJob>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified SynchronizationJob using PATCH.
        /// </summary>
        /// <param name="synchronizationJobToUpdate">The SynchronizationJob to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SynchronizationJob.</returns>
        System.Threading.Tasks.Task<SynchronizationJob> UpdateAsync(SynchronizationJob synchronizationJobToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified SynchronizationJob using PATCH and returns a <see cref="GraphResponse{SynchronizationJob}"/> object.
        /// </summary>
        /// <param name="synchronizationJobToUpdate">The SynchronizationJob to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SynchronizationJob}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SynchronizationJob>> UpdateResponseAsync(SynchronizationJob synchronizationJobToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISynchronizationJobRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISynchronizationJobRequest Expand(Expression<Func<SynchronizationJob, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISynchronizationJobRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISynchronizationJobRequest Select(Expression<Func<SynchronizationJob, object>> selectExpression);

    }
}
