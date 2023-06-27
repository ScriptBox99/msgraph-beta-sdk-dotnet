using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models.Security;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.ArticleIndicators;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.Articles;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.HostComponents;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.HostCookies;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.HostTrackers;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.Hosts;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.IntelProfiles;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.IntelligenceProfileIndicators;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.PassiveDnsRecords;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.Subdomains;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.Vulnerabilities;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Security.ThreatIntelligence {
    /// <summary>
    /// Provides operations to manage the threatIntelligence property of the microsoft.graph.security entity.
    /// </summary>
    public class ThreatIntelligenceRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the articleIndicators property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public ArticleIndicatorsRequestBuilder ArticleIndicators { get =>
            new ArticleIndicatorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the articles property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public ArticlesRequestBuilder Articles { get =>
            new ArticlesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the hostComponents property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public HostComponentsRequestBuilder HostComponents { get =>
            new HostComponentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the hostCookies property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public HostCookiesRequestBuilder HostCookies { get =>
            new HostCookiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the hosts property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public HostsRequestBuilder Hosts { get =>
            new HostsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the hostTrackers property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public HostTrackersRequestBuilder HostTrackers { get =>
            new HostTrackersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the intelligenceProfileIndicators property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public IntelligenceProfileIndicatorsRequestBuilder IntelligenceProfileIndicators { get =>
            new IntelligenceProfileIndicatorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the intelProfiles property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public IntelProfilesRequestBuilder IntelProfiles { get =>
            new IntelProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the passiveDnsRecords property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public PassiveDnsRecordsRequestBuilder PassiveDnsRecords { get =>
            new PassiveDnsRecordsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the subdomains property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public SubdomainsRequestBuilder Subdomains { get =>
            new SubdomainsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the vulnerabilities property of the microsoft.graph.security.threatIntelligence entity.</summary>
        public VulnerabilitiesRequestBuilder Vulnerabilities { get =>
            new VulnerabilitiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new ThreatIntelligenceRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ThreatIntelligenceRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/security/threatIntelligence{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ThreatIntelligenceRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ThreatIntelligenceRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/security/threatIntelligence{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Delete navigation property threatIntelligence for security
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<ThreatIntelligenceRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<ThreatIntelligenceRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Get threatIntelligence from security
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.Security.ThreatIntelligence?> GetAsync(Action<ThreatIntelligenceRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.Security.ThreatIntelligence> GetAsync(Action<ThreatIntelligenceRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.Security.ThreatIntelligence>(requestInfo, Microsoft.Graph.Beta.Models.Security.ThreatIntelligence.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property threatIntelligence in security
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.Security.ThreatIntelligence?> PatchAsync(Microsoft.Graph.Beta.Models.Security.ThreatIntelligence body, Action<ThreatIntelligenceRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.Security.ThreatIntelligence> PatchAsync(Microsoft.Graph.Beta.Models.Security.ThreatIntelligence body, Action<ThreatIntelligenceRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.Security.ThreatIntelligence>(requestInfo, Microsoft.Graph.Beta.Models.Security.ThreatIntelligence.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Delete navigation property threatIntelligence for security
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<ThreatIntelligenceRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<ThreatIntelligenceRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new ThreatIntelligenceRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get threatIntelligence from security
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<ThreatIntelligenceRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<ThreatIntelligenceRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new ThreatIntelligenceRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property threatIntelligence in security
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.Security.ThreatIntelligence body, Action<ThreatIntelligenceRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.Security.ThreatIntelligence body, Action<ThreatIntelligenceRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
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
                var requestConfig = new ThreatIntelligenceRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ThreatIntelligenceRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new threatIntelligenceRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public ThreatIntelligenceRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Get threatIntelligence from security
        /// </summary>
        public class ThreatIntelligenceRequestBuilderGetQueryParameters {
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
        public class ThreatIntelligenceRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public ThreatIntelligenceRequestBuilderGetQueryParameters QueryParameters { get; set; } = new ThreatIntelligenceRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new threatIntelligenceRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public ThreatIntelligenceRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ThreatIntelligenceRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new threatIntelligenceRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public ThreatIntelligenceRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
