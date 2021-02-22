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
    /// The interface IDeviceManagementCollectionSettingInstanceRequest.
    /// </summary>
    public partial interface IDeviceManagementCollectionSettingInstanceRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceManagementCollectionSettingInstance using POST.
        /// </summary>
        /// <param name="deviceManagementCollectionSettingInstanceToCreate">The DeviceManagementCollectionSettingInstance to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementCollectionSettingInstance.</returns>
        System.Threading.Tasks.Task<DeviceManagementCollectionSettingInstance> CreateAsync(DeviceManagementCollectionSettingInstance deviceManagementCollectionSettingInstanceToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified DeviceManagementCollectionSettingInstance using POST and returns a <see cref="GraphResponse{DeviceManagementCollectionSettingInstance}"/> object.
        /// </summary>
        /// <param name="deviceManagementCollectionSettingInstanceToCreate">The DeviceManagementCollectionSettingInstance to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementCollectionSettingInstance}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementCollectionSettingInstance>> CreateResponseAsync(DeviceManagementCollectionSettingInstance deviceManagementCollectionSettingInstanceToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified DeviceManagementCollectionSettingInstance.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified DeviceManagementCollectionSettingInstance and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified DeviceManagementCollectionSettingInstance.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementCollectionSettingInstance.</returns>
        System.Threading.Tasks.Task<DeviceManagementCollectionSettingInstance> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified DeviceManagementCollectionSettingInstance and returns a <see cref="GraphResponse{DeviceManagementCollectionSettingInstance}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementCollectionSettingInstance}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementCollectionSettingInstance>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DeviceManagementCollectionSettingInstance using PATCH.
        /// </summary>
        /// <param name="deviceManagementCollectionSettingInstanceToUpdate">The DeviceManagementCollectionSettingInstance to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementCollectionSettingInstance.</returns>
        System.Threading.Tasks.Task<DeviceManagementCollectionSettingInstance> UpdateAsync(DeviceManagementCollectionSettingInstance deviceManagementCollectionSettingInstanceToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DeviceManagementCollectionSettingInstance using PATCH and returns a <see cref="GraphResponse{DeviceManagementCollectionSettingInstance}"/> object.
        /// </summary>
        /// <param name="deviceManagementCollectionSettingInstanceToUpdate">The DeviceManagementCollectionSettingInstance to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementCollectionSettingInstance}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementCollectionSettingInstance>> UpdateResponseAsync(DeviceManagementCollectionSettingInstance deviceManagementCollectionSettingInstanceToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementCollectionSettingInstanceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementCollectionSettingInstanceRequest Expand(Expression<Func<DeviceManagementCollectionSettingInstance, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementCollectionSettingInstanceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementCollectionSettingInstanceRequest Select(Expression<Func<DeviceManagementCollectionSettingInstance, object>> selectExpression);

    }
}
