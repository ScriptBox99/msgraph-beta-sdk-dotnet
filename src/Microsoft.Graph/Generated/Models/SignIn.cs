using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class SignIn : Entity, IParsable {
        /// <summary>The application name displayed in the Azure Portal. Supports $filter (eq and startsWith operators only).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppDisplayName {
            get { return BackingStore?.Get<string?>("appDisplayName"); }
            set { BackingStore?.Set("appDisplayName", value); }
        }
#nullable restore
#else
        public string AppDisplayName {
            get { return BackingStore?.Get<string>("appDisplayName"); }
            set { BackingStore?.Set("appDisplayName", value); }
        }
#endif
        /// <summary>The application identifier in Azure Active Directory. Supports $filter (eq operator only).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppId {
            get { return BackingStore?.Get<string?>("appId"); }
            set { BackingStore?.Set("appId", value); }
        }
#nullable restore
#else
        public string AppId {
            get { return BackingStore?.Get<string>("appId"); }
            set { BackingStore?.Set("appId", value); }
        }
#endif
        /// <summary>A list of conditional access policies that are triggered by the corresponding sign-in activity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AppliedConditionalAccessPolicy>? AppliedConditionalAccessPolicies {
            get { return BackingStore?.Get<List<AppliedConditionalAccessPolicy>?>("appliedConditionalAccessPolicies"); }
            set { BackingStore?.Set("appliedConditionalAccessPolicies", value); }
        }
#nullable restore
#else
        public List<AppliedConditionalAccessPolicy> AppliedConditionalAccessPolicies {
            get { return BackingStore?.Get<List<AppliedConditionalAccessPolicy>>("appliedConditionalAccessPolicies"); }
            set { BackingStore?.Set("appliedConditionalAccessPolicies", value); }
        }
#endif
        /// <summary>Detailed information about the listeners, such as Azure Logic Apps and Azure Functions, that were triggered by the corresponding events in the sign-in event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AppliedAuthenticationEventListener>? AppliedEventListeners {
            get { return BackingStore?.Get<List<AppliedAuthenticationEventListener>?>("appliedEventListeners"); }
            set { BackingStore?.Set("appliedEventListeners", value); }
        }
#nullable restore
#else
        public List<AppliedAuthenticationEventListener> AppliedEventListeners {
            get { return BackingStore?.Get<List<AppliedAuthenticationEventListener>>("appliedEventListeners"); }
            set { BackingStore?.Set("appliedEventListeners", value); }
        }
#endif
        /// <summary>Provides details about the app and device used during an Azure AD authentication step.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.AuthenticationAppDeviceDetails? AuthenticationAppDeviceDetails {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AuthenticationAppDeviceDetails?>("authenticationAppDeviceDetails"); }
            set { BackingStore?.Set("authenticationAppDeviceDetails", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.AuthenticationAppDeviceDetails AuthenticationAppDeviceDetails {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AuthenticationAppDeviceDetails>("authenticationAppDeviceDetails"); }
            set { BackingStore?.Set("authenticationAppDeviceDetails", value); }
        }
#endif
        /// <summary>Provides details of the Azure AD policies applied to a user and client authentication app during an authentication step.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AuthenticationAppPolicyDetails>? AuthenticationAppPolicyEvaluationDetails {
            get { return BackingStore?.Get<List<AuthenticationAppPolicyDetails>?>("authenticationAppPolicyEvaluationDetails"); }
            set { BackingStore?.Set("authenticationAppPolicyEvaluationDetails", value); }
        }
#nullable restore
#else
        public List<AuthenticationAppPolicyDetails> AuthenticationAppPolicyEvaluationDetails {
            get { return BackingStore?.Get<List<AuthenticationAppPolicyDetails>>("authenticationAppPolicyEvaluationDetails"); }
            set { BackingStore?.Set("authenticationAppPolicyEvaluationDetails", value); }
        }
#endif
        /// <summary>Contains a collection of values that represent the conditional access authentication contexts applied to the sign-in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AuthenticationContext>? AuthenticationContextClassReferences {
            get { return BackingStore?.Get<List<AuthenticationContext>?>("authenticationContextClassReferences"); }
            set { BackingStore?.Set("authenticationContextClassReferences", value); }
        }
#nullable restore
#else
        public List<AuthenticationContext> AuthenticationContextClassReferences {
            get { return BackingStore?.Get<List<AuthenticationContext>>("authenticationContextClassReferences"); }
            set { BackingStore?.Set("authenticationContextClassReferences", value); }
        }
#endif
        /// <summary>The result of the authentication attempt and additional details on the authentication method.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AuthenticationDetail>? AuthenticationDetails {
            get { return BackingStore?.Get<List<AuthenticationDetail>?>("authenticationDetails"); }
            set { BackingStore?.Set("authenticationDetails", value); }
        }
#nullable restore
#else
        public List<AuthenticationDetail> AuthenticationDetails {
            get { return BackingStore?.Get<List<AuthenticationDetail>>("authenticationDetails"); }
            set { BackingStore?.Set("authenticationDetails", value); }
        }
#endif
        /// <summary>The authentication methods used. Possible values: SMS, Authenticator App, App Verification code, Password, FIDO, PTA, or PHS.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AuthenticationMethodsUsed {
            get { return BackingStore?.Get<List<string>?>("authenticationMethodsUsed"); }
            set { BackingStore?.Set("authenticationMethodsUsed", value); }
        }
#nullable restore
#else
        public List<string> AuthenticationMethodsUsed {
            get { return BackingStore?.Get<List<string>>("authenticationMethodsUsed"); }
            set { BackingStore?.Set("authenticationMethodsUsed", value); }
        }
