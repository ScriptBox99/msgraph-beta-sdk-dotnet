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
    /// The interface IEmailActivityUserDetailRequest.
    /// </summary>
    public partial interface IEmailActivityUserDetailRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified EmailActivityUserDetail using POST.
        /// </summary>
        /// <param name="emailActivityUserDetailToCreate">The EmailActivityUserDetail to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EmailActivityUserDetail.</returns>
        System.Threading.Tasks.Task<EmailActivityUserDetail> CreateAsync(EmailActivityUserDetail emailActivityUserDetailToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified EmailActivityUserDetail using POST and returns a <see cref="GraphResponse{EmailActivityUserDetail}"/> object.
        /// </summary>
        /// <param name="emailActivityUserDetailToCreate">The EmailActivityUserDetail to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EmailActivityUserDetail}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EmailActivityUserDetail>> CreateResponseAsync(EmailActivityUserDetail emailActivityUserDetailToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified EmailActivityUserDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified EmailActivityUserDetail and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified EmailActivityUserDetail.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EmailActivityUserDetail.</returns>
        System.Threading.Tasks.Task<EmailActivityUserDetail> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified EmailActivityUserDetail and returns a <see cref="GraphResponse{EmailActivityUserDetail}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EmailActivityUserDetail}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EmailActivityUserDetail>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified EmailActivityUserDetail using PATCH.
        /// </summary>
        /// <param name="emailActivityUserDetailToUpdate">The EmailActivityUserDetail to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EmailActivityUserDetail.</returns>
        System.Threading.Tasks.Task<EmailActivityUserDetail> UpdateAsync(EmailActivityUserDetail emailActivityUserDetailToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified EmailActivityUserDetail using PATCH and returns a <see cref="GraphResponse{EmailActivityUserDetail}"/> object.
        /// </summary>
        /// <param name="emailActivityUserDetailToUpdate">The EmailActivityUserDetail to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EmailActivityUserDetail}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<EmailActivityUserDetail>> UpdateResponseAsync(EmailActivityUserDetail emailActivityUserDetailToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IEmailActivityUserDetailRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IEmailActivityUserDetailRequest Expand(Expression<Func<EmailActivityUserDetail, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IEmailActivityUserDetailRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IEmailActivityUserDetailRequest Select(Expression<Func<EmailActivityUserDetail, object>> selectExpression);

    }
}
