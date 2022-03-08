using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using MicrosoftGraphSdk.Models.Microsoft.Graph.ODataErrors;
using MicrosoftGraphSdk.Reports.AuthenticationMethods.UserRegistrationDetails;
using MicrosoftGraphSdk.Reports.AuthenticationMethods.UsersRegisteredByFeature;
using MicrosoftGraphSdk.Reports.AuthenticationMethods.UsersRegisteredByFeatureWithIncludedUserTypesWithIncludedUserRoles;
using MicrosoftGraphSdk.Reports.AuthenticationMethods.UsersRegisteredByMethod;
using MicrosoftGraphSdk.Reports.AuthenticationMethods.UsersRegisteredByMethodWithIncludedUserTypesWithIncludedUserRoles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraphSdk.Reports.AuthenticationMethods {
    /// <summary>Provides operations to manage the authenticationMethods property of the microsoft.graph.reportRoot entity.</summary>
    public class AuthenticationMethodsRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public UserRegistrationDetailsRequestBuilder UserRegistrationDetails { get =>
            new UserRegistrationDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new AuthenticationMethodsRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public AuthenticationMethodsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/reports/authenticationMethods{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new AuthenticationMethodsRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public AuthenticationMethodsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/reports/authenticationMethods{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property authenticationMethods for reports
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
        /// Container for navigation properties for Azure AD authentication methods resources.
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
        /// Update the navigation property authenticationMethods in reports
        /// <param name="body"></param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(AuthenticationMethodsRoot body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default) {
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
        /// Delete navigation property authenticationMethods for reports
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task DeleteAsync(Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateDeleteRequestInformation(h, o);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Container for navigation properties for Azure AD authentication methods resources.
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="q">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<AuthenticationMethodsRoot> GetAsync(Action<GetQueryParameters> q = default, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(q, h, o);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<AuthenticationMethodsRoot>(requestInfo, AuthenticationMethodsRoot.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property authenticationMethods in reports
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="h">Request headers</param>
        /// <param name="o">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(AuthenticationMethodsRoot body, Action<IDictionary<string, string>> h = default, IEnumerable<IRequestOption> o = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, h, o);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Provides operations to call the usersRegisteredByFeature method.
        /// </summary>
        public UsersRegisteredByFeatureRequestBuilder UsersRegisteredByFeature() {
            return new UsersRegisteredByFeatureRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the usersRegisteredByFeature method.
        /// <param name="includedUserRoles">Usage: includedUserRoles='{includedUserRoles}'</param>
        /// <param name="includedUserTypes">Usage: includedUserTypes='{includedUserTypes}'</param>
        /// </summary>
        public UsersRegisteredByFeatureWithIncludedUserTypesWithIncludedUserRolesRequestBuilder UsersRegisteredByFeatureWithIncludedUserTypesWithIncludedUserRoles(string includedUserRoles, string includedUserTypes) {
            if(string.IsNullOrEmpty(includedUserRoles)) throw new ArgumentNullException(nameof(includedUserRoles));
            if(string.IsNullOrEmpty(includedUserTypes)) throw new ArgumentNullException(nameof(includedUserTypes));
            return new UsersRegisteredByFeatureWithIncludedUserTypesWithIncludedUserRolesRequestBuilder(PathParameters, RequestAdapter, includedUserRoles, includedUserTypes);
        }
        /// <summary>
        /// Provides operations to call the usersRegisteredByMethod method.
        /// </summary>
        public UsersRegisteredByMethodRequestBuilder UsersRegisteredByMethod() {
            return new UsersRegisteredByMethodRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the usersRegisteredByMethod method.
        /// <param name="includedUserRoles">Usage: includedUserRoles='{includedUserRoles}'</param>
        /// <param name="includedUserTypes">Usage: includedUserTypes='{includedUserTypes}'</param>
        /// </summary>
        public UsersRegisteredByMethodWithIncludedUserTypesWithIncludedUserRolesRequestBuilder UsersRegisteredByMethodWithIncludedUserTypesWithIncludedUserRoles(string includedUserRoles, string includedUserTypes) {
            if(string.IsNullOrEmpty(includedUserRoles)) throw new ArgumentNullException(nameof(includedUserRoles));
            if(string.IsNullOrEmpty(includedUserTypes)) throw new ArgumentNullException(nameof(includedUserTypes));
            return new UsersRegisteredByMethodWithIncludedUserTypesWithIncludedUserRolesRequestBuilder(PathParameters, RequestAdapter, includedUserRoles, includedUserTypes);
        }
        /// <summary>Container for navigation properties for Azure AD authentication methods resources.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
