// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph.WindowsUpdates
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IDeploymentAudienceWithReferenceRequest.
    /// </summary>
    public partial interface IDeploymentAudienceWithReferenceRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Gets the specified DeploymentAudience.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeploymentAudience.</returns>
        System.Threading.Tasks.Task<DeploymentAudience> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified DeploymentAudience and returns a <see cref="GraphResponse{DeploymentAudience}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeploymentAudience}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeploymentAudience>> GetResponseAsync(CancellationToken cancellationToken = default);

		/// <summary>
        /// Creates the specified DeploymentAudience using POST.
        /// </summary>
        /// <param name="deploymentAudienceToCreate">The DeploymentAudience to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeploymentAudience.</returns>
        System.Threading.Tasks.Task<DeploymentAudience> CreateAsync(DeploymentAudience deploymentAudienceToCreate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Creates the specified DeploymentAudience using POST and returns a <see cref="GraphResponse{DeploymentAudience}"/> object.
        /// </summary>
        /// <param name="deploymentAudienceToCreate">The DeploymentAudience to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeploymentAudience}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeploymentAudience>> CreateResponseAsync(DeploymentAudience deploymentAudienceToCreate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Updates the specified DeploymentAudience using PATCH.
        /// </summary>
        /// <param name="deploymentAudienceToUpdate">The DeploymentAudience to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeploymentAudience.</returns>
        System.Threading.Tasks.Task<DeploymentAudience> UpdateAsync(DeploymentAudience deploymentAudienceToUpdate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Updates the specified DeploymentAudience using PATCH and returns a <see cref="GraphResponse{DeploymentAudience}"/> object.
        /// </summary>
        /// <param name="deploymentAudienceToUpdate">The DeploymentAudience to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeploymentAudience}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeploymentAudience>> UpdateResponseAsync(DeploymentAudience deploymentAudienceToUpdate, CancellationToken cancellationToken = default);

		/// <summary>
        /// Deletes the specified DeploymentAudience.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

		/// <summary>
        /// Deletes the specified DeploymentAudience and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeploymentAudienceWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeploymentAudienceWithReferenceRequest Expand(Expression<Func<DeploymentAudience, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeploymentAudienceWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeploymentAudienceWithReferenceRequest Select(Expression<Func<DeploymentAudience, object>> selectExpression);

    }
}
