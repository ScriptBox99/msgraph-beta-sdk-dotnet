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
    /// The interface IManagementConditionStatementRequest.
    /// </summary>
    public partial interface IManagementConditionStatementRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ManagementConditionStatement using POST.
        /// </summary>
        /// <param name="managementConditionStatementToCreate">The ManagementConditionStatement to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagementConditionStatement.</returns>
        System.Threading.Tasks.Task<ManagementConditionStatement> CreateAsync(ManagementConditionStatement managementConditionStatementToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified ManagementConditionStatement using POST and returns a <see cref="GraphResponse{ManagementConditionStatement}"/> object.
        /// </summary>
        /// <param name="managementConditionStatementToCreate">The ManagementConditionStatement to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagementConditionStatement}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagementConditionStatement>> CreateResponseAsync(ManagementConditionStatement managementConditionStatementToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified ManagementConditionStatement.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified ManagementConditionStatement and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified ManagementConditionStatement.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagementConditionStatement.</returns>
        System.Threading.Tasks.Task<ManagementConditionStatement> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified ManagementConditionStatement and returns a <see cref="GraphResponse{ManagementConditionStatement}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagementConditionStatement}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagementConditionStatement>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ManagementConditionStatement using PATCH.
        /// </summary>
        /// <param name="managementConditionStatementToUpdate">The ManagementConditionStatement to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagementConditionStatement.</returns>
        System.Threading.Tasks.Task<ManagementConditionStatement> UpdateAsync(ManagementConditionStatement managementConditionStatementToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ManagementConditionStatement using PATCH and returns a <see cref="GraphResponse{ManagementConditionStatement}"/> object.
        /// </summary>
        /// <param name="managementConditionStatementToUpdate">The ManagementConditionStatement to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ManagementConditionStatement}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagementConditionStatement>> UpdateResponseAsync(ManagementConditionStatement managementConditionStatementToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagementConditionStatementRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagementConditionStatementRequest Expand(Expression<Func<ManagementConditionStatement, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IManagementConditionStatementRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IManagementConditionStatementRequest Select(Expression<Func<ManagementConditionStatement, object>> selectExpression);

    }
}
