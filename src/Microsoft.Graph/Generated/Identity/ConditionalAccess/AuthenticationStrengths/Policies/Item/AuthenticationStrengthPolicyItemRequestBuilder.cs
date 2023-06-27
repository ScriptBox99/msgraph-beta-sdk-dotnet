using Microsoft.Graph.Beta.Identity.ConditionalAccess.AuthenticationStrengths.Policies.Item.CombinationConfigurations;
using Microsoft.Graph.Beta.Identity.ConditionalAccess.AuthenticationStrengths.Policies.Item.UpdateAllowedCombinations;
using Microsoft.Graph.Beta.Identity.ConditionalAccess.AuthenticationStrengths.Policies.Item.Usage;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Identity.ConditionalAccess.AuthenticationStrengths.Policies.Item {
    /// <summary>
    /// Provides operations to manage the policies property of the microsoft.graph.authenticationStrengthRoot entity.
    /// </summary>
    public class AuthenticationStrengthPolicyItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the combinationConfigurations property of the microsoft.graph.authenticationStrengthPolicy entity.</summary>
        [Obsolete("The &apos;authenticationStrengths&apos; segment is deprecated. Please use &apos;authenticationStrength&apos; instead. as of 2023-02/AuthenticationStrengthsRemove on 2023-02-01 and will be removed 2023-03-31")]
        public CombinationConfigurationsRequestBuilder CombinationConfigurations { get =>
            new CombinationConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the updateAllowedCombinations method.</summary>
        [Obsolete("The &apos;authenticationStrengths&apos; segment is deprecated. Please use &apos;authenticationStrength&apos; instead. as of 2023-02/AuthenticationStrengthsRemove on 2023-02-01 and will be removed 2023-03-31")]
        public UpdateAllowedCombinationsRequestBuilder UpdateAllowedCombinations { get =>
            new UpdateAllowedCombinationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the usage method.</summary>
        [Obsolete("The &apos;authenticationStrengths&apos; segment is deprecated. Please use &apos;authenticationStrength&apos; instead. as of 2023-02/AuthenticationStrengthsRemove on 2023-02-01 and will be removed 2023-03-31")]
        public UsageRequestBuilder Usage { get =>
            new UsageRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new AuthenticationStrengthPolicyItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AuthenticationStrengthPolicyItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identity/conditionalAccess/authenticationStrengths/policies/{authenticationStrengthPolicy%2Did}{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new AuthenticationStrengthPolicyItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AuthenticationStrengthPolicyItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identity/conditionalAccess/authenticationStrengths/policies/{authenticationStrengthPolicy%2Did}{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Delete navigation property policies for identity
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The &apos;authenticationStrengths&apos; segment is deprecated. Please use &apos;authenticationStrength&apos; instead. as of 2023-02/AuthenticationStrengthsRemove on 2023-02-01 and will be removed 2023-03-31")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<AuthenticationStrengthPolicyItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<AuthenticationStrengthPolicyItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// A collection of authentication strength policies that exist for this tenant, including both built-in and custom policies.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The &apos;authenticationStrengths&apos; segment is deprecated. Please use &apos;authenticationStrength&apos; instead. as of 2023-02/AuthenticationStrengthsRemove on 2023-02-01 and will be removed 2023-03-31")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<AuthenticationStrengthPolicy?> GetAsync(Action<AuthenticationStrengthPolicyItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<AuthenticationStrengthPolicy> GetAsync(Action<AuthenticationStrengthPolicyItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<AuthenticationStrengthPolicy>(requestInfo, AuthenticationStrengthPolicy.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property policies in identity
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The &apos;authenticationStrengths&apos; segment is deprecated. Please use &apos;authenticationStrength&apos; instead. as of 2023-02/AuthenticationStrengthsRemove on 2023-02-01 and will be removed 2023-03-31")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<AuthenticationStrengthPolicy?> PatchAsync(AuthenticationStrengthPolicy body, Action<AuthenticationStrengthPolicyItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<AuthenticationStrengthPolicy> PatchAsync(AuthenticationStrengthPolicy body, Action<AuthenticationStrengthPolicyItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<AuthenticationStrengthPolicy>(requestInfo, AuthenticationStrengthPolicy.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Delete navigation property policies for identity
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The &apos;authenticationStrengths&apos; segment is deprecated. Please use &apos;authenticationStrength&apos; instead. as of 2023-02/AuthenticationStrengthsRemove on 2023-02-01 and will be removed 2023-03-31")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<AuthenticationStrengthPolicyItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<AuthenticationStrengthPolicyItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new AuthenticationStrengthPolicyItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// A collection of authentication strength policies that exist for this tenant, including both built-in and custom policies.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The &apos;authenticationStrengths&apos; segment is deprecated. Please use &apos;authenticationStrength&apos; instead. as of 2023-02/AuthenticationStrengthsRemove on 2023-02-01 and will be removed 2023-03-31")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<AuthenticationStrengthPolicyItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<AuthenticationStrengthPolicyItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new AuthenticationStrengthPolicyItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property policies in identity
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The &apos;authenticationStrengths&apos; segment is deprecated. Please use &apos;authenticationStrength&apos; instead. as of 2023-02/AuthenticationStrengthsRemove on 2023-02-01 and will be removed 2023-03-31")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(AuthenticationStrengthPolicy body, Action<AuthenticationStrengthPolicyItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(AuthenticationStrengthPolicy body, Action<AuthenticationStrengthPolicyItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new AuthenticationStrengthPolicyItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class AuthenticationStrengthPolicyItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new AuthenticationStrengthPolicyItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public AuthenticationStrengthPolicyItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// A collection of authentication strength policies that exist for this tenant, including both built-in and custom policies.
        /// </summary>
        public class AuthenticationStrengthPolicyItemRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class AuthenticationStrengthPolicyItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public AuthenticationStrengthPolicyItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new AuthenticationStrengthPolicyItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new AuthenticationStrengthPolicyItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public AuthenticationStrengthPolicyItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class AuthenticationStrengthPolicyItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new AuthenticationStrengthPolicyItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public AuthenticationStrengthPolicyItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