#endif
        /// <summary>Additional authentication processing details, such as the agent name in case of PTA/PHS or Server/farm name in case of federated authentication.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KeyValue>? AuthenticationProcessingDetails {
            get { return BackingStore?.Get<List<KeyValue>?>("authenticationProcessingDetails"); }
            set { BackingStore?.Set("authenticationProcessingDetails", value); }
        }
#nullable restore
#else
        public List<KeyValue> AuthenticationProcessingDetails {
            get { return BackingStore?.Get<List<KeyValue>>("authenticationProcessingDetails"); }
            set { BackingStore?.Set("authenticationProcessingDetails", value); }
        }
#endif
        /// <summary>Lists the protocol type or grant type used in the authentication. The possible values are: none, oAuth2, ropc, wsFederation, saml20, deviceCode, unknownFutureValue. For authentications that use protocols other than the possible values listed, the protocol type is listed as none.</summary>
        public ProtocolType? AuthenticationProtocol {
            get { return BackingStore?.Get<ProtocolType?>("authenticationProtocol"); }
            set { BackingStore?.Set("authenticationProtocol", value); }
        }
        /// <summary>This holds the highest level of authentication needed through all the sign-in steps, for sign-in to succeed. Supports $filter (eq and startsWith operators only).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AuthenticationRequirement {
            get { return BackingStore?.Get<string?>("authenticationRequirement"); }
            set { BackingStore?.Set("authenticationRequirement", value); }
        }
#nullable restore
#else
        public string AuthenticationRequirement {
            get { return BackingStore?.Get<string>("authenticationRequirement"); }
            set { BackingStore?.Set("authenticationRequirement", value); }
        }
#endif
        /// <summary>Sources of authentication requirement, such as conditional access, per-user MFA, identity protection, and security defaults.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AuthenticationRequirementPolicy>? AuthenticationRequirementPolicies {
            get { return BackingStore?.Get<List<AuthenticationRequirementPolicy>?>("authenticationRequirementPolicies"); }
            set { BackingStore?.Set("authenticationRequirementPolicies", value); }
        }
#nullable restore
#else
        public List<AuthenticationRequirementPolicy> AuthenticationRequirementPolicies {
            get { return BackingStore?.Get<List<AuthenticationRequirementPolicy>>("authenticationRequirementPolicies"); }
            set { BackingStore?.Set("authenticationRequirementPolicies", value); }
        }
#endif
        /// <summary>The Autonomous System Number (ASN) of the network used by the actor.</summary>
        public int? AutonomousSystemNumber {
            get { return BackingStore?.Get<int?>("autonomousSystemNumber"); }
            set { BackingStore?.Set("autonomousSystemNumber", value); }
        }
        /// <summary>Contains a fully qualified Azure Resource Manager ID of an Azure resource accessed during the sign-in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureResourceId {
            get { return BackingStore?.Get<string?>("azureResourceId"); }
            set { BackingStore?.Set("azureResourceId", value); }
        }
#nullable restore
#else
        public string AzureResourceId {
            get { return BackingStore?.Get<string>("azureResourceId"); }
            set { BackingStore?.Set("azureResourceId", value); }
        }
#endif
        /// <summary>The legacy client used for sign-in activity. For example: Browser, Exchange ActiveSync, Modern clients, IMAP, MAPI, SMTP, or POP. Supports $filter (eq operator only).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientAppUsed {
            get { return BackingStore?.Get<string?>("clientAppUsed"); }
            set { BackingStore?.Set("clientAppUsed", value); }
        }
#nullable restore
#else
        public string ClientAppUsed {
            get { return BackingStore?.Get<string>("clientAppUsed"); }
            set { BackingStore?.Set("clientAppUsed", value); }
        }
#endif
        /// <summary>Describes the credential type that a user client or service principal provided to Azure AD to authenticate itself. You may wish to review clientCredentialType to track and eliminate less secure credential types or to watch for clients and service principals using anomalous credential types. The possible values are: none, clientSecret, clientAssertion, federatedIdentityCredential, managedIdentity, certificate, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.ClientCredentialType? ClientCredentialType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ClientCredentialType?>("clientCredentialType"); }
            set { BackingStore?.Set("clientCredentialType", value); }
        }
        /// <summary>The status of the conditional access policy triggered. Possible values: success, failure, notApplied, or unknownFutureValue. Supports $filter (eq operator only).</summary>
        public Microsoft.Graph.Beta.Models.ConditionalAccessStatus? ConditionalAccessStatus {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ConditionalAccessStatus?>("conditionalAccessStatus"); }
            set { BackingStore?.Set("conditionalAccessStatus", value); }
        }
        /// <summary>The identifier that&apos;s sent from the client when sign-in is initiated. This is used for troubleshooting the corresponding sign-in activity when calling for support. Supports $filter (eq operator only).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CorrelationId {
            get { return BackingStore?.Get<string?>("correlationId"); }
            set { BackingStore?.Set("correlationId", value); }
        }
#nullable restore
#else
        public string CorrelationId {
            get { return BackingStore?.Get<string>("correlationId"); }
            set { BackingStore?.Set("correlationId", value); }
        }
#endif
        /// <summary>The date and time the sign-in was initiated. The Timestamp type is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Supports $orderby and $filter (eq, le, and ge operators only).</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Describes the type of cross-tenant access used by the actor to access the resource. Possible values are: none, b2bCollaboration, b2bDirectConnect, microsoftSupport, serviceProvider, unknownFutureValue. If the sign in did not cross tenant boundaries, the value is none.</summary>
        public SignInAccessType? CrossTenantAccessType {
            get { return BackingStore?.Get<SignInAccessType?>("crossTenantAccessType"); }
            set { BackingStore?.Set("crossTenantAccessType", value); }
        }
        /// <summary>The device information from where the sign-in occurred. Includes information such as deviceId, OS, and browser. Supports $filter (eq and startsWith operators only) on browser and operatingSystem properties.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.DeviceDetail? DeviceDetail {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceDetail?>("deviceDetail"); }
            set { BackingStore?.Set("deviceDetail", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.DeviceDetail DeviceDetail {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceDetail>("deviceDetail"); }
            set { BackingStore?.Set("deviceDetail", value); }
        }
#endif
        /// <summary>Contains the identifier of an application&apos;s federated identity credential, if a federated identity credential was used to sign in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FederatedCredentialId {
            get { return BackingStore?.Get<string?>("federatedCredentialId"); }
            set { BackingStore?.Set("federatedCredentialId", value); }
        }
