using Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Stages.Item.Decisions.Item.Instance.AcceptRecommendations;
using Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Stages.Item.Decisions.Item.Instance.ApplyDecisions;
using Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Stages.Item.Decisions.Item.Instance.BatchRecordDecisions;
using Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Stages.Item.Decisions.Item.Instance.ContactedReviewers;
using Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Stages.Item.Decisions.Item.Instance.Decisions;
using Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Stages.Item.Decisions.Item.Instance.Definition;
using Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Stages.Item.Decisions.Item.Instance.ResetDecisions;
using Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Stages.Item.Decisions.Item.Instance.SendReminder;
using Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Stages.Item.Decisions.Item.Instance.Stop;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Stages.Item.Decisions.Item.Instance {
    /// <summary>
    /// Provides operations to manage the instance property of the microsoft.graph.accessReviewInstanceDecisionItem entity.
    /// </summary>
    public class InstanceRequestBuilder {
        /// <summary>Provides operations to call the acceptRecommendations method.</summary>
        public AcceptRecommendationsRequestBuilder AcceptRecommendations { get =>
            new AcceptRecommendationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the applyDecisions method.</summary>
        public ApplyDecisionsRequestBuilder ApplyDecisions { get =>
            new ApplyDecisionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the batchRecordDecisions method.</summary>
        public BatchRecordDecisionsRequestBuilder BatchRecordDecisions { get =>
            new BatchRecordDecisionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the contactedReviewers property of the microsoft.graph.accessReviewInstance entity.</summary>
        public ContactedReviewersRequestBuilder ContactedReviewers { get =>
            new ContactedReviewersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the decisions property of the microsoft.graph.accessReviewInstance entity.</summary>
        public Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Stages.Item.Decisions.Item.Instance.Decisions.DecisionsRequestBuilder Decisions { get =>
            new Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Stages.Item.Decisions.Item.Instance.Decisions.DecisionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the definition property of the microsoft.graph.accessReviewInstance entity.</summary>
        public DefinitionRequestBuilder Definition { get =>
            new DefinitionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Provides operations to call the resetDecisions method.</summary>
        public ResetDecisionsRequestBuilder ResetDecisions { get =>
            new ResetDecisionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the sendReminder method.</summary>
        public SendReminderRequestBuilder SendReminder { get =>
            new SendReminderRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the stop method.</summary>
        public StopRequestBuilder Stop { get =>
            new StopRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new InstanceRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public InstanceRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/identityGovernance/accessReviews/definitions/{accessReviewScheduleDefinition%2Did}/instances/{accessReviewInstance%2Did}/stages/{accessReviewStage%2Did}/decisions/{accessReviewInstanceDecisionItem%2Did}/instance{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new InstanceRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public InstanceRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/identityGovernance/accessReviews/definitions/{accessReviewScheduleDefinition%2Did}/instances/{accessReviewInstance%2Did}/stages/{accessReviewStage%2Did}/decisions/{accessReviewInstanceDecisionItem%2Did}/instance{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property instance for identityGovernance
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        public RequestInformation CreateDeleteRequestInformation(Action<InstanceRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new InstanceRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// There is exactly one accessReviewInstance associated with each decision. The instance is the parent of the decision item, representing the recurrence of the access review the decision is made on.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        public RequestInformation CreateGetRequestInformation(Action<InstanceRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new InstanceRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property instance in identityGovernance
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        public RequestInformation CreatePatchRequestInformation(AccessReviewInstance body, Action<InstanceRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new InstanceRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Delete navigation property instance for identityGovernance
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        public async Task DeleteAsync(Action<InstanceRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// There is exactly one accessReviewInstance associated with each decision. The instance is the parent of the decision item, representing the recurrence of the access review the decision is made on.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        public async Task<AccessReviewInstance> GetAsync(Action<InstanceRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<AccessReviewInstance>(requestInfo, AccessReviewInstance.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property instance in identityGovernance
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        public async Task<AccessReviewInstance> PatchAsync(AccessReviewInstance body, Action<InstanceRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<AccessReviewInstance>(requestInfo, AccessReviewInstance.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class InstanceRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new instanceRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public InstanceRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// There is exactly one accessReviewInstance associated with each decision. The instance is the parent of the decision item, representing the recurrence of the access review the decision is made on.
        /// </summary>
        public class InstanceRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class InstanceRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public InstanceRequestBuilderGetQueryParameters QueryParameters { get; set; } = new InstanceRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new instanceRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public InstanceRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class InstanceRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new instanceRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public InstanceRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
