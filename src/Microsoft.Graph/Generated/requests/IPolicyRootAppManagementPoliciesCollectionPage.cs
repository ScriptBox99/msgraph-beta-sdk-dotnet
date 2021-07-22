// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionPage.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The interface IPolicyRootAppManagementPoliciesCollectionPage.
    /// </summary>
    [InterfaceConverter(typeof(InterfaceConverter<PolicyRootAppManagementPoliciesCollectionPage>))]
    public interface IPolicyRootAppManagementPoliciesCollectionPage : ICollectionPage<AppManagementPolicy>
    {
        /// <summary>
        /// Gets the next page <see cref="IPolicyRootAppManagementPoliciesCollectionRequest"/> instance.
        /// </summary>
        IPolicyRootAppManagementPoliciesCollectionRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}
