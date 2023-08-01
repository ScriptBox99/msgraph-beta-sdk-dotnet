using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Admin.Windows.Updates.UpdatableAssets.Item.MicrosoftGraphWindowsUpdatesAddMembers {
    /// <summary>
    /// Provides operations to call the addMembers method.
    /// </summary>
    public class MicrosoftGraphWindowsUpdatesAddMembersRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new MicrosoftGraphWindowsUpdatesAddMembersRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MicrosoftGraphWindowsUpdatesAddMembersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/windows/updates/updatableAssets/{updatableAsset%2Did}/microsoft.graph.windowsUpdates.addMembers", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new MicrosoftGraphWindowsUpdatesAddMembersRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MicrosoftGraphWindowsUpdatesAddMembersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/admin/windows/updates/updatableAssets/{updatableAsset%2Did}/microsoft.graph.windowsUpdates.addMembers", rawUrl) {
        }
        /// <summary>
        /// Add members to an updatableAssetGroup. You can add azureADDevice resources as members, but may not add updatableAssetGroup resources as members. Adding an Azure AD device as a member of an updatable asset group automatically creates an azureADDevice object, if it does not already exist. You can also use the method addMembersById to add members.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/windowsupdates-updatableassetgroup-addmembers?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PostAsync(AddMembersPostRequestBody body, Action<MicrosoftGraphWindowsUpdatesAddMembersRequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task PostAsync(AddMembersPostRequestBody body, Action<MicrosoftGraphWindowsUpdatesAddMembersRequestBuilderPostRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
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
        /// Add members to an updatableAssetGroup. You can add azureADDevice resources as members, but may not add updatableAssetGroup resources as members. Adding an Azure AD device as a member of an updatable asset group automatically creates an azureADDevice object, if it does not already exist. You can also use the method addMembersById to add members.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(AddMembersPostRequestBody body, Action<MicrosoftGraphWindowsUpdatesAddMembersRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(AddMembersPostRequestBody body, Action<MicrosoftGraphWindowsUpdatesAddMembersRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new MicrosoftGraphWindowsUpdatesAddMembersRequestBuilderPostRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class MicrosoftGraphWindowsUpdatesAddMembersRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new microsoftGraphWindowsUpdatesAddMembersRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public MicrosoftGraphWindowsUpdatesAddMembersRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
