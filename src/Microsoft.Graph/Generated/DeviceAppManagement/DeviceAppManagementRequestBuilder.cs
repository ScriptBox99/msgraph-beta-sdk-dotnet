using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.DeviceAppManagement.AndroidManagedAppProtections;
using MicrosoftGraphSdk.DeviceAppManagement.DefaultManagedAppProtections;
using MicrosoftGraphSdk.DeviceAppManagement.DeviceAppManagementTasks;
using MicrosoftGraphSdk.DeviceAppManagement.EnterpriseCodeSigningCertificates;
using MicrosoftGraphSdk.DeviceAppManagement.IosLobAppProvisioningConfigurations;
using MicrosoftGraphSdk.DeviceAppManagement.IosManagedAppProtections;
using MicrosoftGraphSdk.DeviceAppManagement.ManagedAppPolicies;
using MicrosoftGraphSdk.DeviceAppManagement.ManagedAppRegistrations;
using MicrosoftGraphSdk.DeviceAppManagement.ManagedAppStatuses;
using MicrosoftGraphSdk.DeviceAppManagement.ManagedEBookCategories;
using MicrosoftGraphSdk.DeviceAppManagement.ManagedEBooks;
using MicrosoftGraphSdk.DeviceAppManagement.MdmWindowsInformationProtectionPolicies;
using MicrosoftGraphSdk.DeviceAppManagement.MobileAppCategories;
using MicrosoftGraphSdk.DeviceAppManagement.MobileAppConfigurations;
using MicrosoftGraphSdk.DeviceAppManagement.MobileApps;
using MicrosoftGraphSdk.DeviceAppManagement.PolicySets;
using MicrosoftGraphSdk.DeviceAppManagement.SideLoadingKeys;
using MicrosoftGraphSdk.DeviceAppManagement.SymantecCodeSigningCertificate;
using MicrosoftGraphSdk.DeviceAppManagement.SyncMicrosoftStoreForBusinessApps;
using MicrosoftGraphSdk.DeviceAppManagement.TargetedManagedAppConfigurations;
using MicrosoftGraphSdk.DeviceAppManagement.VppTokens;
using MicrosoftGraphSdk.DeviceAppManagement.WdacSupplementalPolicies;
using MicrosoftGraphSdk.DeviceAppManagement.WindowsInformationProtectionDeviceRegistrations;
using MicrosoftGraphSdk.DeviceAppManagement.WindowsInformationProtectionPolicies;
using MicrosoftGraphSdk.DeviceAppManagement.WindowsInformationProtectionWipeActions;
using MicrosoftGraphSdk.DeviceAppManagement.WindowsManagementApp;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using MicrosoftGraphSdk.Models.Microsoft.Graph.ODataErrors;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraphSdk.DeviceAppManagement {
    /// <summary>Provides operations to manage the deviceAppManagement singleton.</summary>
    public class DeviceAppManagementRequestBuilder {
        public AndroidManagedAppProtectionsRequestBuilder AndroidManagedAppProtections { get =>
            new AndroidManagedAppProtectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DefaultManagedAppProtectionsRequestBuilder DefaultManagedAppProtections { get =>
            new DefaultManagedAppProtectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public DeviceAppManagementTasksRequestBuilder DeviceAppManagementTasks { get =>
            new DeviceAppManagementTasksRequestBuilder(PathParameters, RequestAdapter);
        }
        public EnterpriseCodeSigningCertificatesRequestBuilder EnterpriseCodeSigningCertificates { get =>
            new EnterpriseCodeSigningCertificatesRequestBuilder(PathParameters, RequestAdapter);
        }
        public IosLobAppProvisioningConfigurationsRequestBuilder IosLobAppProvisioningConfigurations { get =>
            new IosLobAppProvisioningConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        public IosManagedAppProtectionsRequestBuilder IosManagedAppProtections { get =>
            new IosManagedAppProtectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ManagedAppPoliciesRequestBuilder ManagedAppPolicies { get =>
            new ManagedAppPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        public ManagedAppRegistrationsRequestBuilder ManagedAppRegistrations { get =>
            new ManagedAppRegistrationsRequestBuilder(PathParameters, RequestAdapter);
        }
        public ManagedAppStatusesRequestBuilder ManagedAppStatuses { get =>
            new ManagedAppStatusesRequestBuilder(PathParameters, RequestAdapter);
        }
        public ManagedEBookCategoriesRequestBuilder ManagedEBookCategories { get =>
            new ManagedEBookCategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        public ManagedEBooksRequestBuilder ManagedEBooks { get =>
            new ManagedEBooksRequestBuilder(PathParameters, RequestAdapter);
        }
        public MdmWindowsInformationProtectionPoliciesRequestBuilder MdmWindowsInformationProtectionPolicies { get =>
            new MdmWindowsInformationProtectionPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        public MobileAppCategoriesRequestBuilder MobileAppCategories { get =>
            new MobileAppCategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        public MobileAppConfigurationsRequestBuilder MobileAppConfigurations { get =>
            new MobileAppConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        public MobileAppsRequestBuilder MobileApps { get =>
            new MobileAppsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        public PolicySetsRequestBuilder PolicySets { get =>
            new PolicySetsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public SideLoadingKeysRequestBuilder SideLoadingKeys { get =>
            new SideLoadingKeysRequestBuilder(PathParameters, RequestAdapter);
        }
        public SymantecCodeSigningCertificateRequestBuilder SymantecCodeSigningCertificate { get =>
            new SymantecCodeSigningCertificateRequestBuilder(PathParameters, RequestAdapter);
        }
        public SyncMicrosoftStoreForBusinessAppsRequestBuilder SyncMicrosoftStoreForBusinessApps { get =>
            new SyncMicrosoftStoreForBusinessAppsRequestBuilder(PathParameters, RequestAdapter);
        }
        public TargetedManagedAppConfigurationsRequestBuilder TargetedManagedAppConfigurations { get =>
            new TargetedManagedAppConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public VppTokensRequestBuilder VppTokens { get =>
            new VppTokensRequestBuilder(PathParameters, RequestAdapter);
        }
        public WdacSupplementalPoliciesRequestBuilder WdacSupplementalPolicies { get =>
            new WdacSupplementalPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        public WindowsInformationProtectionDeviceRegistrationsRequestBuilder WindowsInformationProtectionDeviceRegistrations { get =>
            new WindowsInformationProtectionDeviceRegistrationsRequestBuilder(PathParameters, RequestAdapter);
        }
        public WindowsInformationProtectionPoliciesRequestBuilder WindowsInformationProtectionPolicies { get =>
            new WindowsInformationProtectionPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        public WindowsInformationProtectionWipeActionsRequestBuilder WindowsInformationProtectionWipeActions { get =>
            new WindowsInformationProtectionWipeActionsRequestBuilder(PathParameters, RequestAdapter);
        }
        public WindowsManagementAppRequestBuilder WindowsManagementApp { get =>
            new WindowsManagementAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new DeviceAppManagementRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DeviceAppManagementRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceAppManagement{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new DeviceAppManagementRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DeviceAppManagementRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceAppManagement{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Get deviceAppManagement
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
        /// Update deviceAppManagement
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceAppManagement body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// Get deviceAppManagement
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceAppManagement> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceAppManagement>(requestInfo, MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceAppManagement.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update deviceAppManagement
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceAppManagement body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>Get deviceAppManagement</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
