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
    /// The interface IFileClassificationRequestRequest.
    /// </summary>
    public partial interface IFileClassificationRequestRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified FileClassificationRequestObject using POST.
        /// </summary>
        /// <param name="fileClassificationRequestObjectToCreate">The FileClassificationRequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created FileClassificationRequestObject.</returns>
        System.Threading.Tasks.Task<FileClassificationRequestObject> CreateAsync(FileClassificationRequestObject fileClassificationRequestObjectToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified FileClassificationRequestObject using POST and returns a <see cref="GraphResponse{FileClassificationRequestObject}"/> object.
        /// </summary>
        /// <param name="fileClassificationRequestObjectToCreate">The FileClassificationRequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{FileClassificationRequestObject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<FileClassificationRequestObject>> CreateResponseAsync(FileClassificationRequestObject fileClassificationRequestObjectToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified FileClassificationRequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified FileClassificationRequestObject and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified FileClassificationRequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The FileClassificationRequestObject.</returns>
        System.Threading.Tasks.Task<FileClassificationRequestObject> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified FileClassificationRequestObject and returns a <see cref="GraphResponse{FileClassificationRequestObject}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{FileClassificationRequestObject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<FileClassificationRequestObject>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified FileClassificationRequestObject using PATCH.
        /// </summary>
        /// <param name="fileClassificationRequestObjectToUpdate">The FileClassificationRequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated FileClassificationRequestObject.</returns>
        System.Threading.Tasks.Task<FileClassificationRequestObject> UpdateAsync(FileClassificationRequestObject fileClassificationRequestObjectToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified FileClassificationRequestObject using PATCH and returns a <see cref="GraphResponse{FileClassificationRequestObject}"/> object.
        /// </summary>
        /// <param name="fileClassificationRequestObjectToUpdate">The FileClassificationRequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{FileClassificationRequestObject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<FileClassificationRequestObject>> UpdateResponseAsync(FileClassificationRequestObject fileClassificationRequestObjectToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IFileClassificationRequestRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IFileClassificationRequestRequest Expand(Expression<Func<FileClassificationRequestObject, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IFileClassificationRequestRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IFileClassificationRequestRequest Select(Expression<Func<FileClassificationRequestObject, object>> selectExpression);

    }
}
