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
    /// The interface IAndroidDeviceOwnerEnrollmentProfileRequest.
    /// </summary>
    public partial interface IAndroidDeviceOwnerEnrollmentProfileRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AndroidDeviceOwnerEnrollmentProfile using POST.
        /// </summary>
        /// <param name="androidDeviceOwnerEnrollmentProfileToCreate">The AndroidDeviceOwnerEnrollmentProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidDeviceOwnerEnrollmentProfile.</returns>
        System.Threading.Tasks.Task<AndroidDeviceOwnerEnrollmentProfile> CreateAsync(AndroidDeviceOwnerEnrollmentProfile androidDeviceOwnerEnrollmentProfileToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified AndroidDeviceOwnerEnrollmentProfile using POST and returns a <see cref="GraphResponse{AndroidDeviceOwnerEnrollmentProfile}"/> object.
        /// </summary>
        /// <param name="androidDeviceOwnerEnrollmentProfileToCreate">The AndroidDeviceOwnerEnrollmentProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceOwnerEnrollmentProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidDeviceOwnerEnrollmentProfile>> CreateResponseAsync(AndroidDeviceOwnerEnrollmentProfile androidDeviceOwnerEnrollmentProfileToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AndroidDeviceOwnerEnrollmentProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified AndroidDeviceOwnerEnrollmentProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AndroidDeviceOwnerEnrollmentProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidDeviceOwnerEnrollmentProfile.</returns>
        System.Threading.Tasks.Task<AndroidDeviceOwnerEnrollmentProfile> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AndroidDeviceOwnerEnrollmentProfile and returns a <see cref="GraphResponse{AndroidDeviceOwnerEnrollmentProfile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceOwnerEnrollmentProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidDeviceOwnerEnrollmentProfile>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AndroidDeviceOwnerEnrollmentProfile using PATCH.
        /// </summary>
        /// <param name="androidDeviceOwnerEnrollmentProfileToUpdate">The AndroidDeviceOwnerEnrollmentProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidDeviceOwnerEnrollmentProfile.</returns>
        System.Threading.Tasks.Task<AndroidDeviceOwnerEnrollmentProfile> UpdateAsync(AndroidDeviceOwnerEnrollmentProfile androidDeviceOwnerEnrollmentProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified AndroidDeviceOwnerEnrollmentProfile using PATCH and returns a <see cref="GraphResponse{AndroidDeviceOwnerEnrollmentProfile}"/> object.
        /// </summary>
        /// <param name="androidDeviceOwnerEnrollmentProfileToUpdate">The AndroidDeviceOwnerEnrollmentProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AndroidDeviceOwnerEnrollmentProfile}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidDeviceOwnerEnrollmentProfile>> UpdateResponseAsync(AndroidDeviceOwnerEnrollmentProfile androidDeviceOwnerEnrollmentProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidDeviceOwnerEnrollmentProfileRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidDeviceOwnerEnrollmentProfileRequest Expand(Expression<Func<AndroidDeviceOwnerEnrollmentProfile, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidDeviceOwnerEnrollmentProfileRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidDeviceOwnerEnrollmentProfileRequest Select(Expression<Func<AndroidDeviceOwnerEnrollmentProfile, object>> selectExpression);

    }
}
