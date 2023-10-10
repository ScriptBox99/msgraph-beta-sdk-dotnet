// <auto-generated/>
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models.Security;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Users.Item.Security.InformationProtection.SensitivityLabels.MicrosoftGraphSecurityExtractContentLabel {
    /// <summary>
    /// Provides operations to call the extractContentLabel method.
    /// </summary>
    public class MicrosoftGraphSecurityExtractContentLabelRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new MicrosoftGraphSecurityExtractContentLabelRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MicrosoftGraphSecurityExtractContentLabelRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/security/informationProtection/sensitivityLabels/microsoft.graph.security.extractContentLabel", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new MicrosoftGraphSecurityExtractContentLabelRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MicrosoftGraphSecurityExtractContentLabelRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/security/informationProtection/sensitivityLabels/microsoft.graph.security.extractContentLabel", rawUrl) {
        }
        /// <summary>
        /// Use the metadata that exists on an already-labeled piece of information to resolve the metadata to a specific sensitivity label. The contentInfo input is resolved to informationProtectionContentLabel. This API is available in the following national cloud deployments.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/security-sensitivitylabel-extractcontentlabel?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ContentLabel?> PostAsync(ExtractContentLabelPostRequestBody body, Action<MicrosoftGraphSecurityExtractContentLabelRequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ContentLabel> PostAsync(ExtractContentLabelPostRequestBody body, Action<MicrosoftGraphSecurityExtractContentLabelRequestBuilderPostRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ContentLabel>(requestInfo, ContentLabel.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Use the metadata that exists on an already-labeled piece of information to resolve the metadata to a specific sensitivity label. The contentInfo input is resolved to informationProtectionContentLabel. This API is available in the following national cloud deployments.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(ExtractContentLabelPostRequestBody body, Action<MicrosoftGraphSecurityExtractContentLabelRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(ExtractContentLabelPostRequestBody body, Action<MicrosoftGraphSecurityExtractContentLabelRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new MicrosoftGraphSecurityExtractContentLabelRequestBuilderPostRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public MicrosoftGraphSecurityExtractContentLabelRequestBuilder WithUrl(string rawUrl) {
            return new MicrosoftGraphSecurityExtractContentLabelRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class MicrosoftGraphSecurityExtractContentLabelRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new microsoftGraphSecurityExtractContentLabelRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public MicrosoftGraphSecurityExtractContentLabelRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
