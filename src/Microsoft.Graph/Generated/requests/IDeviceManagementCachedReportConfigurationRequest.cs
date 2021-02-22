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
    /// The interface IDeviceManagementCachedReportConfigurationRequest.
    /// </summary>
    public partial interface IDeviceManagementCachedReportConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceManagementCachedReportConfiguration using POST.
        /// </summary>
        /// <param name="deviceManagementCachedReportConfigurationToCreate">The DeviceManagementCachedReportConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementCachedReportConfiguration.</returns>
        System.Threading.Tasks.Task<DeviceManagementCachedReportConfiguration> CreateAsync(DeviceManagementCachedReportConfiguration deviceManagementCachedReportConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified DeviceManagementCachedReportConfiguration using POST and returns a <see cref="GraphResponse{DeviceManagementCachedReportConfiguration}"/> object.
        /// </summary>
        /// <param name="deviceManagementCachedReportConfigurationToCreate">The DeviceManagementCachedReportConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementCachedReportConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementCachedReportConfiguration>> CreateResponseAsync(DeviceManagementCachedReportConfiguration deviceManagementCachedReportConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified DeviceManagementCachedReportConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified DeviceManagementCachedReportConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified DeviceManagementCachedReportConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementCachedReportConfiguration.</returns>
        System.Threading.Tasks.Task<DeviceManagementCachedReportConfiguration> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified DeviceManagementCachedReportConfiguration and returns a <see cref="GraphResponse{DeviceManagementCachedReportConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementCachedReportConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementCachedReportConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DeviceManagementCachedReportConfiguration using PATCH.
        /// </summary>
        /// <param name="deviceManagementCachedReportConfigurationToUpdate">The DeviceManagementCachedReportConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementCachedReportConfiguration.</returns>
        System.Threading.Tasks.Task<DeviceManagementCachedReportConfiguration> UpdateAsync(DeviceManagementCachedReportConfiguration deviceManagementCachedReportConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DeviceManagementCachedReportConfiguration using PATCH and returns a <see cref="GraphResponse{DeviceManagementCachedReportConfiguration}"/> object.
        /// </summary>
        /// <param name="deviceManagementCachedReportConfigurationToUpdate">The DeviceManagementCachedReportConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementCachedReportConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementCachedReportConfiguration>> UpdateResponseAsync(DeviceManagementCachedReportConfiguration deviceManagementCachedReportConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementCachedReportConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementCachedReportConfigurationRequest Expand(Expression<Func<DeviceManagementCachedReportConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementCachedReportConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementCachedReportConfigurationRequest Select(Expression<Func<DeviceManagementCachedReportConfiguration, object>> selectExpression);

    }
}
