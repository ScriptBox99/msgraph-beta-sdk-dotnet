// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type B2xIdentityUserFlowUserAttributeAssignmentsCollectionRequestBuilder.
    /// </summary>
    public partial class B2xIdentityUserFlowUserAttributeAssignmentsCollectionRequestBuilder : BaseRequestBuilder, IB2xIdentityUserFlowUserAttributeAssignmentsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new B2xIdentityUserFlowUserAttributeAssignmentsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public B2xIdentityUserFlowUserAttributeAssignmentsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IB2xIdentityUserFlowUserAttributeAssignmentsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IB2xIdentityUserFlowUserAttributeAssignmentsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new B2xIdentityUserFlowUserAttributeAssignmentsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IIdentityUserFlowAttributeAssignmentRequestBuilder"/> for the specified B2xIdentityUserFlowIdentityUserFlowAttributeAssignment.
        /// </summary>
        /// <param name="id">The ID for the B2xIdentityUserFlowIdentityUserFlowAttributeAssignment.</param>
        /// <returns>The <see cref="IIdentityUserFlowAttributeAssignmentRequestBuilder"/>.</returns>
        public IIdentityUserFlowAttributeAssignmentRequestBuilder this[string id]
        {
            get
            {
                return new IdentityUserFlowAttributeAssignmentRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for IdentityUserFlowAttributeAssignmentSetOrder.
        /// </summary>
        /// <returns>The <see cref="IIdentityUserFlowAttributeAssignmentSetOrderRequestBuilder"/>.</returns>
        public IIdentityUserFlowAttributeAssignmentSetOrderRequestBuilder SetOrder(
            AssignmentOrder newAssignmentOrder = null)
        {
            return new IdentityUserFlowAttributeAssignmentSetOrderRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.setOrder"),
                this.Client,
                newAssignmentOrder);
        }

        /// <summary>
        /// Gets the request builder for IdentityUserFlowAttributeAssignmentGetOrder.
        /// </summary>
        /// <returns>The <see cref="IIdentityUserFlowAttributeAssignmentGetOrderRequestBuilder"/>.</returns>
        public IIdentityUserFlowAttributeAssignmentGetOrderRequestBuilder GetOrder()
        {
            return new IdentityUserFlowAttributeAssignmentGetOrderRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getOrder"),
                this.Client);
        }
    }
}
