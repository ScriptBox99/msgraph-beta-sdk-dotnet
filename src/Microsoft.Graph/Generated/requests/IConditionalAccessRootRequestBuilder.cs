// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IConditionalAccessRootRequestBuilder.
    /// </summary>
    public partial interface IConditionalAccessRootRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IConditionalAccessRootRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IConditionalAccessRootRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for AuthenticationStrength.
        /// </summary>
        /// <returns>The <see cref="IAuthenticationStrengthRootRequestBuilder"/>.</returns>
        IAuthenticationStrengthRootRequestBuilder AuthenticationStrength { get; }

        /// <summary>
        /// Gets the request builder for AuthenticationStrengths.
        /// </summary>
        /// <returns>The <see cref="IAuthenticationStrengthRootRequestBuilder"/>.</returns>
        IAuthenticationStrengthRootRequestBuilder AuthenticationStrengths { get; }

        /// <summary>
        /// Gets the request builder for AuthenticationContextClassReferences.
        /// </summary>
        /// <returns>The <see cref="IConditionalAccessRootAuthenticationContextClassReferencesCollectionRequestBuilder"/>.</returns>
        IConditionalAccessRootAuthenticationContextClassReferencesCollectionRequestBuilder AuthenticationContextClassReferences { get; }

        /// <summary>
        /// Gets the request builder for NamedLocations.
        /// </summary>
        /// <returns>The <see cref="IConditionalAccessRootNamedLocationsCollectionRequestBuilder"/>.</returns>
        IConditionalAccessRootNamedLocationsCollectionRequestBuilder NamedLocations { get; }

        /// <summary>
        /// Gets the request builder for Policies.
        /// </summary>
        /// <returns>The <see cref="IConditionalAccessRootPoliciesCollectionRequestBuilder"/>.</returns>
        IConditionalAccessRootPoliciesCollectionRequestBuilder Policies { get; }

        /// <summary>
        /// Gets the request builder for Templates.
        /// </summary>
        /// <returns>The <see cref="IConditionalAccessRootTemplatesCollectionRequestBuilder"/>.</returns>
        IConditionalAccessRootTemplatesCollectionRequestBuilder Templates { get; }
    
    }
}
