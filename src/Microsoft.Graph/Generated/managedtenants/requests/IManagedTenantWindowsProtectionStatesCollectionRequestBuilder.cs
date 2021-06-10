// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IManagedTenantWindowsProtectionStatesCollectionRequestBuilder.
    /// </summary>
    public partial interface IManagedTenantWindowsProtectionStatesCollectionRequestBuilder : Microsoft.Graph.IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IManagedTenantWindowsProtectionStatesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IManagedTenantWindowsProtectionStatesCollectionRequest Request(IEnumerable<Microsoft.Graph.Option> options);

        /// <summary>
        /// Gets an <see cref="IWindowsProtectionStateRequestBuilder"/> for the specified WindowsProtectionState.
        /// </summary>
        /// <param name="id">The ID for the WindowsProtectionState.</param>
        /// <returns>The <see cref="IWindowsProtectionStateRequestBuilder"/>.</returns>
        IWindowsProtectionStateRequestBuilder this[string id] { get; }

        
    }
}
