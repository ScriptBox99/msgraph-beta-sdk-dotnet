using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.DeviceManagement.DeviceConfigurations.Item.Assign;
using MicrosoftGraphSdk.DeviceManagement.DeviceConfigurations.Item.AssignedAccessMultiModeProfiles;
using MicrosoftGraphSdk.DeviceManagement.DeviceConfigurations.Item.Assignments;
using MicrosoftGraphSdk.DeviceManagement.DeviceConfigurations.Item.DeviceSettingStateSummaries;
using MicrosoftGraphSdk.DeviceManagement.DeviceConfigurations.Item.DeviceStatuses;
using MicrosoftGraphSdk.DeviceManagement.DeviceConfigurations.Item.DeviceStatusOverview;
using MicrosoftGraphSdk.DeviceManagement.DeviceConfigurations.Item.GetOmaSettingPlainTextValueWithSecretReferenceValueId;
using MicrosoftGraphSdk.DeviceManagement.DeviceConfigurations.Item.GroupAssignments;
using MicrosoftGraphSdk.DeviceManagement.DeviceConfigurations.Item.UserStatuses;
using MicrosoftGraphSdk.DeviceManagement.DeviceConfigurations.Item.UserStatusOverview;
using MicrosoftGraphSdk.DeviceManagement.DeviceConfigurations.Item.WindowsPrivacyAccessControls;
using MicrosoftGraphSdk.DeviceManagement.DeviceConfigurations.Item.WindowsUpdateForBusinessConfiguration;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraphSdk.DeviceManagement.DeviceConfigurations.Item {
    /// <summary>Builds and executes requests for operations under \deviceManagement\deviceConfigurations\{deviceConfiguration-id}</summary>
    public class DeviceConfigurationItemRequestBuilder {
        public AssignRequestBuilder Assign { get =>
            new AssignRequestBuilder(PathParameters, RequestAdapter);
        }
        public AssignedAccessMultiModeProfilesRequestBuilder AssignedAccessMultiModeProfiles { get =>
            new AssignedAccessMultiModeProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        public AssignmentsRequestBuilder Assignments { get =>
            new AssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceSettingStateSummariesRequestBuilder DeviceSettingStateSummaries { get =>
            new DeviceSettingStateSummariesRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceStatusesRequestBuilder DeviceStatuses { get =>
            new DeviceStatusesRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceStatusOverviewRequestBuilder DeviceStatusOverview { get =>
            new DeviceStatusOverviewRequestBuilder(PathParameters, RequestAdapter);
        }
        public GroupAssignmentsRequestBuilder GroupAssignments { get =>
            new GroupAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public UserStatusesRequestBuilder UserStatuses { get =>
            new UserStatusesRequestBuilder(PathParameters, RequestAdapter);
        }
        public UserStatusOverviewRequestBuilder UserStatusOverview { get =>
            new UserStatusOverviewRequestBuilder(PathParameters, RequestAdapter);
        }
        public WindowsPrivacyAccessControlsRequestBuilder WindowsPrivacyAccessControls { get =>
            new WindowsPrivacyAccessControlsRequestBuilder(PathParameters, RequestAdapter);
        }
        public WindowsUpdateForBusinessConfigurationRequestBuilder WindowsUpdateForBusinessConfiguration { get =>
            new WindowsUpdateForBusinessConfigurationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new DeviceConfigurationItemRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DeviceConfigurationItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/deviceConfigurations/{deviceConfiguration_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new DeviceConfigurationItemRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DeviceConfigurationItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/deviceConfigurations/{deviceConfiguration_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// The device configurations.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// The device configurations.
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (q != null) {
                var qParams = new GetQueryParameters();
                q.Invoke(qParams);
                qParams.AddQueryParameters(requestInfo.QueryParameters);
            }
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// The device configurations.
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceConfiguration body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            h?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(o?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// The device configurations.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>
        /// The device configurations.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceConfiguration> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            return await RequestAdapter.SendAsync<MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceConfiguration>(requestInfo, MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceConfiguration.CreateFromDiscriminatorValue, responseHandler, default, cancellationToken);
        }
        /// <summary>
        /// Builds and executes requests for operations under \deviceManagement\deviceConfigurations\{deviceConfiguration-id}\microsoft.graph.getOmaSettingPlainTextValue(secretReferenceValueId='{secretReferenceValueId}')
        /// <param name="secretReferenceValueId">Usage: secretReferenceValueId={secretReferenceValueId}</param>
        /// </summary>
        public GetOmaSettingPlainTextValueWithSecretReferenceValueIdRequestBuilder GetOmaSettingPlainTextValueWithSecretReferenceValueId(string secretReferenceValueId) {
            if(string.IsNullOrEmpty(secretReferenceValueId)) throw new ArgumentNullException(nameof(secretReferenceValueId));
            return new GetOmaSettingPlainTextValueWithSecretReferenceValueIdRequestBuilder(PathParameters, RequestAdapter, secretReferenceValueId);
        }
        /// <summary>
        /// The device configurations.
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceConfiguration body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, default, cancellationToken);
        }
        /// <summary>The device configurations.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
