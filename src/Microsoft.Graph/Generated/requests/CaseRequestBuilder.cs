// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type CaseRequestBuilder.
    /// </summary>
    public partial class CaseRequestBuilder : EntityRequestBuilder, ICaseRequestBuilder
    {

        /// <summary>
        /// Constructs a new CaseRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public CaseRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new ICaseRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new ICaseRequest Request(IEnumerable<Option> options)
        {
            return new CaseRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Custodians.
        /// </summary>
        /// <returns>The <see cref="ICaseCustodiansCollectionRequestBuilder"/>.</returns>
        public ICaseCustodiansCollectionRequestBuilder Custodians
        {
            get
            {
                return new CaseCustodiansCollectionRequestBuilder(this.AppendSegmentToRequestUrl("custodians"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Legalholds.
        /// </summary>
        /// <returns>The <see cref="ICaseLegalholdsCollectionRequestBuilder"/>.</returns>
        public ICaseLegalholdsCollectionRequestBuilder Legalholds
        {
            get
            {
                return new CaseLegalholdsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("legalholds"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Operations.
        /// </summary>
        /// <returns>The <see cref="ICaseOperationsCollectionRequestBuilder"/>.</returns>
        public ICaseOperationsCollectionRequestBuilder Operations
        {
            get
            {
                return new CaseOperationsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("operations"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ReviewSets.
        /// </summary>
        /// <returns>The <see cref="ICaseReviewSetsCollectionRequestBuilder"/>.</returns>
        public ICaseReviewSetsCollectionRequestBuilder ReviewSets
        {
            get
            {
                return new CaseReviewSetsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("reviewSets"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for CaseClose.
        /// </summary>
        /// <returns>The <see cref="ICaseCloseRequestBuilder"/>.</returns>
        public ICaseCloseRequestBuilder Close()
        {
            return new CaseCloseRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.close"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for CaseReopen.
        /// </summary>
        /// <returns>The <see cref="ICaseReopenRequestBuilder"/>.</returns>
        public ICaseReopenRequestBuilder Reopen()
        {
            return new CaseReopenRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.reopen"),
                this.Client);
        }
    
    }
}