#nullable restore
#else
        public string FederatedCredentialId {
            get { return BackingStore?.Get<string>("federatedCredentialId"); }
            set { BackingStore?.Set("federatedCredentialId", value); }
        }
#endif
        /// <summary>During a failed sign in, a user may click a button in the Azure portal to mark the failed event for tenant admins. If a user clicked the button to flag the failed sign in, this value is true.</summary>
        public bool? FlaggedForReview {
            get { return BackingStore?.Get<bool?>("flaggedForReview"); }
            set { BackingStore?.Set("flaggedForReview", value); }
        }
        /// <summary>The tenant identifier of the user initiating the sign in. Not applicable in Managed Identity or service principal sign ins.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HomeTenantId {
            get { return BackingStore?.Get<string?>("homeTenantId"); }
            set { BackingStore?.Set("homeTenantId", value); }
        }
#nullable restore
#else
        public string HomeTenantId {
            get { return BackingStore?.Get<string>("homeTenantId"); }
            set { BackingStore?.Set("homeTenantId", value); }
        }
#endif
        /// <summary>For user sign ins, the identifier of the tenant that the user is a member of. Only populated in cases where the home tenant has provided affirmative consent to Azure AD to show the tenant content.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HomeTenantName {
            get { return BackingStore?.Get<string?>("homeTenantName"); }
            set { BackingStore?.Set("homeTenantName", value); }
        }
#nullable restore
#else
        public string HomeTenantName {
            get { return BackingStore?.Get<string>("homeTenantName"); }
            set { BackingStore?.Set("homeTenantName", value); }
        }
#endif
        /// <summary>Indicates the token types that were presented to Azure AD to authenticate the actor in the sign in. The possible values are: none, primaryRefreshToken, saml11, saml20, unknownFutureValue, remoteDesktopToken.  NOTE Azure AD may have also used token types not listed in this Enum type to authenticate the actor. Do not infer the lack of a token if it is not one of the types listed. Also, please note that you must use the Prefer: include-unknown-enum-members request header to get the following value(s) in this evolvable enum: remoteDesktopToken.</summary>
        public Microsoft.Graph.Beta.Models.IncomingTokenType? IncomingTokenType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IncomingTokenType?>("incomingTokenType"); }
            set { BackingStore?.Set("incomingTokenType", value); }
        }
        /// <summary>The IP address of the client from where the sign-in occurred. Supports $filter (eq and startsWith operators only).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IpAddress {
            get { return BackingStore?.Get<string?>("ipAddress"); }
            set { BackingStore?.Set("ipAddress", value); }
        }
#nullable restore
#else
        public string IpAddress {
            get { return BackingStore?.Get<string>("ipAddress"); }
            set { BackingStore?.Set("ipAddress", value); }
        }
#endif
        /// <summary>The IP address a user used to reach a resource provider, used to determine Conditional Access compliance for some policies. For example, when a user interacts with Exchange Online, the IP address Exchange receives from the user may be recorded here. This value is often null.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IpAddressFromResourceProvider {
            get { return BackingStore?.Get<string?>("ipAddressFromResourceProvider"); }
            set { BackingStore?.Set("ipAddressFromResourceProvider", value); }
        }
#nullable restore
#else
        public string IpAddressFromResourceProvider {
            get { return BackingStore?.Get<string>("ipAddressFromResourceProvider"); }
            set { BackingStore?.Set("ipAddressFromResourceProvider", value); }
        }
#endif
        /// <summary>Indicates whether a user sign in is interactive. In interactive sign in, the user provides an authentication factor to Azure AD. These factors include passwords, responses to MFA challenges, biometric factors, or QR codes that a user provides to Azure AD or an associated app. In non-interactive sign in, the user doesn&apos;t provide an authentication factor. Instead, the client app uses a token or code to authenticate or access a resource on behalf of a user. Non-interactive sign ins are commonly used for a client to sign in on a user&apos;s behalf in a process transparent to the user.</summary>
        public bool? IsInteractive {
            get { return BackingStore?.Get<bool?>("isInteractive"); }
            set { BackingStore?.Set("isInteractive", value); }
        }
        /// <summary>Shows whether the sign in event was subject to an Azure AD tenant restriction policy.</summary>
        public bool? IsTenantRestricted {
            get { return BackingStore?.Get<bool?>("isTenantRestricted"); }
            set { BackingStore?.Set("isTenantRestricted", value); }
        }
        /// <summary>The city, state, and 2 letter country code from where the sign-in occurred. Supports $filter (eq and startsWith operators only) on city, state, and countryOrRegion properties.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SignInLocation? Location {
            get { return BackingStore?.Get<SignInLocation?>("location"); }
            set { BackingStore?.Set("location", value); }
        }
#nullable restore
#else
        public SignInLocation Location {
            get { return BackingStore?.Get<SignInLocation>("location"); }
            set { BackingStore?.Set("location", value); }
        }
#endif
        /// <summary>Contains information about the managed identity used for the sign in, including its type and associated Azure Resource Manager (ARM) resource ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ManagedIdentity? ManagedServiceIdentity {
            get { return BackingStore?.Get<ManagedIdentity?>("managedServiceIdentity"); }
            set { BackingStore?.Set("managedServiceIdentity", value); }
        }
