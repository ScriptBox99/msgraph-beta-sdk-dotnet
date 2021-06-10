// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ICredentialUserRegistrationsSummaryRequest.
    /// </summary>
    public partial interface ICredentialUserRegistrationsSummaryRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Creates the specified CredentialUserRegistrationsSummary using POST.
        /// </summary>
        /// <param name="credentialUserRegistrationsSummaryToCreate">The CredentialUserRegistrationsSummary to create.</param>
        /// <returns>The created CredentialUserRegistrationsSummary.</returns>
        System.Threading.Tasks.Task<CredentialUserRegistrationsSummary> CreateAsync(CredentialUserRegistrationsSummary credentialUserRegistrationsSummaryToCreate);        /// <summary>
        /// Creates the specified CredentialUserRegistrationsSummary using POST.
        /// </summary>
        /// <param name="credentialUserRegistrationsSummaryToCreate">The CredentialUserRegistrationsSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CredentialUserRegistrationsSummary.</returns>
        System.Threading.Tasks.Task<CredentialUserRegistrationsSummary> CreateAsync(CredentialUserRegistrationsSummary credentialUserRegistrationsSummaryToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified CredentialUserRegistrationsSummary.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified CredentialUserRegistrationsSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified CredentialUserRegistrationsSummary.
        /// </summary>
        /// <returns>The CredentialUserRegistrationsSummary.</returns>
        System.Threading.Tasks.Task<CredentialUserRegistrationsSummary> GetAsync();

        /// <summary>
        /// Gets the specified CredentialUserRegistrationsSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CredentialUserRegistrationsSummary.</returns>
        System.Threading.Tasks.Task<CredentialUserRegistrationsSummary> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified CredentialUserRegistrationsSummary using PATCH.
        /// </summary>
        /// <param name="credentialUserRegistrationsSummaryToUpdate">The CredentialUserRegistrationsSummary to update.</param>
        /// <returns>The updated CredentialUserRegistrationsSummary.</returns>
        System.Threading.Tasks.Task<CredentialUserRegistrationsSummary> UpdateAsync(CredentialUserRegistrationsSummary credentialUserRegistrationsSummaryToUpdate);

        /// <summary>
        /// Updates the specified CredentialUserRegistrationsSummary using PATCH.
        /// </summary>
        /// <param name="credentialUserRegistrationsSummaryToUpdate">The CredentialUserRegistrationsSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CredentialUserRegistrationsSummary.</returns>
        System.Threading.Tasks.Task<CredentialUserRegistrationsSummary> UpdateAsync(CredentialUserRegistrationsSummary credentialUserRegistrationsSummaryToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICredentialUserRegistrationsSummaryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICredentialUserRegistrationsSummaryRequest Expand(Expression<Func<CredentialUserRegistrationsSummary, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICredentialUserRegistrationsSummaryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICredentialUserRegistrationsSummaryRequest Select(Expression<Func<CredentialUserRegistrationsSummary, object>> selectExpression);

    }
}
