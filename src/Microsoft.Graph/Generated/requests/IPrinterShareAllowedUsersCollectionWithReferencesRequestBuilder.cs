// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IPrinterShareAllowedUsersCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial interface IPrinterShareAllowedUsersCollectionWithReferencesRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IPrinterShareAllowedUsersCollectionWithReferencesRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IPrinterShareAllowedUsersCollectionWithReferencesRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IUserWithReferenceRequestBuilder"/> for the specified User.
        /// </summary>
        /// <param name="id">The ID for the User.</param>
        /// <returns>The <see cref="IUserWithReferenceRequestBuilder"/>.</returns>
        IUserWithReferenceRequestBuilder this[string id] { get; }
        
        /// <summary>
        /// Gets an <see cref="IPrinterShareAllowedUsersCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IPrinterShareAllowedUsersCollectionReferencesRequestBuilder"/>.</returns>
        IPrinterShareAllowedUsersCollectionReferencesRequestBuilder References { get; }

    }
}
