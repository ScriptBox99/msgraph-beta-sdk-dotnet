using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.AlternativeRecording;
using Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.AttendanceReports;
using Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.AttendeeReport;
using Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.BroadcastRecording;
using Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.MeetingAttendanceReport;
using Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.Recording;
using Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.Recordings;
using Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.Registration;
using Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.Transcripts;
using Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item.VirtualAppointment;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Solutions.VirtualEvents.Webinars.Item.Sessions.Item {
    /// <summary>
    /// Provides operations to manage the sessions property of the microsoft.graph.virtualEvent entity.
    /// </summary>
    public class VirtualEventSessionItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the media for the solutionsRoot entity.</summary>
        public AlternativeRecordingRequestBuilder AlternativeRecording { get =>
            new AlternativeRecordingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the attendanceReports property of the microsoft.graph.onlineMeeting entity.</summary>
        public AttendanceReportsRequestBuilder AttendanceReports { get =>
            new AttendanceReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the media for the solutionsRoot entity.</summary>
        public AttendeeReportRequestBuilder AttendeeReport { get =>
            new AttendeeReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the media for the solutionsRoot entity.</summary>
        public BroadcastRecordingRequestBuilder BroadcastRecording { get =>
            new BroadcastRecordingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the meetingAttendanceReport property of the microsoft.graph.onlineMeeting entity.</summary>
        public MeetingAttendanceReportRequestBuilder MeetingAttendanceReport { get =>
            new MeetingAttendanceReportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the media for the solutionsRoot entity.</summary>
        public RecordingRequestBuilder Recording { get =>
            new RecordingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the recordings property of the microsoft.graph.onlineMeeting entity.</summary>
        public RecordingsRequestBuilder Recordings { get =>
            new RecordingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the registration property of the microsoft.graph.onlineMeeting entity.</summary>
        public RegistrationRequestBuilder Registration { get =>
            new RegistrationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the transcripts property of the microsoft.graph.onlineMeeting entity.</summary>
        public TranscriptsRequestBuilder Transcripts { get =>
            new TranscriptsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the virtualAppointment property of the microsoft.graph.onlineMeeting entity.</summary>
        public VirtualAppointmentRequestBuilder VirtualAppointment { get =>
            new VirtualAppointmentRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new VirtualEventSessionItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public VirtualEventSessionItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/solutions/virtualEvents/webinars/{virtualEventWebinar%2Did}/sessions/{virtualEventSession%2Did}{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new VirtualEventSessionItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public VirtualEventSessionItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/solutions/virtualEvents/webinars/{virtualEventWebinar%2Did}/sessions/{virtualEventSession%2Did}{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Delete navigation property sessions for solutions
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<VirtualEventSessionItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<VirtualEventSessionItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Read the properties and relationships of a virtualEventSession object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/virtualeventsession-get?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<VirtualEventSession?> GetAsync(Action<VirtualEventSessionItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<VirtualEventSession> GetAsync(Action<VirtualEventSessionItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<VirtualEventSession>(requestInfo, VirtualEventSession.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the navigation property sessions in solutions
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<VirtualEventSession?> PatchAsync(VirtualEventSession body, Action<VirtualEventSessionItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<VirtualEventSession> PatchAsync(VirtualEventSession body, Action<VirtualEventSessionItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<VirtualEventSession>(requestInfo, VirtualEventSession.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Delete navigation property sessions for solutions
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<VirtualEventSessionItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<VirtualEventSessionItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new VirtualEventSessionItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Read the properties and relationships of a virtualEventSession object.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<VirtualEventSessionItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<VirtualEventSessionItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new VirtualEventSessionItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property sessions in solutions
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(VirtualEventSession body, Action<VirtualEventSessionItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(VirtualEventSession body, Action<VirtualEventSessionItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new VirtualEventSessionItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class VirtualEventSessionItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new VirtualEventSessionItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public VirtualEventSessionItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Read the properties and relationships of a virtualEventSession object.
        /// </summary>
        public class VirtualEventSessionItemRequestBuilderGetQueryParameters {
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
        public class VirtualEventSessionItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public VirtualEventSessionItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new VirtualEventSessionItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new VirtualEventSessionItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public VirtualEventSessionItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class VirtualEventSessionItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new VirtualEventSessionItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public VirtualEventSessionItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
