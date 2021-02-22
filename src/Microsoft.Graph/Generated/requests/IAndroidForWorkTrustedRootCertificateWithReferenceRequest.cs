// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IAndroidForWorkTrustedRootCertificateWithReferenceRequest.
    /// </summary>
    public partial interface IAndroidForWorkTrustedRootCertificateWithReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Gets the specified AndroidForWorkTrustedRootCertificate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidForWorkTrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<AndroidForWorkTrustedRootCertificate> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified AndroidForWorkTrustedRootCertificate and returns a <see cref="GraphResponse{AndroidForWorkTrustedRootCertificate}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidForWorkTrustedRootCertificate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidForWorkTrustedRootCertificate>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Creates the specified AndroidForWorkTrustedRootCertificate using POST.
        /// </summary>
        /// <param name="androidForWorkTrustedRootCertificateToCreate">The AndroidForWorkTrustedRootCertificate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidForWorkTrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<AndroidForWorkTrustedRootCertificate> CreateAsync(AndroidForWorkTrustedRootCertificate androidForWorkTrustedRootCertificateToCreate, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Creates the specified AndroidForWorkTrustedRootCertificate using POST and returns a <see cref="GraphResponse{AndroidForWorkTrustedRootCertificate}"/> object.
        /// </summary>
        /// <param name="androidForWorkTrustedRootCertificateToCreate">The AndroidForWorkTrustedRootCertificate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidForWorkTrustedRootCertificate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidForWorkTrustedRootCertificate>> CreateResponseAsync(AndroidForWorkTrustedRootCertificate androidForWorkTrustedRootCertificateToCreate, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Updates the specified AndroidForWorkTrustedRootCertificate using PATCH.
        /// </summary>
        /// <param name="androidForWorkTrustedRootCertificateToUpdate">The AndroidForWorkTrustedRootCertificate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidForWorkTrustedRootCertificate.</returns>
        System.Threading.Tasks.Task<AndroidForWorkTrustedRootCertificate> UpdateAsync(AndroidForWorkTrustedRootCertificate androidForWorkTrustedRootCertificateToUpdate, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Updates the specified AndroidForWorkTrustedRootCertificate using PATCH and returns a <see cref="GraphResponse{AndroidForWorkTrustedRootCertificate}"/> object.
        /// </summary>
        /// <param name="androidForWorkTrustedRootCertificateToUpdate">The AndroidForWorkTrustedRootCertificate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AndroidForWorkTrustedRootCertificate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AndroidForWorkTrustedRootCertificate>> UpdateResponseAsync(AndroidForWorkTrustedRootCertificate androidForWorkTrustedRootCertificateToUpdate, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Deletes the specified AndroidForWorkTrustedRootCertificate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
        /// Deletes the specified AndroidForWorkTrustedRootCertificate and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkTrustedRootCertificateWithReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkTrustedRootCertificateWithReferenceRequest Expand(Expression<Func<AndroidForWorkTrustedRootCertificate, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkTrustedRootCertificateWithReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidForWorkTrustedRootCertificateWithReferenceRequest Select(Expression<Func<AndroidForWorkTrustedRootCertificate, object>> selectExpression);

    }
}
