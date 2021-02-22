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
    /// The interface IWindowsDefenderAdvancedThreatProtectionConfigurationRequest.
    /// </summary>
    public partial interface IWindowsDefenderAdvancedThreatProtectionConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsDefenderAdvancedThreatProtectionConfiguration using POST.
        /// </summary>
        /// <param name="windowsDefenderAdvancedThreatProtectionConfigurationToCreate">The WindowsDefenderAdvancedThreatProtectionConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsDefenderAdvancedThreatProtectionConfiguration.</returns>
        System.Threading.Tasks.Task<WindowsDefenderAdvancedThreatProtectionConfiguration> CreateAsync(WindowsDefenderAdvancedThreatProtectionConfiguration windowsDefenderAdvancedThreatProtectionConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified WindowsDefenderAdvancedThreatProtectionConfiguration using POST and returns a <see cref="GraphResponse{WindowsDefenderAdvancedThreatProtectionConfiguration}"/> object.
        /// </summary>
        /// <param name="windowsDefenderAdvancedThreatProtectionConfigurationToCreate">The WindowsDefenderAdvancedThreatProtectionConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsDefenderAdvancedThreatProtectionConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsDefenderAdvancedThreatProtectionConfiguration>> CreateResponseAsync(WindowsDefenderAdvancedThreatProtectionConfiguration windowsDefenderAdvancedThreatProtectionConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified WindowsDefenderAdvancedThreatProtectionConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified WindowsDefenderAdvancedThreatProtectionConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified WindowsDefenderAdvancedThreatProtectionConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsDefenderAdvancedThreatProtectionConfiguration.</returns>
        System.Threading.Tasks.Task<WindowsDefenderAdvancedThreatProtectionConfiguration> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified WindowsDefenderAdvancedThreatProtectionConfiguration and returns a <see cref="GraphResponse{WindowsDefenderAdvancedThreatProtectionConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsDefenderAdvancedThreatProtectionConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsDefenderAdvancedThreatProtectionConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WindowsDefenderAdvancedThreatProtectionConfiguration using PATCH.
        /// </summary>
        /// <param name="windowsDefenderAdvancedThreatProtectionConfigurationToUpdate">The WindowsDefenderAdvancedThreatProtectionConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsDefenderAdvancedThreatProtectionConfiguration.</returns>
        System.Threading.Tasks.Task<WindowsDefenderAdvancedThreatProtectionConfiguration> UpdateAsync(WindowsDefenderAdvancedThreatProtectionConfiguration windowsDefenderAdvancedThreatProtectionConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WindowsDefenderAdvancedThreatProtectionConfiguration using PATCH and returns a <see cref="GraphResponse{WindowsDefenderAdvancedThreatProtectionConfiguration}"/> object.
        /// </summary>
        /// <param name="windowsDefenderAdvancedThreatProtectionConfigurationToUpdate">The WindowsDefenderAdvancedThreatProtectionConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WindowsDefenderAdvancedThreatProtectionConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsDefenderAdvancedThreatProtectionConfiguration>> UpdateResponseAsync(WindowsDefenderAdvancedThreatProtectionConfiguration windowsDefenderAdvancedThreatProtectionConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsDefenderAdvancedThreatProtectionConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsDefenderAdvancedThreatProtectionConfigurationRequest Expand(Expression<Func<WindowsDefenderAdvancedThreatProtectionConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsDefenderAdvancedThreatProtectionConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsDefenderAdvancedThreatProtectionConfigurationRequest Select(Expression<Func<WindowsDefenderAdvancedThreatProtectionConfiguration, object>> selectExpression);

    }
}
