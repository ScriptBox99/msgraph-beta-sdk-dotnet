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
    /// The interface IDeviceManagementScriptDeviceStateRequest.
    /// </summary>
    public partial interface IDeviceManagementScriptDeviceStateRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceManagementScriptDeviceState using POST.
        /// </summary>
        /// <param name="deviceManagementScriptDeviceStateToCreate">The DeviceManagementScriptDeviceState to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementScriptDeviceState.</returns>
        System.Threading.Tasks.Task<DeviceManagementScriptDeviceState> CreateAsync(DeviceManagementScriptDeviceState deviceManagementScriptDeviceStateToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified DeviceManagementScriptDeviceState using POST and returns a <see cref="GraphResponse{DeviceManagementScriptDeviceState}"/> object.
        /// </summary>
        /// <param name="deviceManagementScriptDeviceStateToCreate">The DeviceManagementScriptDeviceState to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementScriptDeviceState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementScriptDeviceState>> CreateResponseAsync(DeviceManagementScriptDeviceState deviceManagementScriptDeviceStateToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified DeviceManagementScriptDeviceState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified DeviceManagementScriptDeviceState and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified DeviceManagementScriptDeviceState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementScriptDeviceState.</returns>
        System.Threading.Tasks.Task<DeviceManagementScriptDeviceState> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified DeviceManagementScriptDeviceState and returns a <see cref="GraphResponse{DeviceManagementScriptDeviceState}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementScriptDeviceState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementScriptDeviceState>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DeviceManagementScriptDeviceState using PATCH.
        /// </summary>
        /// <param name="deviceManagementScriptDeviceStateToUpdate">The DeviceManagementScriptDeviceState to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementScriptDeviceState.</returns>
        System.Threading.Tasks.Task<DeviceManagementScriptDeviceState> UpdateAsync(DeviceManagementScriptDeviceState deviceManagementScriptDeviceStateToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DeviceManagementScriptDeviceState using PATCH and returns a <see cref="GraphResponse{DeviceManagementScriptDeviceState}"/> object.
        /// </summary>
        /// <param name="deviceManagementScriptDeviceStateToUpdate">The DeviceManagementScriptDeviceState to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementScriptDeviceState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DeviceManagementScriptDeviceState>> UpdateResponseAsync(DeviceManagementScriptDeviceState deviceManagementScriptDeviceStateToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementScriptDeviceStateRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementScriptDeviceStateRequest Expand(Expression<Func<DeviceManagementScriptDeviceState, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementScriptDeviceStateRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceManagementScriptDeviceStateRequest Select(Expression<Func<DeviceManagementScriptDeviceState, object>> selectExpression);

    }
}
