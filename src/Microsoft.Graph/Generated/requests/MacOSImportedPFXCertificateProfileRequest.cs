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
    /// The type MacOSImportedPFXCertificateProfileRequest.
    /// </summary>
    public partial class MacOSImportedPFXCertificateProfileRequest : BaseRequest, IMacOSImportedPFXCertificateProfileRequest
    {
        /// <summary>
        /// Constructs a new MacOSImportedPFXCertificateProfileRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public MacOSImportedPFXCertificateProfileRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified MacOSImportedPFXCertificateProfile using POST.
        /// </summary>
        /// <param name="macOSImportedPFXCertificateProfileToCreate">The MacOSImportedPFXCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MacOSImportedPFXCertificateProfile.</returns>
        public async System.Threading.Tasks.Task<MacOSImportedPFXCertificateProfile> CreateAsync(MacOSImportedPFXCertificateProfile macOSImportedPFXCertificateProfileToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Post;
            var newEntity = await this.SendAsync<MacOSImportedPFXCertificateProfile>(macOSImportedPFXCertificateProfileToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified MacOSImportedPFXCertificateProfile using POST and returns a <see cref="GraphResponse{MacOSImportedPFXCertificateProfile}"/> object.
        /// </summary>
        /// <param name="macOSImportedPFXCertificateProfileToCreate">The MacOSImportedPFXCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOSImportedPFXCertificateProfile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MacOSImportedPFXCertificateProfile>> CreateResponseAsync(MacOSImportedPFXCertificateProfile macOSImportedPFXCertificateProfileToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Post;
            return this.SendAsyncWithGraphResponse<MacOSImportedPFXCertificateProfile>(macOSImportedPFXCertificateProfileToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified MacOSImportedPFXCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Delete;
            await this.SendAsync<MacOSImportedPFXCertificateProfile>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified MacOSImportedPFXCertificateProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Delete;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified MacOSImportedPFXCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MacOSImportedPFXCertificateProfile.</returns>
        public async System.Threading.Tasks.Task<MacOSImportedPFXCertificateProfile> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Get;
            var retrievedEntity = await this.SendAsync<MacOSImportedPFXCertificateProfile>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified MacOSImportedPFXCertificateProfile and returns a <see cref="GraphResponse{MacOSImportedPFXCertificateProfile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOSImportedPFXCertificateProfile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MacOSImportedPFXCertificateProfile>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = Constants.HttpMethods.Get;
            return this.SendAsyncWithGraphResponse<MacOSImportedPFXCertificateProfile>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified MacOSImportedPFXCertificateProfile using PATCH.
        /// </summary>
        /// <param name="macOSImportedPFXCertificateProfileToUpdate">The MacOSImportedPFXCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MacOSImportedPFXCertificateProfile.</returns>
        public async System.Threading.Tasks.Task<MacOSImportedPFXCertificateProfile> UpdateAsync(MacOSImportedPFXCertificateProfile macOSImportedPFXCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Patch;
            var updatedEntity = await this.SendAsync<MacOSImportedPFXCertificateProfile>(macOSImportedPFXCertificateProfileToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified MacOSImportedPFXCertificateProfile using PATCH and returns a <see cref="GraphResponse{MacOSImportedPFXCertificateProfile}"/> object.
        /// </summary>
        /// <param name="macOSImportedPFXCertificateProfileToUpdate">The MacOSImportedPFXCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MacOSImportedPFXCertificateProfile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MacOSImportedPFXCertificateProfile>> UpdateResponseAsync(MacOSImportedPFXCertificateProfile macOSImportedPFXCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = Constants.HttpMethods.Patch;
            return this.SendAsyncWithGraphResponse<MacOSImportedPFXCertificateProfile>(macOSImportedPFXCertificateProfileToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMacOSImportedPFXCertificateProfileRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMacOSImportedPFXCertificateProfileRequest Expand(Expression<Func<MacOSImportedPFXCertificateProfile, object>> expandExpression)
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
        public IMacOSImportedPFXCertificateProfileRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IMacOSImportedPFXCertificateProfileRequest Select(Expression<Func<MacOSImportedPFXCertificateProfile, object>> selectExpression)
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
        /// <param name="macOSImportedPFXCertificateProfileToInitialize">The <see cref="MacOSImportedPFXCertificateProfile"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(MacOSImportedPFXCertificateProfile macOSImportedPFXCertificateProfileToInitialize)
        {

            if (macOSImportedPFXCertificateProfileToInitialize != null && macOSImportedPFXCertificateProfileToInitialize.AdditionalData != null)
            {

                if (macOSImportedPFXCertificateProfileToInitialize.ManagedDeviceCertificateStates != null && macOSImportedPFXCertificateProfileToInitialize.ManagedDeviceCertificateStates.CurrentPage != null)
                {
                    macOSImportedPFXCertificateProfileToInitialize.ManagedDeviceCertificateStates.AdditionalData = macOSImportedPFXCertificateProfileToInitialize.AdditionalData;

                    object nextPageLink;
                    macOSImportedPFXCertificateProfileToInitialize.AdditionalData.TryGetValue("managedDeviceCertificateStates@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        macOSImportedPFXCertificateProfileToInitialize.ManagedDeviceCertificateStates.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