#nullable restore
#else
        public ManagedIdentity ManagedServiceIdentity {
            get { return BackingStore?.Get<ManagedIdentity>("managedServiceIdentity"); }
            set { BackingStore?.Set("managedServiceIdentity", value); }
        }
#endif
        /// <summary>The mfaDetail property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.MfaDetail? MfaDetail {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MfaDetail?>("mfaDetail"); }
            set { BackingStore?.Set("mfaDetail", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.MfaDetail MfaDetail {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MfaDetail>("mfaDetail"); }
            set { BackingStore?.Set("mfaDetail", value); }
        }
#endif
        /// <summary>The network location details including the type of network used and its names.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<NetworkLocationDetail>? NetworkLocationDetails {
            get { return BackingStore?.Get<List<NetworkLocationDetail>?>("networkLocationDetails"); }
            set { BackingStore?.Set("networkLocationDetails", value); }
        }
#nullable restore
#else
        public List<NetworkLocationDetail> NetworkLocationDetails {
            get { return BackingStore?.Get<List<NetworkLocationDetail>>("networkLocationDetails"); }
            set { BackingStore?.Set("networkLocationDetails", value); }
        }
#endif
        /// <summary>The request identifier of the first request in the authentication sequence. Supports $filter (eq operator only).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OriginalRequestId {
            get { return BackingStore?.Get<string?>("originalRequestId"); }
            set { BackingStore?.Set("originalRequestId", value); }
        }
#nullable restore
#else
        public string OriginalRequestId {
            get { return BackingStore?.Get<string>("originalRequestId"); }
            set { BackingStore?.Set("originalRequestId", value); }
        }
#endif
        /// <summary>Contains information about the Azure AD Private Link policy that is associated with the sign in event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.PrivateLinkDetails? PrivateLinkDetails {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PrivateLinkDetails?>("privateLinkDetails"); }
            set { BackingStore?.Set("privateLinkDetails", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.PrivateLinkDetails PrivateLinkDetails {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PrivateLinkDetails>("privateLinkDetails"); }
            set { BackingStore?.Set("privateLinkDetails", value); }
        }
#endif
        /// <summary>The request processing time in milliseconds in AD STS.</summary>
        public int? ProcessingTimeInMilliseconds {
            get { return BackingStore?.Get<int?>("processingTimeInMilliseconds"); }
            set { BackingStore?.Set("processingTimeInMilliseconds", value); }
        }
        /// <summary>The name of the resource that the user signed in to. Supports $filter (eq operator only).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceDisplayName {
            get { return BackingStore?.Get<string?>("resourceDisplayName"); }
            set { BackingStore?.Set("resourceDisplayName", value); }
        }
#nullable restore
#else
        public string ResourceDisplayName {
            get { return BackingStore?.Get<string>("resourceDisplayName"); }
            set { BackingStore?.Set("resourceDisplayName", value); }
        }
#endif
        /// <summary>The identifier of the resource that the user signed in to. Supports $filter (eq operator only).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceId {
            get { return BackingStore?.Get<string?>("resourceId"); }
            set { BackingStore?.Set("resourceId", value); }
        }
#nullable restore
#else
        public string ResourceId {
            get { return BackingStore?.Get<string>("resourceId"); }
            set { BackingStore?.Set("resourceId", value); }
        }
#endif
        /// <summary>The identifier of the service principal representing the target resource in the sign-in event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceServicePrincipalId {
            get { return BackingStore?.Get<string?>("resourceServicePrincipalId"); }
            set { BackingStore?.Set("resourceServicePrincipalId", value); }
        }
#nullable restore
#else
        public string ResourceServicePrincipalId {
            get { return BackingStore?.Get<string>("resourceServicePrincipalId"); }
            set { BackingStore?.Set("resourceServicePrincipalId", value); }
        }
#endif
        /// <summary>The tenant identifier of the resource referenced in the sign in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceTenantId {
            get { return BackingStore?.Get<string?>("resourceTenantId"); }
            set { BackingStore?.Set("resourceTenantId", value); }
        }
#nullable restore
#else
        public string ResourceTenantId {
            get { return BackingStore?.Get<string>("resourceTenantId"); }
            set { BackingStore?.Set("resourceTenantId", value); }
        }
#endif
        /// <summary>The reason behind a specific state of a risky user, sign-in, or a risk event. Possible values: none, adminGeneratedTemporaryPassword, userPerformedSecuredPasswordChange, userPerformedSecuredPasswordReset, adminConfirmedSigninSafe, aiConfirmedSigninSafe, userPassedMFADrivenByRiskBasedPolicy, adminDismissedAllRiskForUser, adminConfirmedSigninCompromised, or unknownFutureValue. The value none means that no action has been performed on the user or sign-in so far. Supports $filter (eq operator only). Note: Details for this property are only available for Azure AD Premium P2 customers. All other customers are returned hidden.</summary>
        public Microsoft.Graph.Beta.Models.RiskDetail? RiskDetail {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.RiskDetail?>("riskDetail"); }
            set { BackingStore?.Set("riskDetail", value); }
        }
        /// <summary>The list of risk event types associated with the sign-in. Possible values: unlikelyTravel, anonymizedIPAddress, maliciousIPAddress, unfamiliarFeatures, malwareInfectedIPAddress, suspiciousIPAddress, leakedCredentials, investigationsThreatIntelligence,  generic, or unknownFutureValue. Supports $filter (eq and startsWith operators only).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RiskEventTypesV2 {
            get { return BackingStore?.Get<List<string>?>("riskEventTypes_v2"); }
            set { BackingStore?.Set("riskEventTypes_v2", value); }
        }
#nullable restore
#else
        public List<string> RiskEventTypesV2 {
            get { return BackingStore?.Get<List<string>>("riskEventTypes_v2"); }
            set { BackingStore?.Set("riskEventTypes_v2", value); }
        }
