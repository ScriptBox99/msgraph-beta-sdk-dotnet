using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Compliance.Ediscovery.Cases.Item.ReviewSets.Item.MicrosoftGraphEdiscoveryAddToReviewSet {
    /// <summary>
    /// Provides operations to call the addToReviewSet method.
    /// </summary>
    public class MicrosoftGraphEdiscoveryAddToReviewSetRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new MicrosoftGraphEdiscoveryAddToReviewSetRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MicrosoftGraphEdiscoveryAddToReviewSetRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/compliance/ediscovery/cases/{case%2Did}/reviewSets/{reviewSet%2Did}/microsoft.graph.ediscovery.addToReviewSet", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new MicrosoftGraphEdiscoveryAddToReviewSetRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MicrosoftGraphEdiscoveryAddToReviewSetRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/compliance/ediscovery/cases/{case%2Did}/reviewSets/{reviewSet%2Did}/microsoft.graph.ediscovery.addToReviewSet", rawUrl) {
        }
        /// <summary>
        /// Start the process of adding a collection from Microsoft 365 services to a review set. After the operation is created, you can get the status of the operation by retrieving the Location parameter from the response headers. The location provides a URL that will return a caseExportOperation.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/ediscovery-reviewset-addtoreviewset?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The ediscovery Apis are deprecated under /compliance and will stop returning data from February 01, 2023. Please use the new ediscovery Apis under /security. as of 2022-12/ediscoveryNamespace on 2022-12-05 and will be removed 2023-02-01")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PostAsync(AddToReviewSetPostRequestBody body, Action<MicrosoftGraphEdiscoveryAddToReviewSetRequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task PostAsync(AddToReviewSetPostRequestBody body, Action<MicrosoftGraphEdiscoveryAddToReviewSetRequestBuilderPostRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Start the process of adding a collection from Microsoft 365 services to a review set. After the operation is created, you can get the status of the operation by retrieving the Location parameter from the response headers. The location provides a URL that will return a caseExportOperation.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The ediscovery Apis are deprecated under /compliance and will stop returning data from February 01, 2023. Please use the new ediscovery Apis under /security. as of 2022-12/ediscoveryNamespace on 2022-12-05 and will be removed 2023-02-01")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(AddToReviewSetPostRequestBody body, Action<MicrosoftGraphEdiscoveryAddToReviewSetRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(AddToReviewSetPostRequestBody body, Action<MicrosoftGraphEdiscoveryAddToReviewSetRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new MicrosoftGraphEdiscoveryAddToReviewSetRequestBuilderPostRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class MicrosoftGraphEdiscoveryAddToReviewSetRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new microsoftGraphEdiscoveryAddToReviewSetRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public MicrosoftGraphEdiscoveryAddToReviewSetRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
