// <auto-generated/>
using Microsoft.Graph.Beta.DeviceManagement.DeviceCompliancePolicies.Count;
using Microsoft.Graph.Beta.DeviceManagement.DeviceCompliancePolicies.GetDevicesScheduledToRetire;
using Microsoft.Graph.Beta.DeviceManagement.DeviceCompliancePolicies.GetNoncompliantDevicesToRetire;
using Microsoft.Graph.Beta.DeviceManagement.DeviceCompliancePolicies.HasPayloadLinks;
using Microsoft.Graph.Beta.DeviceManagement.DeviceCompliancePolicies.Item;
using Microsoft.Graph.Beta.DeviceManagement.DeviceCompliancePolicies.RefreshDeviceComplianceReportSummarization;
using Microsoft.Graph.Beta.DeviceManagement.DeviceCompliancePolicies.SetScheduledRetireState;
using Microsoft.Graph.Beta.DeviceManagement.DeviceCompliancePolicies.ValidateComplianceScript;
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
namespace Microsoft.Graph.Beta.DeviceManagement.DeviceCompliancePolicies {
    /// <summary>
    /// Provides operations to manage the deviceCompliancePolicies property of the microsoft.graph.deviceManagement entity.
    /// </summary>
    public class DeviceCompliancePoliciesRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to count the resources in the collection.</summary>
        public CountRequestBuilder Count { get =>
            new CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getDevicesScheduledToRetire method.</summary>
        public GetDevicesScheduledToRetireRequestBuilder GetDevicesScheduledToRetire { get =>
            new GetDevicesScheduledToRetireRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getNoncompliantDevicesToRetire method.</summary>
        public GetNoncompliantDevicesToRetireRequestBuilder GetNoncompliantDevicesToRetire { get =>
            new GetNoncompliantDevicesToRetireRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the hasPayloadLinks method.</summary>
        public HasPayloadLinksRequestBuilder HasPayloadLinks { get =>
            new HasPayloadLinksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the refreshDeviceComplianceReportSummarization method.</summary>
        public RefreshDeviceComplianceReportSummarizationRequestBuilder RefreshDeviceComplianceReportSummarization { get =>
            new RefreshDeviceComplianceReportSummarizationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the setScheduledRetireState method.</summary>
        public SetScheduledRetireStateRequestBuilder SetScheduledRetireState { get =>
            new SetScheduledRetireStateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the validateComplianceScript method.</summary>
        public ValidateComplianceScriptRequestBuilder ValidateComplianceScript { get =>
            new ValidateComplianceScriptRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceCompliancePolicies property of the microsoft.graph.deviceManagement entity.</summary>
        /// <param name="position">The unique identifier of deviceCompliancePolicy</param>
        public DeviceCompliancePolicyItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("deviceCompliancePolicy%2Did", position);
            return new DeviceCompliancePolicyItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new DeviceCompliancePoliciesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DeviceCompliancePoliciesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/deviceCompliancePolicies{?%24top,%24skip,%24search,%24filter,%24count,%24orderby,%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new DeviceCompliancePoliciesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DeviceCompliancePoliciesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/deviceCompliancePolicies{?%24top,%24skip,%24search,%24filter,%24count,%24orderby,%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// The device compliance policies.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<DeviceCompliancePolicyCollectionResponse?> GetAsync(Action<DeviceCompliancePoliciesRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<DeviceCompliancePolicyCollectionResponse> GetAsync(Action<DeviceCompliancePoliciesRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<DeviceCompliancePolicyCollectionResponse>(requestInfo, DeviceCompliancePolicyCollectionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create new navigation property to deviceCompliancePolicies for deviceManagement
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<DeviceCompliancePolicy?> PostAsync(DeviceCompliancePolicy body, Action<DeviceCompliancePoliciesRequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<DeviceCompliancePolicy> PostAsync(DeviceCompliancePolicy body, Action<DeviceCompliancePoliciesRequestBuilderPostRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<DeviceCompliancePolicy>(requestInfo, DeviceCompliancePolicy.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// The device compliance policies.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<DeviceCompliancePoliciesRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<DeviceCompliancePoliciesRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new DeviceCompliancePoliciesRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            requestInfo.Headers.TryAdd("Accept", "application/json;q=1");
            return requestInfo;
        }
        /// <summary>
        /// Create new navigation property to deviceCompliancePolicies for deviceManagement
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(DeviceCompliancePolicy body, Action<DeviceCompliancePoliciesRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(DeviceCompliancePolicy body, Action<DeviceCompliancePoliciesRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new DeviceCompliancePoliciesRequestBuilderPostRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            requestInfo.Headers.TryAdd("Accept", "application/json;q=1");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public DeviceCompliancePoliciesRequestBuilder WithUrl(string rawUrl) {
            return new DeviceCompliancePoliciesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// The device compliance policies.
        /// </summary>
        public class DeviceCompliancePoliciesRequestBuilderGetQueryParameters {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
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
            /// <summary>Filter items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("%24filter")]
            public string Filter { get; set; }
#endif
            /// <summary>Order items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24orderby")]
            public string[]? Orderby { get; set; }
#nullable restore
#else
            [QueryParameter("%24orderby")]
            public string[] Orderby { get; set; }
#endif
            /// <summary>Search items by search phrases</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("%24search")]
            public string Search { get; set; }
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
            /// <summary>Skip the first n items</summary>
            [QueryParameter("%24skip")]
            public int? Skip { get; set; }
            /// <summary>Show only the first n items</summary>
            [QueryParameter("%24top")]
            public int? Top { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class DeviceCompliancePoliciesRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public DeviceCompliancePoliciesRequestBuilderGetQueryParameters QueryParameters { get; set; } = new DeviceCompliancePoliciesRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new deviceCompliancePoliciesRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public DeviceCompliancePoliciesRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class DeviceCompliancePoliciesRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new deviceCompliancePoliciesRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public DeviceCompliancePoliciesRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
