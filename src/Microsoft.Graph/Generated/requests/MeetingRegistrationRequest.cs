// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type MeetingRegistrationRequest.
    /// </summary>
    public partial class MeetingRegistrationRequest : BaseRequest, IMeetingRegistrationRequest
    {
        /// <summary>
        /// Constructs a new MeetingRegistrationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public MeetingRegistrationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified MeetingRegistration using POST.
        /// </summary>
        /// <param name="meetingRegistrationToCreate">The MeetingRegistration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MeetingRegistration.</returns>
        public async System.Threading.Tasks.Task<MeetingRegistration> CreateAsync(MeetingRegistration meetingRegistrationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<MeetingRegistration>(meetingRegistrationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified MeetingRegistration using POST and returns a <see cref="GraphResponse{MeetingRegistration}"/> object.
        /// </summary>
        /// <param name="meetingRegistrationToCreate">The MeetingRegistration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MeetingRegistration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MeetingRegistration>> CreateResponseAsync(MeetingRegistration meetingRegistrationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<MeetingRegistration>(meetingRegistrationToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified MeetingRegistration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<MeetingRegistration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified MeetingRegistration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified MeetingRegistration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MeetingRegistration.</returns>
        public async System.Threading.Tasks.Task<MeetingRegistration> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<MeetingRegistration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified MeetingRegistration and returns a <see cref="GraphResponse{MeetingRegistration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MeetingRegistration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MeetingRegistration>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<MeetingRegistration>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified MeetingRegistration using PATCH.
        /// </summary>
        /// <param name="meetingRegistrationToUpdate">The MeetingRegistration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MeetingRegistration.</returns>
        public async System.Threading.Tasks.Task<MeetingRegistration> UpdateAsync(MeetingRegistration meetingRegistrationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<MeetingRegistration>(meetingRegistrationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified MeetingRegistration using PATCH and returns a <see cref="GraphResponse{MeetingRegistration}"/> object.
        /// </summary>
        /// <param name="meetingRegistrationToUpdate">The MeetingRegistration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MeetingRegistration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MeetingRegistration>> UpdateResponseAsync(MeetingRegistration meetingRegistrationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<MeetingRegistration>(meetingRegistrationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified MeetingRegistration using PUT.
        /// </summary>
        /// <param name="meetingRegistrationToUpdate">The MeetingRegistration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<MeetingRegistration> PutAsync(MeetingRegistration meetingRegistrationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<MeetingRegistration>(meetingRegistrationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified MeetingRegistration using PUT and returns a <see cref="GraphResponse{MeetingRegistration}"/> object.
        /// </summary>
        /// <param name="meetingRegistrationToUpdate">The MeetingRegistration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{MeetingRegistration}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MeetingRegistration>> PutResponseAsync(MeetingRegistration meetingRegistrationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<MeetingRegistration>(meetingRegistrationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMeetingRegistrationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMeetingRegistrationRequest Expand(Expression<Func<MeetingRegistration, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IMeetingRegistrationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IMeetingRegistrationRequest Select(Expression<Func<MeetingRegistration, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="meetingRegistrationToInitialize">The <see cref="MeetingRegistration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(MeetingRegistration meetingRegistrationToInitialize)
        {

            if (meetingRegistrationToInitialize != null)
            {
                if (meetingRegistrationToInitialize.CustomQuestions != null && meetingRegistrationToInitialize.CustomQuestions.CurrentPage != null)
                {
                    meetingRegistrationToInitialize.CustomQuestions.InitializeNextPageRequest(this.Client, meetingRegistrationToInitialize.CustomQuestionsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    meetingRegistrationToInitialize.CustomQuestions.AdditionalData = meetingRegistrationToInitialize.AdditionalData;
                }
                if (meetingRegistrationToInitialize.Registrants != null && meetingRegistrationToInitialize.Registrants.CurrentPage != null)
                {
                    meetingRegistrationToInitialize.Registrants.InitializeNextPageRequest(this.Client, meetingRegistrationToInitialize.RegistrantsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    meetingRegistrationToInitialize.Registrants.AdditionalData = meetingRegistrationToInitialize.AdditionalData;
                }

            }


        }
    }
}
