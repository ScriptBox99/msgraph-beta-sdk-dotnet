// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type AccessPackageRequestBuilder.
    /// </summary>
    public partial class AccessPackageRequestBuilder : EntityRequestBuilder, IAccessPackageRequestBuilder
    {

        /// <summary>
        /// Constructs a new AccessPackageRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AccessPackageRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IAccessPackageRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IAccessPackageRequest Request(IEnumerable<Option> options)
        {
            return new AccessPackageRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for AccessPackageAssignmentPolicies.
        /// </summary>
        /// <returns>The <see cref="IAccessPackageAccessPackageAssignmentPoliciesCollectionRequestBuilder"/>.</returns>
        public IAccessPackageAccessPackageAssignmentPoliciesCollectionRequestBuilder AccessPackageAssignmentPolicies
        {
            get
            {
                return new AccessPackageAccessPackageAssignmentPoliciesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("accessPackageAssignmentPolicies"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for AccessPackageCatalog.
        /// </summary>
        /// <returns>The <see cref="IAccessPackageCatalogWithReferenceRequestBuilder"/>.</returns>
        public IAccessPackageCatalogWithReferenceRequestBuilder AccessPackageCatalog
        {
            get
            {
                return new AccessPackageCatalogWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("accessPackageCatalog"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for AccessPackageResourceRoleScopes.
        /// </summary>
        /// <returns>The <see cref="IAccessPackageAccessPackageResourceRoleScopesCollectionRequestBuilder"/>.</returns>
        public IAccessPackageAccessPackageResourceRoleScopesCollectionRequestBuilder AccessPackageResourceRoleScopes
        {
            get
            {
                return new AccessPackageAccessPackageResourceRoleScopesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("accessPackageResourceRoleScopes"), this.Client);
            }
        }
    
        
    
    }
}