#endif
        /// <summary>The aggregated risk level. Possible values: none, low, medium, high, hidden, or unknownFutureValue. The value hidden means the user or sign-in was not enabled for Azure AD Identity Protection. Supports $filter (eq operator only). Note: Details for this property are only available for Azure AD Premium P2 customers. All other customers are returned hidden.</summary>
        public RiskLevel? RiskLevelAggregated {
            get { return BackingStore?.Get<RiskLevel?>("riskLevelAggregated"); }
            set { BackingStore?.Set("riskLevelAggregated", value); }
        }
        /// <summary>The risk level during sign-in. Possible values: none, low, medium, high, hidden, or unknownFutureValue. The value hidden means the user or sign-in was not enabled for Azure AD Identity Protection. Supports $filter (eq operator only). Note: Details for this property are only available for Azure AD Premium P2 customers. All other customers are returned hidden.</summary>
        public RiskLevel? RiskLevelDuringSignIn {
            get { return BackingStore?.Get<RiskLevel?>("riskLevelDuringSignIn"); }
            set { BackingStore?.Set("riskLevelDuringSignIn", value); }
        }
        /// <summary>The risk state of a risky user, sign-in, or a risk event. Possible values: none, confirmedSafe, remediated, dismissed, atRisk, confirmedCompromised, or unknownFutureValue. Supports $filter (eq operator only).</summary>
        public Microsoft.Graph.Beta.Models.RiskState? RiskState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.RiskState?>("riskState"); }
            set { BackingStore?.Set("riskState", value); }
        }
        /// <summary>The unique identifier of the key credential used by the service principal to authenticate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServicePrincipalCredentialKeyId {
            get { return BackingStore?.Get<string?>("servicePrincipalCredentialKeyId"); }
            set { BackingStore?.Set("servicePrincipalCredentialKeyId", value); }
        }
#nullable restore
#else
        public string ServicePrincipalCredentialKeyId {
            get { return BackingStore?.Get<string>("servicePrincipalCredentialKeyId"); }
            set { BackingStore?.Set("servicePrincipalCredentialKeyId", value); }
        }
#endif
        /// <summary>The certificate thumbprint of the certificate used by the service principal to authenticate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServicePrincipalCredentialThumbprint {
            get { return BackingStore?.Get<string?>("servicePrincipalCredentialThumbprint"); }
            set { BackingStore?.Set("servicePrincipalCredentialThumbprint", value); }
        }
#nullable restore
#else
        public string ServicePrincipalCredentialThumbprint {
            get { return BackingStore?.Get<string>("servicePrincipalCredentialThumbprint"); }
            set { BackingStore?.Set("servicePrincipalCredentialThumbprint", value); }
        }
#endif
        /// <summary>The application identifier used for sign-in. This field is populated when you are signing in using an application. Supports $filter (eq and startsWith operators only).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServicePrincipalId {
            get { return BackingStore?.Get<string?>("servicePrincipalId"); }
            set { BackingStore?.Set("servicePrincipalId", value); }
        }
#nullable restore
#else
        public string ServicePrincipalId {
            get { return BackingStore?.Get<string>("servicePrincipalId"); }
            set { BackingStore?.Set("servicePrincipalId", value); }
        }
#endif
        /// <summary>The application name used for sign-in. This field is populated when you are signing in using an application. Supports $filter (eq and startsWith operators only).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServicePrincipalName {
            get { return BackingStore?.Get<string?>("servicePrincipalName"); }
            set { BackingStore?.Set("servicePrincipalName", value); }
        }
#nullable restore
#else
        public string ServicePrincipalName {
            get { return BackingStore?.Get<string>("servicePrincipalName"); }
            set { BackingStore?.Set("servicePrincipalName", value); }
        }
#endif
        /// <summary>Any conditional access session management policies that were applied during the sign-in event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SessionLifetimePolicy>? SessionLifetimePolicies {
            get { return BackingStore?.Get<List<SessionLifetimePolicy>?>("sessionLifetimePolicies"); }
            set { BackingStore?.Set("sessionLifetimePolicies", value); }
        }
#nullable restore
#else
        public List<SessionLifetimePolicy> SessionLifetimePolicies {
            get { return BackingStore?.Get<List<SessionLifetimePolicy>>("sessionLifetimePolicies"); }
            set { BackingStore?.Set("sessionLifetimePolicies", value); }
        }
#endif
        /// <summary>Indicates the category of sign in that the event represents. For user sign ins, the category can be interactiveUser or nonInteractiveUser and corresponds to the value for the isInteractive property on the signin resource. For managed identity sign ins, the category is managedIdentity. For service principal sign ins, the category is servicePrincipal. Possible values are: interactiveUser, nonInteractiveUser, servicePrincipal, managedIdentity, unknownFutureValue. Supports $filter (eq, ne).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SignInEventTypes {
            get { return BackingStore?.Get<List<string>?>("signInEventTypes"); }
            set { BackingStore?.Set("signInEventTypes", value); }
        }
#nullable restore
#else
        public List<string> SignInEventTypes {
            get { return BackingStore?.Get<List<string>>("signInEventTypes"); }
            set { BackingStore?.Set("signInEventTypes", value); }
        }
#endif
        /// <summary>The identification that the user provided to sign in. It may be the userPrincipalName but it&apos;s also populated when a user signs in using other identifiers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SignInIdentifier {
            get { return BackingStore?.Get<string?>("signInIdentifier"); }
            set { BackingStore?.Set("signInIdentifier", value); }
        }
#nullable restore
#else
        public string SignInIdentifier {
            get { return BackingStore?.Get<string>("signInIdentifier"); }
            set { BackingStore?.Set("signInIdentifier", value); }
        }
