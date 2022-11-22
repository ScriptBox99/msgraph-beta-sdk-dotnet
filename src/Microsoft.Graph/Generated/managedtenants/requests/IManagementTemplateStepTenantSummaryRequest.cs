// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IManagementTemplateStepTenantSummaryRequest.
    /// </summary>
    public partial interface IManagementTemplateStepTenantSummaryRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Creates the specified ManagementTemplateStepTenantSummary using POST.
        /// </summary>
        /// <param name="managementTemplateStepTenantSummaryToCreate">The ManagementTemplateStepTenantSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagementTemplateStepTenantSummary.</returns>
        System.Threading.Tasks.Task<ManagementTemplateStepTenantSummary> CreateAsync(ManagementTemplateStepTenantSummary managementTemplateStepTenantSummaryToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified ManagementTemplateStepTenantSummary using POST and returns a <see cref="GraphResponse{ManagementTemplateStepTenantSummary}"/> object.
        /// </summary>
        /// <param name="managementTemplateStepTenantSummaryToCreate">The ManagementTemplateStepTenantSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagementTemplateStepTenantSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagementTemplateStepTenantSummary>> CreateResponseAsync(ManagementTemplateStepTenantSummary managementTemplateStepTenantSummaryToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ManagementTemplateStepTenantSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ManagementTemplateStepTenantSummary and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ManagementTemplateStepTenantSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagementTemplateStepTenantSummary.</returns>
        System.Threading.Tasks.Task<ManagementTemplateStepTenantSummary> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ManagementTemplateStepTenantSummary and returns a <see cref="GraphResponse{ManagementTemplateStepTenantSummary}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagementTemplateStepTenantSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagementTemplateStepTenantSummary>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagementTemplateStepTenantSummary using PATCH.
        /// </summary>
        /// <param name="managementTemplateStepTenantSummaryToUpdate">The ManagementTemplateStepTenantSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagementTemplateStepTenantSummary.</returns>
        System.Threading.Tasks.Task<ManagementTemplateStepTenantSummary> UpdateAsync(ManagementTemplateStepTenantSummary managementTemplateStepTenantSummaryToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagementTemplateStepTenantSummary using PATCH and returns a <see cref="GraphResponse{ManagementTemplateStepTenantSummary}"/> object.
        /// </summary>
        /// <param name="managementTemplateStepTenantSummaryToUpdate">The ManagementTemplateStepTenantSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ManagementTemplateStepTenantSummary}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagementTemplateStepTenantSummary>> UpdateResponseAsync(ManagementTemplateStepTenantSummary managementTemplateStepTenantSummaryToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagementTemplateStepTenantSummary using PUT.
        /// </summary>
        /// <param name="managementTemplateStepTenantSummaryToUpdate">The ManagementTemplateStepTenantSummary object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<ManagementTemplateStepTenantSummary> PutAsync(ManagementTemplateStepTenantSummary managementTemplateStepTenantSummaryToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagementTemplateStepTenantSummary using PUT and returns a <see cref="GraphResponse{ManagementTemplateStepTenantSummary}"/> object.
        /// </summary>
        /// <param name="managementTemplateStepTenantSummaryToUpdate">The ManagementTemplateStepTenantSummary object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{ManagementTemplateStepTenantSummary}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagementTemplateStepTenantSummary>> PutResponseAsync(ManagementTemplateStepTenantSummary managementTemplateStepTenantSummaryToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagementTemplateStepTenantSummaryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagementTemplateStepTenantSummaryRequest Expand(Expression<Func<ManagementTemplateStepTenantSummary, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IManagementTemplateStepTenantSummaryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IManagementTemplateStepTenantSummaryRequest Select(Expression<Func<ManagementTemplateStepTenantSummary, object>> selectExpression);

    }
}
