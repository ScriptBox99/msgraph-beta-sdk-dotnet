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
    /// The interface IGroupPolicyPresentationMultiTextBoxRequest.
    /// </summary>
    public partial interface IGroupPolicyPresentationMultiTextBoxRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified GroupPolicyPresentationMultiTextBox using POST.
        /// </summary>
        /// <param name="groupPolicyPresentationMultiTextBoxToCreate">The GroupPolicyPresentationMultiTextBox to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GroupPolicyPresentationMultiTextBox.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationMultiTextBox> CreateAsync(GroupPolicyPresentationMultiTextBox groupPolicyPresentationMultiTextBoxToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified GroupPolicyPresentationMultiTextBox using POST and returns a <see cref="GraphResponse{GroupPolicyPresentationMultiTextBox}"/> object.
        /// </summary>
        /// <param name="groupPolicyPresentationMultiTextBoxToCreate">The GroupPolicyPresentationMultiTextBox to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GroupPolicyPresentationMultiTextBox}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<GroupPolicyPresentationMultiTextBox>> CreateResponseAsync(GroupPolicyPresentationMultiTextBox groupPolicyPresentationMultiTextBoxToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified GroupPolicyPresentationMultiTextBox.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified GroupPolicyPresentationMultiTextBox and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified GroupPolicyPresentationMultiTextBox.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GroupPolicyPresentationMultiTextBox.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationMultiTextBox> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified GroupPolicyPresentationMultiTextBox and returns a <see cref="GraphResponse{GroupPolicyPresentationMultiTextBox}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GroupPolicyPresentationMultiTextBox}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<GroupPolicyPresentationMultiTextBox>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified GroupPolicyPresentationMultiTextBox using PATCH.
        /// </summary>
        /// <param name="groupPolicyPresentationMultiTextBoxToUpdate">The GroupPolicyPresentationMultiTextBox to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated GroupPolicyPresentationMultiTextBox.</returns>
        System.Threading.Tasks.Task<GroupPolicyPresentationMultiTextBox> UpdateAsync(GroupPolicyPresentationMultiTextBox groupPolicyPresentationMultiTextBoxToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified GroupPolicyPresentationMultiTextBox using PATCH and returns a <see cref="GraphResponse{GroupPolicyPresentationMultiTextBox}"/> object.
        /// </summary>
        /// <param name="groupPolicyPresentationMultiTextBoxToUpdate">The GroupPolicyPresentationMultiTextBox to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{GroupPolicyPresentationMultiTextBox}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<GroupPolicyPresentationMultiTextBox>> UpdateResponseAsync(GroupPolicyPresentationMultiTextBox groupPolicyPresentationMultiTextBoxToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationMultiTextBoxRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationMultiTextBoxRequest Expand(Expression<Func<GroupPolicyPresentationMultiTextBox, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationMultiTextBoxRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IGroupPolicyPresentationMultiTextBoxRequest Select(Expression<Func<GroupPolicyPresentationMultiTextBox, object>> selectExpression);

    }
}