#endif
        /// <summary>The type of sign in identifier. Possible values are: userPrincipalName, phoneNumber, proxyAddress, qrCode, onPremisesUserPrincipalName, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.SignInIdentifierType? SignInIdentifierType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SignInIdentifierType?>("signInIdentifierType"); }
            set { BackingStore?.Set("signInIdentifierType", value); }
        }
        /// <summary>The sign-in status. Includes the error code and description of the error (in case of a sign-in failure). Supports $filter (eq operator only) on errorCode property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SignInStatus? Status {
            get { return BackingStore?.Get<SignInStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#nullable restore
#else
        public SignInStatus Status {
            get { return BackingStore?.Get<SignInStatus>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#endif
        /// <summary>The name of the identity provider. For example, sts.microsoft.com. Supports $filter (eq operator only).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TokenIssuerName {
            get { return BackingStore?.Get<string?>("tokenIssuerName"); }
            set { BackingStore?.Set("tokenIssuerName", value); }
        }
#nullable restore
#else
        public string TokenIssuerName {
            get { return BackingStore?.Get<string>("tokenIssuerName"); }
            set { BackingStore?.Set("tokenIssuerName", value); }
        }
#endif
        /// <summary>The type of identity provider. The possible values are: AzureAD, ADFederationServices, UnknownFutureValue, AzureADBackupAuth, ADFederationServicesMFAAdapter, NPSExtension. Note that you must use the Prefer: include-unknown-enum-members request header to get the following values in this evolvable enum: AzureADBackupAuth , ADFederationServicesMFAAdapter , NPSExtension.</summary>
        public Microsoft.Graph.Beta.Models.TokenIssuerType? TokenIssuerType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TokenIssuerType?>("tokenIssuerType"); }
            set { BackingStore?.Set("tokenIssuerType", value); }
        }
        /// <summary>A unique base64 encoded request identifier used to track tokens issued by Azure AD as they are redeemed at resource providers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UniqueTokenIdentifier {
            get { return BackingStore?.Get<string?>("uniqueTokenIdentifier"); }
            set { BackingStore?.Set("uniqueTokenIdentifier", value); }
        }
#nullable restore
#else
        public string UniqueTokenIdentifier {
            get { return BackingStore?.Get<string>("uniqueTokenIdentifier"); }
            set { BackingStore?.Set("uniqueTokenIdentifier", value); }
        }
#endif
        /// <summary>The user agent information related to sign-in. Supports $filter (eq and startsWith operators only).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserAgent {
            get { return BackingStore?.Get<string?>("userAgent"); }
            set { BackingStore?.Set("userAgent", value); }
        }
#nullable restore
#else
        public string UserAgent {
            get { return BackingStore?.Get<string>("userAgent"); }
            set { BackingStore?.Set("userAgent", value); }
        }
#endif
        /// <summary>The display name of the user. Supports $filter (eq and startsWith operators only).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserDisplayName {
            get { return BackingStore?.Get<string?>("userDisplayName"); }
            set { BackingStore?.Set("userDisplayName", value); }
        }
#nullable restore
#else
        public string UserDisplayName {
            get { return BackingStore?.Get<string>("userDisplayName"); }
            set { BackingStore?.Set("userDisplayName", value); }
        }
