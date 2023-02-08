// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IAdminWindowsUpdatesDeploymentsCollectionRequest.
    /// </summary>
    public partial interface IAdminWindowsUpdatesDeploymentsCollectionRequest : IBaseRequest
    {
        /// <summary>
        /// Adds the specified Microsoft.Graph.WindowsUpdates.Deployment to the collection via POST.
        /// </summary>
        /// <param name="deployment">The Microsoft.Graph.WindowsUpdates.Deployment to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Microsoft.Graph.WindowsUpdates.Deployment.</returns>
        System.Threading.Tasks.Task<Microsoft.Graph.WindowsUpdates.Deployment> AddAsync(Microsoft.Graph.WindowsUpdates.Deployment deployment, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified Microsoft.Graph.WindowsUpdates.Deployment to the collection via POST and returns a <see cref="GraphResponse{Microsoft.Graph.WindowsUpdates.Deployment}"/> object of the request.
        /// </summary>
        /// <param name="deployment">The Microsoft.Graph.WindowsUpdates.Deployment to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Microsoft.Graph.WindowsUpdates.Deployment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Microsoft.Graph.WindowsUpdates.Deployment>> AddResponseAsync(Microsoft.Graph.WindowsUpdates.Deployment deployment, CancellationToken cancellationToken = default);


        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IAdminWindowsUpdatesDeploymentsCollectionPage> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{AdminWindowsUpdatesDeploymentsCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AdminWindowsUpdatesDeploymentsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<AdminWindowsUpdatesDeploymentsCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAdminWindowsUpdatesDeploymentsCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAdminWindowsUpdatesDeploymentsCollectionRequest Expand(Expression<Func<Microsoft.Graph.WindowsUpdates.Deployment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAdminWindowsUpdatesDeploymentsCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAdminWindowsUpdatesDeploymentsCollectionRequest Select(Expression<Func<Microsoft.Graph.WindowsUpdates.Deployment, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IAdminWindowsUpdatesDeploymentsCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IAdminWindowsUpdatesDeploymentsCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IAdminWindowsUpdatesDeploymentsCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IAdminWindowsUpdatesDeploymentsCollectionRequest OrderBy(string value);
    }
}
