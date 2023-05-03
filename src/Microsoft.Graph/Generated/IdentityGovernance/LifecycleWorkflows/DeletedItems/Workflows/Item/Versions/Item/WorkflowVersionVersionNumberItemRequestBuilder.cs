using Microsoft.Graph.Beta.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.Versions.Item.CreatedBy;
using Microsoft.Graph.Beta.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.Versions.Item.LastModifiedBy;
using Microsoft.Graph.Beta.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.Versions.Item.Tasks;
using Microsoft.Graph.Beta.Models.IdentityGovernance;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.IdentityGovernance.LifecycleWorkflows.DeletedItems.Workflows.Item.Versions.Item {
    /// <summary>
    /// Provides operations to manage the versions property of the microsoft.graph.identityGovernance.workflow entity.
    /// </summary>
    public class WorkflowVersionVersionNumberItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the createdBy property of the microsoft.graph.identityGovernance.workflowBase entity.</summary>
        public CreatedByRequestBuilder CreatedBy { get =>
            new CreatedByRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the lastModifiedBy property of the microsoft.graph.identityGovernance.workflowBase entity.</summary>
        public LastModifiedByRequestBuilder LastModifiedBy { get =>
            new LastModifiedByRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the tasks property of the microsoft.graph.identityGovernance.workflowBase entity.</summary>
        public TasksRequestBuilder Tasks { get =>
            new TasksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new WorkflowVersionVersionNumberItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WorkflowVersionVersionNumberItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/lifecycleWorkflows/deletedItems/workflows/{workflow%2Did}/versions/{workflowVersion%2DversionNumber}{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WorkflowVersionVersionNumberItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WorkflowVersionVersionNumberItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/lifecycleWorkflows/deletedItems/workflows/{workflow%2Did}/versions/{workflowVersion%2DversionNumber}{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// The workflow versions that are available.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<WorkflowVersion?> GetAsync(Action<WorkflowVersionVersionNumberItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<WorkflowVersion> GetAsync(Action<WorkflowVersionVersionNumberItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<WorkflowVersion>(requestInfo, WorkflowVersion.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// The workflow versions that are available.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<WorkflowVersionVersionNumberItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<WorkflowVersionVersionNumberItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new WorkflowVersionVersionNumberItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// The workflow versions that are available.
        /// </summary>
        public class WorkflowVersionVersionNumberItemRequestBuilderGetQueryParameters {
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
        public class WorkflowVersionVersionNumberItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public WorkflowVersionVersionNumberItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new WorkflowVersionVersionNumberItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new WorkflowVersionVersionNumberItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public WorkflowVersionVersionNumberItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
