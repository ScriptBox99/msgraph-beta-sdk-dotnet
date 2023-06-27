using Microsoft.Graph.Beta.Models.Ediscovery;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.Custodians.Item.LastIndexOperation {
    /// <summary>
    /// Provides operations to manage the lastIndexOperation property of the microsoft.graph.ediscovery.dataSourceContainer entity.
    /// </summary>
    public class LastIndexOperationRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new LastIndexOperationRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LastIndexOperationRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/compliance/ediscovery/cases/{case%2Did}/custodians/{custodian%2Did}/lastIndexOperation{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new LastIndexOperationRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LastIndexOperationRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/compliance/ediscovery/cases/{case%2Did}/custodians/{custodian%2Did}/lastIndexOperation{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Get lastIndexOperation from compliance
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The ediscovery Apis are deprecated under /compliance and will stop returning data from February 01, 2023. Please use the new ediscovery Apis under /security. as of 2022-12/ediscoveryNamespace on 2022-12-05 and will be removed 2023-02-01")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<CaseIndexOperation?> GetAsync(Action<LastIndexOperationRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<CaseIndexOperation> GetAsync(Action<LastIndexOperationRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<CaseIndexOperation>(requestInfo, CaseIndexOperation.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Get lastIndexOperation from compliance
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The ediscovery Apis are deprecated under /compliance and will stop returning data from February 01, 2023. Please use the new ediscovery Apis under /security. as of 2022-12/ediscoveryNamespace on 2022-12-05 and will be removed 2023-02-01")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<LastIndexOperationRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<LastIndexOperationRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new LastIndexOperationRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get lastIndexOperation from compliance
        /// </summary>
        public class LastIndexOperationRequestBuilderGetQueryParameters {
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
        public class LastIndexOperationRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public LastIndexOperationRequestBuilderGetQueryParameters QueryParameters { get; set; } = new LastIndexOperationRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new lastIndexOperationRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public LastIndexOperationRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
