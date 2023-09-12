// <auto-generated/>
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Users.Item.Outlook.MasterCategories;
using Microsoft.Graph.Beta.Users.Item.Outlook.SupportedLanguages;
using Microsoft.Graph.Beta.Users.Item.Outlook.SupportedTimeZones;
using Microsoft.Graph.Beta.Users.Item.Outlook.SupportedTimeZonesWithTimeZoneStandard;
using Microsoft.Graph.Beta.Users.Item.Outlook.TaskFolders;
using Microsoft.Graph.Beta.Users.Item.Outlook.TaskGroups;
using Microsoft.Graph.Beta.Users.Item.Outlook.Tasks;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Users.Item.Outlook {
    /// <summary>
    /// Provides operations to manage the outlook property of the microsoft.graph.user entity.
    /// </summary>
    public class OutlookRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the masterCategories property of the microsoft.graph.outlookUser entity.</summary>
        public MasterCategoriesRequestBuilder MasterCategories { get =>
            new MasterCategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the supportedLanguages method.</summary>
        public SupportedLanguagesRequestBuilder SupportedLanguages { get =>
            new SupportedLanguagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the supportedTimeZones method.</summary>
        public SupportedTimeZonesRequestBuilder SupportedTimeZones { get =>
            new SupportedTimeZonesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the taskFolders property of the microsoft.graph.outlookUser entity.</summary>
        public TaskFoldersRequestBuilder TaskFolders { get =>
            new TaskFoldersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the taskGroups property of the microsoft.graph.outlookUser entity.</summary>
        public TaskGroupsRequestBuilder TaskGroups { get =>
            new TaskGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the tasks property of the microsoft.graph.outlookUser entity.</summary>
        public TasksRequestBuilder Tasks { get =>
            new TasksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new OutlookRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OutlookRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/outlook{?%24select}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new OutlookRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OutlookRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/outlook{?%24select}", rawUrl) {
        }
        /// <summary>
        /// Selective Outlook services available to the user. Read-only. Nullable.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<OutlookUser?> GetAsync(Action<OutlookRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<OutlookUser> GetAsync(Action<OutlookRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<OutlookUser>(requestInfo, OutlookUser.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Provides operations to call the supportedTimeZones method.
        /// </summary>
        /// <param name="timeZoneStandard">Usage: TimeZoneStandard=&apos;{TimeZoneStandard}&apos;</param>
        public SupportedTimeZonesWithTimeZoneStandardRequestBuilder SupportedTimeZonesWithTimeZoneStandard(string timeZoneStandard) {
            if(string.IsNullOrEmpty(timeZoneStandard)) throw new ArgumentNullException(nameof(timeZoneStandard));
            return new SupportedTimeZonesWithTimeZoneStandardRequestBuilder(PathParameters, RequestAdapter, timeZoneStandard);
        }
        /// <summary>
        /// Selective Outlook services available to the user. Read-only. Nullable.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<OutlookRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<OutlookRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new OutlookRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public OutlookRequestBuilder WithUrl(string rawUrl) {
            return new OutlookRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Selective Outlook services available to the user. Read-only. Nullable.
        /// </summary>
        public class OutlookRequestBuilderGetQueryParameters {
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
        public class OutlookRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public OutlookRequestBuilderGetQueryParameters QueryParameters { get; set; } = new OutlookRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new outlookRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public OutlookRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
