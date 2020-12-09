// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IReviewSetRequestBuilder.
    /// </summary>
    public partial interface IReviewSetRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IReviewSetRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IReviewSetRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Queries.
        /// </summary>
        /// <returns>The <see cref="IReviewSetQueriesCollectionRequestBuilder"/>.</returns>
        IReviewSetQueriesCollectionRequestBuilder Queries { get; }
    
        /// <summary>
        /// Gets the request builder for ReviewSetExport.
        /// </summary>
        /// <returns>The <see cref="IReviewSetExportRequestBuilder"/>.</returns>
        IReviewSetExportRequestBuilder Export(
            ExportFileStructure exportStructure,
            string outputName = null,
            string description = null,
            string azureBlobContainer = null,
            string azureBlobToken = null,
            ExportOptions? exportOptions = null);
    
    }
}