#endif
        /// <summary>The identifier of the user. Supports $filter (eq operator only).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId {
            get { return BackingStore?.Get<string?>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#nullable restore
#else
        public string UserId {
            get { return BackingStore?.Get<string>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#endif
        /// <summary>The UPN of the user. Supports $filter (eq and startsWith operators only).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName {
            get { return BackingStore?.Get<string?>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#nullable restore
#else
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#endif
        /// <summary>Identifies whether the user is a member or guest in the tenant. Possible values are: member, guest, unknownFutureValue.</summary>
        public SignInUserType? UserType {
            get { return BackingStore?.Get<SignInUserType?>("userType"); }
            set { BackingStore?.Set("userType", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SignIn CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SignIn();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appDisplayName", n => { AppDisplayName = n.GetStringValue(); } },
                {"appId", n => { AppId = n.GetStringValue(); } },
                {"appliedConditionalAccessPolicies", n => { AppliedConditionalAccessPolicies = n.GetCollectionOfObjectValues<AppliedConditionalAccessPolicy>(AppliedConditionalAccessPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"appliedEventListeners", n => { AppliedEventListeners = n.GetCollectionOfObjectValues<AppliedAuthenticationEventListener>(AppliedAuthenticationEventListener.CreateFromDiscriminatorValue)?.ToList(); } },
                {"authenticationAppDeviceDetails", n => { AuthenticationAppDeviceDetails = n.GetObjectValue<Microsoft.Graph.Beta.Models.AuthenticationAppDeviceDetails>(Microsoft.Graph.Beta.Models.AuthenticationAppDeviceDetails.CreateFromDiscriminatorValue); } },
                {"authenticationAppPolicyEvaluationDetails", n => { AuthenticationAppPolicyEvaluationDetails = n.GetCollectionOfObjectValues<AuthenticationAppPolicyDetails>(AuthenticationAppPolicyDetails.CreateFromDiscriminatorValue)?.ToList(); } },
                {"authenticationContextClassReferences", n => { AuthenticationContextClassReferences = n.GetCollectionOfObjectValues<AuthenticationContext>(AuthenticationContext.CreateFromDiscriminatorValue)?.ToList(); } },
                {"authenticationDetails", n => { AuthenticationDetails = n.GetCollectionOfObjectValues<AuthenticationDetail>(AuthenticationDetail.CreateFromDiscriminatorValue)?.ToList(); } },
                {"authenticationMethodsUsed", n => { AuthenticationMethodsUsed = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"authenticationProcessingDetails", n => { AuthenticationProcessingDetails = n.GetCollectionOfObjectValues<KeyValue>(KeyValue.CreateFromDiscriminatorValue)?.ToList(); } },
                {"authenticationProtocol", n => { AuthenticationProtocol = n.GetEnumValue<ProtocolType>(); } },
                {"authenticationRequirement", n => { AuthenticationRequirement = n.GetStringValue(); } },
                {"authenticationRequirementPolicies", n => { AuthenticationRequirementPolicies = n.GetCollectionOfObjectValues<AuthenticationRequirementPolicy>(AuthenticationRequirementPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"autonomousSystemNumber", n => { AutonomousSystemNumber = n.GetIntValue(); } },
                {"azureResourceId", n => { AzureResourceId = n.GetStringValue(); } },
                {"clientAppUsed", n => { ClientAppUsed = n.GetStringValue(); } },
                {"clientCredentialType", n => { ClientCredentialType = n.GetEnumValue<ClientCredentialType>(); } },
                {"conditionalAccessStatus", n => { ConditionalAccessStatus = n.GetEnumValue<ConditionalAccessStatus>(); } },
                {"correlationId", n => { CorrelationId = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"crossTenantAccessType", n => { CrossTenantAccessType = n.GetEnumValue<SignInAccessType>(); } },
                {"deviceDetail", n => { DeviceDetail = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceDetail>(Microsoft.Graph.Beta.Models.DeviceDetail.CreateFromDiscriminatorValue); } },
                {"federatedCredentialId", n => { FederatedCredentialId = n.GetStringValue(); } },
                {"flaggedForReview", n => { FlaggedForReview = n.GetBoolValue(); } },
                {"homeTenantId", n => { HomeTenantId = n.GetStringValue(); } },
                {"homeTenantName", n => { HomeTenantName = n.GetStringValue(); } },
                {"incomingTokenType", n => { IncomingTokenType = n.GetEnumValue<IncomingTokenType>(); } },
                {"ipAddress", n => { IpAddress = n.GetStringValue(); } },
                {"ipAddressFromResourceProvider", n => { IpAddressFromResourceProvider = n.GetStringValue(); } },
                {"isInteractive", n => { IsInteractive = n.GetBoolValue(); } },
                {"isTenantRestricted", n => { IsTenantRestricted = n.GetBoolValue(); } },
                {"location", n => { Location = n.GetObjectValue<SignInLocation>(SignInLocation.CreateFromDiscriminatorValue); } },
                {"managedServiceIdentity", n => { ManagedServiceIdentity = n.GetObjectValue<ManagedIdentity>(ManagedIdentity.CreateFromDiscriminatorValue); } },
                {"mfaDetail", n => { MfaDetail = n.GetObjectValue<Microsoft.Graph.Beta.Models.MfaDetail>(Microsoft.Graph.Beta.Models.MfaDetail.CreateFromDiscriminatorValue); } },
                {"networkLocationDetails", n => { NetworkLocationDetails = n.GetCollectionOfObjectValues<NetworkLocationDetail>(NetworkLocationDetail.CreateFromDiscriminatorValue)?.ToList(); } },
                {"originalRequestId", n => { OriginalRequestId = n.GetStringValue(); } },
                {"privateLinkDetails", n => { PrivateLinkDetails = n.GetObjectValue<Microsoft.Graph.Beta.Models.PrivateLinkDetails>(Microsoft.Graph.Beta.Models.PrivateLinkDetails.CreateFromDiscriminatorValue); } },
                {"processingTimeInMilliseconds", n => { ProcessingTimeInMilliseconds = n.GetIntValue(); } },
                {"resourceDisplayName", n => { ResourceDisplayName = n.GetStringValue(); } },
                {"resourceId", n => { ResourceId = n.GetStringValue(); } },
                {"resourceServicePrincipalId", n => { ResourceServicePrincipalId = n.GetStringValue(); } },
                {"resourceTenantId", n => { ResourceTenantId = n.GetStringValue(); } },
                {"riskDetail", n => { RiskDetail = n.GetEnumValue<RiskDetail>(); } },
                {"riskEventTypes_v2", n => { RiskEventTypesV2 = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"riskLevelAggregated", n => { RiskLevelAggregated = n.GetEnumValue<RiskLevel>(); } },
                {"riskLevelDuringSignIn", n => { RiskLevelDuringSignIn = n.GetEnumValue<RiskLevel>(); } },
                {"riskState", n => { RiskState = n.GetEnumValue<RiskState>(); } },
                {"servicePrincipalCredentialKeyId", n => { ServicePrincipalCredentialKeyId = n.GetStringValue(); } },
                {"servicePrincipalCredentialThumbprint", n => { ServicePrincipalCredentialThumbprint = n.GetStringValue(); } },
                {"servicePrincipalId", n => { ServicePrincipalId = n.GetStringValue(); } },
                {"servicePrincipalName", n => { ServicePrincipalName = n.GetStringValue(); } },
                {"sessionLifetimePolicies", n => { SessionLifetimePolicies = n.GetCollectionOfObjectValues<SessionLifetimePolicy>(SessionLifetimePolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"signInEventTypes", n => { SignInEventTypes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"signInIdentifier", n => { SignInIdentifier = n.GetStringValue(); } },
                {"signInIdentifierType", n => { SignInIdentifierType = n.GetEnumValue<SignInIdentifierType>(); } },
                {"status", n => { Status = n.GetObjectValue<SignInStatus>(SignInStatus.CreateFromDiscriminatorValue); } },
                {"tokenIssuerName", n => { TokenIssuerName = n.GetStringValue(); } },
                {"tokenIssuerType", n => { TokenIssuerType = n.GetEnumValue<TokenIssuerType>(); } },
                {"uniqueTokenIdentifier", n => { UniqueTokenIdentifier = n.GetStringValue(); } },
                {"userAgent", n => { UserAgent = n.GetStringValue(); } },
                {"userDisplayName", n => { UserDisplayName = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
                {"userType", n => { UserType = n.GetEnumValue<SignInUserType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appDisplayName", AppDisplayName);
            writer.WriteStringValue("appId", AppId);
            writer.WriteCollectionOfObjectValues<AppliedConditionalAccessPolicy>("appliedConditionalAccessPolicies", AppliedConditionalAccessPolicies);
            writer.WriteCollectionOfObjectValues<AppliedAuthenticationEventListener>("appliedEventListeners", AppliedEventListeners);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AuthenticationAppDeviceDetails>("authenticationAppDeviceDetails", AuthenticationAppDeviceDetails);
            writer.WriteCollectionOfObjectValues<AuthenticationAppPolicyDetails>("authenticationAppPolicyEvaluationDetails", AuthenticationAppPolicyEvaluationDetails);
            writer.WriteCollectionOfObjectValues<AuthenticationContext>("authenticationContextClassReferences", AuthenticationContextClassReferences);
            writer.WriteCollectionOfObjectValues<AuthenticationDetail>("authenticationDetails", AuthenticationDetails);
            writer.WriteCollectionOfPrimitiveValues<string>("authenticationMethodsUsed", AuthenticationMethodsUsed);
            writer.WriteCollectionOfObjectValues<KeyValue>("authenticationProcessingDetails", AuthenticationProcessingDetails);
            writer.WriteEnumValue<ProtocolType>("authenticationProtocol", AuthenticationProtocol);
            writer.WriteStringValue("authenticationRequirement", AuthenticationRequirement);
            writer.WriteCollectionOfObjectValues<AuthenticationRequirementPolicy>("authenticationRequirementPolicies", AuthenticationRequirementPolicies);
            writer.WriteIntValue("autonomousSystemNumber", AutonomousSystemNumber);
            writer.WriteStringValue("azureResourceId", AzureResourceId);
            writer.WriteStringValue("clientAppUsed", ClientAppUsed);
            writer.WriteEnumValue<ClientCredentialType>("clientCredentialType", ClientCredentialType);
            writer.WriteEnumValue<ConditionalAccessStatus>("conditionalAccessStatus", ConditionalAccessStatus);
            writer.WriteStringValue("correlationId", CorrelationId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteEnumValue<SignInAccessType>("crossTenantAccessType", CrossTenantAccessType);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceDetail>("deviceDetail", DeviceDetail);
            writer.WriteStringValue("federatedCredentialId", FederatedCredentialId);
            writer.WriteBoolValue("flaggedForReview", FlaggedForReview);
            writer.WriteStringValue("homeTenantId", HomeTenantId);
            writer.WriteStringValue("homeTenantName", HomeTenantName);
            writer.WriteEnumValue<IncomingTokenType>("incomingTokenType", IncomingTokenType);
            writer.WriteStringValue("ipAddress", IpAddress);
            writer.WriteStringValue("ipAddressFromResourceProvider", IpAddressFromResourceProvider);
            writer.WriteBoolValue("isInteractive", IsInteractive);
            writer.WriteBoolValue("isTenantRestricted", IsTenantRestricted);
            writer.WriteObjectValue<SignInLocation>("location", Location);
            writer.WriteObjectValue<ManagedIdentity>("managedServiceIdentity", ManagedServiceIdentity);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.MfaDetail>("mfaDetail", MfaDetail);
            writer.WriteCollectionOfObjectValues<NetworkLocationDetail>("networkLocationDetails", NetworkLocationDetails);
            writer.WriteStringValue("originalRequestId", OriginalRequestId);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.PrivateLinkDetails>("privateLinkDetails", PrivateLinkDetails);
            writer.WriteIntValue("processingTimeInMilliseconds", ProcessingTimeInMilliseconds);
            writer.WriteStringValue("resourceDisplayName", ResourceDisplayName);
            writer.WriteStringValue("resourceId", ResourceId);
            writer.WriteStringValue("resourceServicePrincipalId", ResourceServicePrincipalId);
            writer.WriteStringValue("resourceTenantId", ResourceTenantId);
            writer.WriteEnumValue<RiskDetail>("riskDetail", RiskDetail);
            writer.WriteCollectionOfPrimitiveValues<string>("riskEventTypes_v2", RiskEventTypesV2);
            writer.WriteEnumValue<RiskLevel>("riskLevelAggregated", RiskLevelAggregated);
            writer.WriteEnumValue<RiskLevel>("riskLevelDuringSignIn", RiskLevelDuringSignIn);
            writer.WriteEnumValue<RiskState>("riskState", RiskState);
            writer.WriteStringValue("servicePrincipalCredentialKeyId", ServicePrincipalCredentialKeyId);
            writer.WriteStringValue("servicePrincipalCredentialThumbprint", ServicePrincipalCredentialThumbprint);
            writer.WriteStringValue("servicePrincipalId", ServicePrincipalId);
            writer.WriteStringValue("servicePrincipalName", ServicePrincipalName);
            writer.WriteCollectionOfObjectValues<SessionLifetimePolicy>("sessionLifetimePolicies", SessionLifetimePolicies);
            writer.WriteCollectionOfPrimitiveValues<string>("signInEventTypes", SignInEventTypes);
            writer.WriteStringValue("signInIdentifier", SignInIdentifier);
            writer.WriteEnumValue<SignInIdentifierType>("signInIdentifierType", SignInIdentifierType);
            writer.WriteObjectValue<SignInStatus>("status", Status);
            writer.WriteStringValue("tokenIssuerName", TokenIssuerName);
            writer.WriteEnumValue<TokenIssuerType>("tokenIssuerType", TokenIssuerType);
            writer.WriteStringValue("uniqueTokenIdentifier", UniqueTokenIdentifier);
            writer.WriteStringValue("userAgent", UserAgent);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteEnumValue<SignInUserType>("userType", UserType);
        }
    }
}
