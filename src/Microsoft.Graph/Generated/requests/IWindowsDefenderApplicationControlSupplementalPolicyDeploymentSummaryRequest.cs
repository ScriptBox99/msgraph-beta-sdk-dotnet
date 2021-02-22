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
    /// The interface IWindowsDefenderApplicationControlSupplementalPolicyDeploymentSummaryRequest.
    /// </summary>
    public partial interface IWindowsDefenderApplicationControlSupplementalPolicyDeploymentSummaryRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary using POST.
        /// </summary>
        /// <param name="windowsDefenderApplicationControlSupplementalPolicyDeploymentSummaryToCreate">The WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary.</returns>
        System.Threading.Tasks.Task<WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary> CreateAsync(WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary windowsDefenderApplicationControlSupplementalPolicyDeploymentSummaryToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary using POST and returns a <see cref="GraphResponse{WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary}"/> object.
        /// </summary>
        /// <param name="windowsDefenderApplicationControlSupplementalPolicyDeploymentSummaryToCreate">The WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary>> CreateResponseAsync(WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary windowsDefenderApplicationControlSupplementalPolicyDeploymentSummaryToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary.</returns>
        System.Threading.Tasks.Task<WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary and returns a <see cref="GraphResponse{WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary using PATCH.
        /// </summary>
        /// <param name="windowsDefenderApplicationControlSupplementalPolicyDeploymentSummaryToUpdate">The WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary.</returns>
        System.Threading.Tasks.Task<WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary> UpdateAsync(WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary windowsDefenderApplicationControlSupplementalPolicyDeploymentSummaryToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary using PATCH and returns a <see cref="GraphResponse{WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary}"/> object.
        /// </summary>
        /// <param name="windowsDefenderApplicationControlSupplementalPolicyDeploymentSummaryToUpdate">The WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary>> UpdateResponseAsync(WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary windowsDefenderApplicationControlSupplementalPolicyDeploymentSummaryToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsDefenderApplicationControlSupplementalPolicyDeploymentSummaryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsDefenderApplicationControlSupplementalPolicyDeploymentSummaryRequest Expand(Expression<Func<WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsDefenderApplicationControlSupplementalPolicyDeploymentSummaryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsDefenderApplicationControlSupplementalPolicyDeploymentSummaryRequest Select(Expression<Func<WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary, object>> selectExpression);

    }
}
