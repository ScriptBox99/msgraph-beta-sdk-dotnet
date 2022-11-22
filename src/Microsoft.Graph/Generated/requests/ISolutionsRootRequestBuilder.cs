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
    /// The interface ISolutionsRootRequestBuilder.
    /// </summary>
    public partial interface ISolutionsRootRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        ISolutionsRootRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        ISolutionsRootRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for BusinessScenarios.
        /// </summary>
        /// <returns>The <see cref="ISolutionsRootBusinessScenariosCollectionRequestBuilder"/>.</returns>
        ISolutionsRootBusinessScenariosCollectionRequestBuilder BusinessScenarios { get; }
    
    }
}
