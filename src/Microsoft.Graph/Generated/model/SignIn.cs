// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Sign In.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<SignIn>))]
    public partial class SignIn : Entity
    {
    
        /// <summary>
        /// Gets or sets alternate sign in name.
        /// The alternate sign-in identity whenever you use phone number to sign-in. Supports $filter (eq and startsWith operators only).
        /// </summary>
        [JsonPropertyName("alternateSignInName")]
        public string AlternateSignInName { get; set; }
    
        /// <summary>
        /// Gets or sets app display name.
        /// The application name displayed in the Azure Portal. Supports $filter (eq and startsWith operators only).
        /// </summary>
        [JsonPropertyName("appDisplayName")]
        public string AppDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets app id.
        /// The application identifier in Azure Active Directory. Supports $filter (eq operator only).
        /// </summary>
        [JsonPropertyName("appId")]
        public string AppId { get; set; }
    
        /// <summary>
        /// Gets or sets applied conditional access policies.
        /// A list of conditional access policies that are triggered by the corresponding sign-in activity.
        /// </summary>
        [JsonPropertyName("appliedConditionalAccessPolicies")]
        public IEnumerable<AppliedConditionalAccessPolicy> AppliedConditionalAccessPolicies { get; set; }
    
        /// <summary>
        /// Gets or sets authentication details.
        /// The result of the authentication attempt and additional details on the authentication method.
        /// </summary>
        [JsonPropertyName("authenticationDetails")]
        public IEnumerable<AuthenticationDetail> AuthenticationDetails { get; set; }
    
        /// <summary>
        /// Gets or sets authentication methods used.
        /// The authentication methods used. Possible values: SMS, Authenticator App, App Verification code, Password, FIDO, PTA, or PHS.
        /// </summary>
        [JsonPropertyName("authenticationMethodsUsed")]
        public IEnumerable<string> AuthenticationMethodsUsed { get; set; }
    
        /// <summary>
        /// Gets or sets authentication processing details.
        /// Additional authentication processing details, such as the agent name in case of PTA/PHS or Server/farm name in case of federated authentication.
        /// </summary>
        [JsonPropertyName("authenticationProcessingDetails")]
        public IEnumerable<KeyValue> AuthenticationProcessingDetails { get; set; }
    
        /// <summary>
        /// Gets or sets authentication requirement.
        /// This holds the highest level of authentication needed through all the sign-in steps, for sign-in to succeed. Supports $filter (eq and startsWith operators only).
        /// </summary>
        [JsonPropertyName("authenticationRequirement")]
        public string AuthenticationRequirement { get; set; }
    
        /// <summary>
        /// Gets or sets authentication requirement policies.
        /// </summary>
        [JsonPropertyName("authenticationRequirementPolicies")]
        public IEnumerable<AuthenticationRequirementPolicy> AuthenticationRequirementPolicies { get; set; }
    
        /// <summary>
        /// Gets or sets client app used.
        /// The legacy client used for sign-in activity. For example: Browser, Exchange Active Sync, Modern clients, IMAP, MAPI, SMTP, or POP. Supports $filter (eq operator only).
        /// </summary>
        [JsonPropertyName("clientAppUsed")]
        public string ClientAppUsed { get; set; }
    
        /// <summary>
        /// Gets or sets conditional access status.
        /// The status of the conditional access policy triggered. Possible values: success, failure, notApplied, or unknownFutureValue. Supports $filter (eq operator only).
        /// </summary>
        [JsonPropertyName("conditionalAccessStatus")]
        public ConditionalAccessStatus? ConditionalAccessStatus { get; set; }
    
        /// <summary>
        /// Gets or sets correlation id.
        /// The identifier that's sent from the client when sign-in is initiated. This is used for troubleshooting the corresponding sign-in activity when calling for support. Supports $filter (eq operator only).
        /// </summary>
        [JsonPropertyName("correlationId")]
        public string CorrelationId { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// The date and time the sign-in was initiated. The Timestamp type is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Supports $orderby and $filter (eq, le, and ge operators only).
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets device detail.
        /// The device information from where the sign-in occurred. Includes information such as deviceId, OS, and browser. Supports $filter (eq and startsWith operators only) on browser and operatingSytem properties.
        /// </summary>
        [JsonPropertyName("deviceDetail")]
        public DeviceDetail DeviceDetail { get; set; }
    
        /// <summary>
        /// Gets or sets flagged for review.
        /// </summary>
        [JsonPropertyName("flaggedForReview")]
        public bool? FlaggedForReview { get; set; }
    
        /// <summary>
        /// Gets or sets home tenant id.
        /// </summary>
        [JsonPropertyName("homeTenantId")]
        public string HomeTenantId { get; set; }
    
        /// <summary>
        /// Gets or sets ip address.
        /// The IP address of the client from where the sign-in occurred. Supports $filter (eq and startsWith operators only).
        /// </summary>
        [JsonPropertyName("ipAddress")]
        public string IpAddress { get; set; }
    
        /// <summary>
        /// Gets or sets ip address from resource provider.
        /// </summary>
        [JsonPropertyName("ipAddressFromResourceProvider")]
        public string IpAddressFromResourceProvider { get; set; }
    
        /// <summary>
        /// Gets or sets is interactive.
        /// Indicates whether a sign-in is interactive or not.
        /// </summary>
        [JsonPropertyName("isInteractive")]
        public bool? IsInteractive { get; set; }
    
        /// <summary>
        /// Gets or sets location.
        /// The city, state, and 2 letter country code from where the sign-in occurred. Supports $filter (eq and startsWith operators only) on city, state, and countryOrRegion properties.
        /// </summary>
        [JsonPropertyName("location")]
        public SignInLocation Location { get; set; }
    
        /// <summary>
        /// Gets or sets mfa detail.
        /// </summary>
        [JsonPropertyName("mfaDetail")]
        public MfaDetail MfaDetail { get; set; }
    
        /// <summary>
        /// Gets or sets network location details.
        /// The network location details including the type of network used and its names.
        /// </summary>
        [JsonPropertyName("networkLocationDetails")]
        public IEnumerable<NetworkLocationDetail> NetworkLocationDetails { get; set; }
    
        /// <summary>
        /// Gets or sets original request id.
        /// The request identifier of the first request in the authentication sequence. Supports $filter (eq operator only).
        /// </summary>
        [JsonPropertyName("originalRequestId")]
        public string OriginalRequestId { get; set; }
    
        /// <summary>
        /// Gets or sets processing time in milliseconds.
        /// The request processing time in milliseconds in AD STS.
        /// </summary>
        [JsonPropertyName("processingTimeInMilliseconds")]
        public Int32? ProcessingTimeInMilliseconds { get; set; }
    
        /// <summary>
        /// Gets or sets resource display name.
        /// The name of the resource that the user signed in to. Supports $filter (eq operator only).
        /// </summary>
        [JsonPropertyName("resourceDisplayName")]
        public string ResourceDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets resource id.
        /// The identifier of the resource that the user signed in to. Supports $filter (eq operator only).
        /// </summary>
        [JsonPropertyName("resourceId")]
        public string ResourceId { get; set; }
    
        /// <summary>
        /// Gets or sets resource tenant id.
        /// </summary>
        [JsonPropertyName("resourceTenantId")]
        public string ResourceTenantId { get; set; }
    
        /// <summary>
        /// Gets or sets risk detail.
        /// The reason behind a specific state of a risky user, sign-in, or a risk event. Possible values: none, adminGeneratedTemporaryPassword, userPerformedSecuredPasswordChange, userPerformedSecuredPasswordReset, adminConfirmedSigninSafe, aiConfirmedSigninSafe, userPassedMFADrivenByRiskBasedPolicy, adminDismissedAllRiskForUser, adminConfirmedSigninCompromised, or unknownFutureValue. The value none means that no action has been performed on the user or sign-in so far. Supports $filter (eq operator only). Note: Details for this property are only available for Azure AD Premium P2 customers. All other customers are returned hidden.
        /// </summary>
        [JsonPropertyName("riskDetail")]
        public RiskDetail? RiskDetail { get; set; }
    
        /// <summary>
        /// Gets or sets risk event types.
        /// The list of risk event types associated with the sign-in. Possible values: unlikelyTravel, anonymizedIPAddress, maliciousIPAddress, unfamiliarFeatures, malwareInfectedIPAddress, suspiciousIPAddress, leakedCredentials, investigationsThreatIntelligence,  generic, or unknownFutureValue. Supports $filter (eq operator only).
        /// </summary>
        [JsonPropertyName("riskEventTypes")]
        public IEnumerable<RiskEventType> RiskEventTypes { get; set; }
    
        /// <summary>
        /// Gets or sets risk event types_v2.
        /// The list of risk event types associated with the sign-in. Possible values: unlikelyTravel, anonymizedIPAddress, maliciousIPAddress, unfamiliarFeatures, malwareInfectedIPAddress, suspiciousIPAddress, leakedCredentials, investigationsThreatIntelligence,  generic, or unknownFutureValue. Supports $filter (eq and startsWith operators only).
        /// </summary>
        [JsonPropertyName("riskEventTypes_v2")]
        public IEnumerable<string> RiskEventTypes_v2 { get; set; }
    
        /// <summary>
        /// Gets or sets risk level aggregated.
        /// The aggregated risk level. Possible values: none, low, medium, high, hidden, or unknownFutureValue. The value hidden means the user or sign-in was not enabled for Azure AD Identity Protection. Supports $filter (eq operator only). Note: Details for this property are only available for Azure AD Premium P2 customers. All other customers are returned hidden.
        /// </summary>
        [JsonPropertyName("riskLevelAggregated")]
        public RiskLevel? RiskLevelAggregated { get; set; }
    
        /// <summary>
        /// Gets or sets risk level during sign in.
        /// The risk level during sign-in. Possible values: none, low, medium, high, hidden, or unknownFutureValue. The value hidden means the user or sign-in was not enabled for Azure AD Identity Protection. Supports $filter (eq operator only). Note: Details for this property are only available for Azure AD Premium P2 customers. All other customers are returned hidden.
        /// </summary>
        [JsonPropertyName("riskLevelDuringSignIn")]
        public RiskLevel? RiskLevelDuringSignIn { get; set; }
    
        /// <summary>
        /// Gets or sets risk state.
        /// The risk state of a risky user, sign-in, or a risk event. Possible values: none, confirmedSafe, remediated, dismissed, atRisk, confirmedCompromised, or unknownFutureValue. Supports $filter (eq operator only).
        /// </summary>
        [JsonPropertyName("riskState")]
        public RiskState? RiskState { get; set; }
    
        /// <summary>
        /// Gets or sets service principal id.
        /// The application identifier used for sign-in. This field is populated when you are signing in using an application. Supports $filter (eq and startsWith operators only).
        /// </summary>
        [JsonPropertyName("servicePrincipalId")]
        public string ServicePrincipalId { get; set; }
    
        /// <summary>
        /// Gets or sets service principal name.
        /// The application name used for sign-in. This field is populated when you are signing in using an application. Supports $filter (eq and startsWith operators only).
        /// </summary>
        [JsonPropertyName("servicePrincipalName")]
        public string ServicePrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets sign in event types.
        /// </summary>
        [JsonPropertyName("signInEventTypes")]
        public IEnumerable<string> SignInEventTypes { get; set; }
    
        /// <summary>
        /// Gets or sets sign in identifier.
        /// </summary>
        [JsonPropertyName("signInIdentifier")]
        public string SignInIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets sign in identifier type.
        /// </summary>
        [JsonPropertyName("signInIdentifierType")]
        public SignInIdentifierType? SignInIdentifierType { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// The sign-in status. Includes the error code and description of the error (in case of a sign-in failure). Supports $filter (eq operator only) on errorCode property.
        /// </summary>
        [JsonPropertyName("status")]
        public SignInStatus Status { get; set; }
    
        /// <summary>
        /// Gets or sets token issuer name.
        /// The name of the identity provider. For example, sts.microsoft.com. Supports $filter (eq operator only).
        /// </summary>
        [JsonPropertyName("tokenIssuerName")]
        public string TokenIssuerName { get; set; }
    
        /// <summary>
        /// Gets or sets token issuer type.
        /// The type of identity provider. Possible values: AzureAD, ADFederationServices, or UnknownFutureValue.
        /// </summary>
        [JsonPropertyName("tokenIssuerType")]
        public TokenIssuerType? TokenIssuerType { get; set; }
    
        /// <summary>
        /// Gets or sets user agent.
        /// The user agent information related to sign-in. Supports $filter (eq and startsWith operators only).
        /// </summary>
        [JsonPropertyName("userAgent")]
        public string UserAgent { get; set; }
    
        /// <summary>
        /// Gets or sets user display name.
        /// The display name of the user. Supports $filter (eq and startsWith operators only).
        /// </summary>
        [JsonPropertyName("userDisplayName")]
        public string UserDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets user id.
        /// The identifier of the user. Supports $filter (eq operator only).
        /// </summary>
        [JsonPropertyName("userId")]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// The UPN of the user. Supports $filter (eq and startsWith operators only).
        /// </summary>
        [JsonPropertyName("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets user type.
        /// </summary>
        [JsonPropertyName("userType")]
        public SignInUserType? UserType { get; set; }
    
    }
}

