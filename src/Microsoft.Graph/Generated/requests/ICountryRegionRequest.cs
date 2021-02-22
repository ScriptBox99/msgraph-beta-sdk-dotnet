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
    /// The interface ICountryRegionRequest.
    /// </summary>
    public partial interface ICountryRegionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified CountryRegion using POST.
        /// </summary>
        /// <param name="countryRegionToCreate">The CountryRegion to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CountryRegion.</returns>
        System.Threading.Tasks.Task<CountryRegion> CreateAsync(CountryRegion countryRegionToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified CountryRegion using POST and returns a <see cref="GraphResponse{CountryRegion}"/> object.
        /// </summary>
        /// <param name="countryRegionToCreate">The CountryRegion to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CountryRegion}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CountryRegion>> CreateResponseAsync(CountryRegion countryRegionToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified CountryRegion.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified CountryRegion and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified CountryRegion.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CountryRegion.</returns>
        System.Threading.Tasks.Task<CountryRegion> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified CountryRegion and returns a <see cref="GraphResponse{CountryRegion}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CountryRegion}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CountryRegion>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified CountryRegion using PATCH.
        /// </summary>
        /// <param name="countryRegionToUpdate">The CountryRegion to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CountryRegion.</returns>
        System.Threading.Tasks.Task<CountryRegion> UpdateAsync(CountryRegion countryRegionToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified CountryRegion using PATCH and returns a <see cref="GraphResponse{CountryRegion}"/> object.
        /// </summary>
        /// <param name="countryRegionToUpdate">The CountryRegion to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{CountryRegion}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CountryRegion>> UpdateResponseAsync(CountryRegion countryRegionToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICountryRegionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICountryRegionRequest Expand(Expression<Func<CountryRegion, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICountryRegionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICountryRegionRequest Select(Expression<Func<CountryRegion, object>> selectExpression);

    }
}
