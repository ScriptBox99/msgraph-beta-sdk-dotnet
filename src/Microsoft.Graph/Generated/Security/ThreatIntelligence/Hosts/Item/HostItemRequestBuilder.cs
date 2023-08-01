using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models.Security;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.Hosts.Item.ChildHostPairs;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.Hosts.Item.Components;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.Hosts.Item.Cookies;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.Hosts.Item.HostPairs;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.Hosts.Item.ParentHostPairs;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.Hosts.Item.PassiveDns;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.Hosts.Item.PassiveDnsReverse;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.Hosts.Item.Reputation;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.Hosts.Item.SslCertificates;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.Hosts.Item.Subdomains;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.Hosts.Item.Trackers;
using Microsoft.Graph.Beta.Security.ThreatIntelligence.Hosts.Item.Whois;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Security.ThreatIntelligence.Hosts.Item {
    /// <summary>
    /// Provides operations to manage the hosts property of the microsoft.graph.security.threatIntelligence entity.
    /// </summary>
    public class HostItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the childHostPairs property of the microsoft.graph.security.host entity.</summary>
        public ChildHostPairsRequestBuilder ChildHostPairs { get =>
            new ChildHostPairsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the components property of the microsoft.graph.security.host entity.</summary>
        public ComponentsRequestBuilder Components { get =>
            new ComponentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the cookies property of the microsoft.graph.security.host entity.</summary>
        public CookiesRequestBuilder Cookies { get =>
            new CookiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the hostPairs property of the microsoft.graph.security.host entity.</summary>
        public HostPairsRequestBuilder HostPairs { get =>
            new HostPairsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the parentHostPairs property of the microsoft.graph.security.host entity.</summary>
        public ParentHostPairsRequestBuilder ParentHostPairs { get =>
            new ParentHostPairsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the passiveDns property of the microsoft.graph.security.host entity.</summary>
        public PassiveDnsRequestBuilder PassiveDns { get =>
            new PassiveDnsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the passiveDnsReverse property of the microsoft.graph.security.host entity.</summary>
        public PassiveDnsReverseRequestBuilder PassiveDnsReverse { get =>
            new PassiveDnsReverseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the reputation property of the microsoft.graph.security.host entity.</summary>
        public ReputationRequestBuilder Reputation { get =>
            new ReputationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the sslCertificates property of the microsoft.graph.security.host entity.</summary>
        public SslCertificatesRequestBuilder SslCertificates { get =>
            new SslCertificatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the subdomains property of the microsoft.graph.security.host entity.</summary>
        public SubdomainsRequestBuilder Subdomains { get =>
            new SubdomainsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the trackers property of the microsoft.graph.security.host entity.</summary>
        public TrackersRequestBuilder Trackers { get =>
            new TrackersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the whois property of the microsoft.graph.security.host entity.</summary>
        public WhoisRequestBuilder Whois { get =>
            new WhoisRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new HostItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public HostItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/security/threatIntelligence/hosts/{host%2Did}{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new HostItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public HostItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/security/threatIntelligence/hosts/{host%2Did}{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Delete navigation property hosts for security
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<HostItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<HostItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Read the properties and relationships of a host object. The host resource is the abstract base type that returns an implementation. A host can be of one of the following types:
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/security-host-get?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.Security.Host?> GetAsync(Action<HostItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.Security.Host> GetAsync(Action<HostItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.Security.Host>(requestInfo, Microsoft.Graph.Beta.Models.Security.Host.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property hosts in security
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.Security.Host?> PatchAsync(Microsoft.Graph.Beta.Models.Security.Host body, Action<HostItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.Security.Host> PatchAsync(Microsoft.Graph.Beta.Models.Security.Host body, Action<HostItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.Security.Host>(requestInfo, Microsoft.Graph.Beta.Models.Security.Host.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Delete navigation property hosts for security
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<HostItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<HostItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new HostItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Read the properties and relationships of a host object. The host resource is the abstract base type that returns an implementation. A host can be of one of the following types:
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<HostItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<HostItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new HostItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property hosts in security
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.Security.Host body, Action<HostItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.Security.Host body, Action<HostItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
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
                var requestConfig = new HostItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class HostItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new HostItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public HostItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Read the properties and relationships of a host object. The host resource is the abstract base type that returns an implementation. A host can be of one of the following types:
        /// </summary>
        public class HostItemRequestBuilderGetQueryParameters {
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
        public class HostItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public HostItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new HostItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new HostItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public HostItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class HostItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new HostItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public HostItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
