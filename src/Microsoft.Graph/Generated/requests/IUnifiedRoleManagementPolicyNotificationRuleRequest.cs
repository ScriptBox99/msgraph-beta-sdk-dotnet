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
    /// The interface IUnifiedRoleManagementPolicyNotificationRuleRequest.
    /// </summary>
    public partial interface IUnifiedRoleManagementPolicyNotificationRuleRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified UnifiedRoleManagementPolicyNotificationRule using POST.
        /// </summary>
        /// <param name="unifiedRoleManagementPolicyNotificationRuleToCreate">The UnifiedRoleManagementPolicyNotificationRule to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UnifiedRoleManagementPolicyNotificationRule.</returns>
        System.Threading.Tasks.Task<UnifiedRoleManagementPolicyNotificationRule> CreateAsync(UnifiedRoleManagementPolicyNotificationRule unifiedRoleManagementPolicyNotificationRuleToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified UnifiedRoleManagementPolicyNotificationRule using POST and returns a <see cref="GraphResponse{UnifiedRoleManagementPolicyNotificationRule}"/> object.
        /// </summary>
        /// <param name="unifiedRoleManagementPolicyNotificationRuleToCreate">The UnifiedRoleManagementPolicyNotificationRule to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleManagementPolicyNotificationRule}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRoleManagementPolicyNotificationRule>> CreateResponseAsync(UnifiedRoleManagementPolicyNotificationRule unifiedRoleManagementPolicyNotificationRuleToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified UnifiedRoleManagementPolicyNotificationRule.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified UnifiedRoleManagementPolicyNotificationRule and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified UnifiedRoleManagementPolicyNotificationRule.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UnifiedRoleManagementPolicyNotificationRule.</returns>
        System.Threading.Tasks.Task<UnifiedRoleManagementPolicyNotificationRule> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified UnifiedRoleManagementPolicyNotificationRule and returns a <see cref="GraphResponse{UnifiedRoleManagementPolicyNotificationRule}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleManagementPolicyNotificationRule}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRoleManagementPolicyNotificationRule>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified UnifiedRoleManagementPolicyNotificationRule using PATCH.
        /// </summary>
        /// <param name="unifiedRoleManagementPolicyNotificationRuleToUpdate">The UnifiedRoleManagementPolicyNotificationRule to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UnifiedRoleManagementPolicyNotificationRule.</returns>
        System.Threading.Tasks.Task<UnifiedRoleManagementPolicyNotificationRule> UpdateAsync(UnifiedRoleManagementPolicyNotificationRule unifiedRoleManagementPolicyNotificationRuleToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified UnifiedRoleManagementPolicyNotificationRule using PATCH and returns a <see cref="GraphResponse{UnifiedRoleManagementPolicyNotificationRule}"/> object.
        /// </summary>
        /// <param name="unifiedRoleManagementPolicyNotificationRuleToUpdate">The UnifiedRoleManagementPolicyNotificationRule to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UnifiedRoleManagementPolicyNotificationRule}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UnifiedRoleManagementPolicyNotificationRule>> UpdateResponseAsync(UnifiedRoleManagementPolicyNotificationRule unifiedRoleManagementPolicyNotificationRuleToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleManagementPolicyNotificationRuleRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleManagementPolicyNotificationRuleRequest Expand(Expression<Func<UnifiedRoleManagementPolicyNotificationRule, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleManagementPolicyNotificationRuleRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUnifiedRoleManagementPolicyNotificationRuleRequest Select(Expression<Func<UnifiedRoleManagementPolicyNotificationRule, object>> selectExpression);

    }
}
