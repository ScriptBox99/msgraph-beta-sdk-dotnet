// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type RiskyUserRequest.
    /// </summary>
    public partial class RiskyUserRequest : Microsoft.Graph.BaseRequest, IRiskyUserRequest
    {
        /// <summary>
        /// Constructs a new RiskyUserRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public RiskyUserRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified RiskyUser using POST.
        /// </summary>
        /// <param name="riskyUserToCreate">The RiskyUser to create.</param>
        /// <returns>The created RiskyUser.</returns>
        public System.Threading.Tasks.Task<RiskyUser> CreateAsync(RiskyUser riskyUserToCreate)
        {
            return this.CreateAsync(riskyUserToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified RiskyUser using POST.
        /// </summary>
        /// <param name="riskyUserToCreate">The RiskyUser to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created RiskyUser.</returns>
        public async System.Threading.Tasks.Task<RiskyUser> CreateAsync(RiskyUser riskyUserToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<RiskyUser>(riskyUserToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified RiskyUser.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified RiskyUser.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<RiskyUser>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified RiskyUser.
        /// </summary>
        /// <returns>The RiskyUser.</returns>
        public System.Threading.Tasks.Task<RiskyUser> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified RiskyUser.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The RiskyUser.</returns>
        public async System.Threading.Tasks.Task<RiskyUser> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<RiskyUser>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified RiskyUser using PATCH.
        /// </summary>
        /// <param name="riskyUserToUpdate">The RiskyUser to update.</param>
        /// <returns>The updated RiskyUser.</returns>
        public System.Threading.Tasks.Task<RiskyUser> UpdateAsync(RiskyUser riskyUserToUpdate)
        {
            return this.UpdateAsync(riskyUserToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified RiskyUser using PATCH.
        /// </summary>
        /// <param name="riskyUserToUpdate">The RiskyUser to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated RiskyUser.</returns>
        public async System.Threading.Tasks.Task<RiskyUser> UpdateAsync(RiskyUser riskyUserToUpdate, CancellationToken cancellationToken)
        {
			if (riskyUserToUpdate.AdditionalData != null)
			{
				if (riskyUserToUpdate.AdditionalData.ContainsKey(Microsoft.Graph.Constants.HttpPropertyNames.ResponseHeaders) ||
					riskyUserToUpdate.AdditionalData.ContainsKey(Microsoft.Graph.Constants.HttpPropertyNames.StatusCode))
				{
					throw new Microsoft.Graph.ClientException(
						new Microsoft.Graph.Error
						{
							Code = Microsoft.Graph.GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(Microsoft.Graph.GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, riskyUserToUpdate.GetType().Name)
						});
				}
			}
            if (riskyUserToUpdate.AdditionalData != null)
            {
                if (riskyUserToUpdate.AdditionalData.ContainsKey(Microsoft.Graph.Constants.HttpPropertyNames.ResponseHeaders) ||
                    riskyUserToUpdate.AdditionalData.ContainsKey(Microsoft.Graph.Constants.HttpPropertyNames.StatusCode))
                {
                    throw new Microsoft.Graph.ClientException(
                        new Microsoft.Graph.Error
                        {
                            Code = Microsoft.Graph.GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(Microsoft.Graph.GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, riskyUserToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<RiskyUser>(riskyUserToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IRiskyUserRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IRiskyUserRequest Expand(Expression<Func<RiskyUser, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IRiskyUserRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IRiskyUserRequest Select(Expression<Func<RiskyUser, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="riskyUserToInitialize">The <see cref="RiskyUser"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(RiskyUser riskyUserToInitialize)
        {

        }
    }
}
