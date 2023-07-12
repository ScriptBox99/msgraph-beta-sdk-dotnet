using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// This entity provides descriptions of the declared methods, properties and relationships exposed by the Wifi CSP.
    /// </summary>
    public class WindowsWifiEnterpriseEAPConfiguration : WindowsWifiConfiguration, IParsable {
        /// <summary>Specify the authentication method. Possible values are: certificate, usernameAndPassword, derivedCredential.</summary>
        public WiFiAuthenticationMethod? AuthenticationMethod {
            get { return BackingStore?.Get<WiFiAuthenticationMethod?>("authenticationMethod"); }
            set { BackingStore?.Set("authenticationMethod", value); }
        }
        /// <summary>Specify the number of seconds for the client to wait after an authentication attempt before failing. Valid range 1-3600.</summary>
        public int? AuthenticationPeriodInSeconds {
            get { return BackingStore?.Get<int?>("authenticationPeriodInSeconds"); }
            set { BackingStore?.Set("authenticationPeriodInSeconds", value); }
        }
        /// <summary>Specify the number of seconds between a failed authentication and the next authentication attempt. Valid range 1-3600.</summary>
        public int? AuthenticationRetryDelayPeriodInSeconds {
            get { return BackingStore?.Get<int?>("authenticationRetryDelayPeriodInSeconds"); }
            set { BackingStore?.Set("authenticationRetryDelayPeriodInSeconds", value); }
        }
        /// <summary>Specify whether to authenticate the user, the device, either, or to use guest authentication (none). If you’re using certificate authentication, make sure the certificate type matches the authentication type. Possible values are: none, user, machine, machineOrUser, guest.</summary>
        public WifiAuthenticationType? AuthenticationType {
            get { return BackingStore?.Get<WifiAuthenticationType?>("authenticationType"); }
            set { BackingStore?.Set("authenticationType", value); }
        }
        /// <summary>Specify whether to cache user credentials on the device so that users don’t need to keep entering them each time they connect.</summary>
        public bool? CacheCredentials {
            get { return BackingStore?.Get<bool?>("cacheCredentials"); }
            set { BackingStore?.Set("cacheCredentials", value); }
        }
        /// <summary>Specify whether to prevent the user from being prompted to authorize new servers for trusted certification authorities when EAP type is selected as PEAP.</summary>
        public bool? DisableUserPromptForServerValidation {
            get { return BackingStore?.Get<bool?>("disableUserPromptForServerValidation"); }
            set { BackingStore?.Set("disableUserPromptForServerValidation", value); }
        }
        /// <summary>Specify the number of seconds to wait before sending an EAPOL (Extensible Authentication Protocol over LAN) Start message. Valid range 1-3600.</summary>
        public int? EapolStartPeriodInSeconds {
            get { return BackingStore?.Get<int?>("eapolStartPeriodInSeconds"); }
            set { BackingStore?.Set("eapolStartPeriodInSeconds", value); }
        }
        /// <summary>Extensible Authentication Protocol (EAP) configuration types.</summary>
        public Microsoft.Graph.Beta.Models.EapType? EapType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EapType?>("eapType"); }
            set { BackingStore?.Set("eapType", value); }
        }
        /// <summary>Specify whether the wifi connection should enable pairwise master key caching.</summary>
        public bool? EnablePairwiseMasterKeyCaching {
            get { return BackingStore?.Get<bool?>("enablePairwiseMasterKeyCaching"); }
            set { BackingStore?.Set("enablePairwiseMasterKeyCaching", value); }
        }
        /// <summary>Specify whether pre-authentication should be enabled.</summary>
        public bool? EnablePreAuthentication {
            get { return BackingStore?.Get<bool?>("enablePreAuthentication"); }
            set { BackingStore?.Set("enablePreAuthentication", value); }
        }
        /// <summary>Specify identity certificate for client authentication.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WindowsCertificateProfileBase? IdentityCertificateForClientAuthentication {
            get { return BackingStore?.Get<WindowsCertificateProfileBase?>("identityCertificateForClientAuthentication"); }
            set { BackingStore?.Set("identityCertificateForClientAuthentication", value); }
        }
#nullable restore
#else
        public WindowsCertificateProfileBase IdentityCertificateForClientAuthentication {
            get { return BackingStore?.Get<WindowsCertificateProfileBase>("identityCertificateForClientAuthentication"); }
            set { BackingStore?.Set("identityCertificateForClientAuthentication", value); }
        }
#endif
        /// <summary>Specify inner authentication protocol for EAP TTLS. Possible values are: unencryptedPassword, challengeHandshakeAuthenticationProtocol, microsoftChap, microsoftChapVersionTwo.</summary>
        public NonEapAuthenticationMethodForEapTtlsType? InnerAuthenticationProtocolForEAPTTLS {
            get { return BackingStore?.Get<NonEapAuthenticationMethodForEapTtlsType?>("innerAuthenticationProtocolForEAPTTLS"); }
            set { BackingStore?.Set("innerAuthenticationProtocolForEAPTTLS", value); }
        }
        /// <summary>Specify the maximum authentication failures allowed for a set of credentials. Valid range 1-100.</summary>
        public int? MaximumAuthenticationFailures {
            get { return BackingStore?.Get<int?>("maximumAuthenticationFailures"); }
            set { BackingStore?.Set("maximumAuthenticationFailures", value); }
        }
        /// <summary>Specify maximum authentication timeout (in seconds).  Valid range: 1-120</summary>
        public int? MaximumAuthenticationTimeoutInSeconds {
            get { return BackingStore?.Get<int?>("maximumAuthenticationTimeoutInSeconds"); }
            set { BackingStore?.Set("maximumAuthenticationTimeoutInSeconds", value); }
        }
        /// <summary>Specifiy the maximum number of EAPOL (Extensible Authentication Protocol over LAN) Start messages to be sent before returning failure. Valid range 1-100.</summary>
        public int? MaximumEAPOLStartMessages {
            get { return BackingStore?.Get<int?>("maximumEAPOLStartMessages"); }
            set { BackingStore?.Set("maximumEAPOLStartMessages", value); }
        }
        /// <summary>Specify maximum number of pairwise master keys in cache.  Valid range: 1-255</summary>
        public int? MaximumNumberOfPairwiseMasterKeysInCache {
            get { return BackingStore?.Get<int?>("maximumNumberOfPairwiseMasterKeysInCache"); }
            set { BackingStore?.Set("maximumNumberOfPairwiseMasterKeysInCache", value); }
        }
        /// <summary>Specify maximum pairwise master key cache time (in minutes).  Valid range: 5-1440</summary>
        public int? MaximumPairwiseMasterKeyCacheTimeInMinutes {
            get { return BackingStore?.Get<int?>("maximumPairwiseMasterKeyCacheTimeInMinutes"); }
            set { BackingStore?.Set("maximumPairwiseMasterKeyCacheTimeInMinutes", value); }
        }
        /// <summary>Specify maximum pre-authentication attempts.  Valid range: 1-16</summary>
        public int? MaximumPreAuthenticationAttempts {
            get { return BackingStore?.Get<int?>("maximumPreAuthenticationAttempts"); }
            set { BackingStore?.Set("maximumPreAuthenticationAttempts", value); }
        }
        /// <summary>Specify the network single sign on type. Possible values are: disabled, prelogon, postlogon.</summary>
        public NetworkSingleSignOnType? NetworkSingleSignOn {
            get { return BackingStore?.Get<NetworkSingleSignOnType?>("networkSingleSignOn"); }
            set { BackingStore?.Set("networkSingleSignOn", value); }
        }
        /// <summary>Specify the string to replace usernames for privacy when using EAP TTLS or PEAP.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OuterIdentityPrivacyTemporaryValue {
            get { return BackingStore?.Get<string?>("outerIdentityPrivacyTemporaryValue"); }
            set { BackingStore?.Set("outerIdentityPrivacyTemporaryValue", value); }
        }
#nullable restore
#else
        public string OuterIdentityPrivacyTemporaryValue {
            get { return BackingStore?.Get<string>("outerIdentityPrivacyTemporaryValue"); }
            set { BackingStore?.Set("outerIdentityPrivacyTemporaryValue", value); }
        }
#endif
        /// <summary>Specify whether to enable verification of server&apos;s identity by validating the certificate when EAP type is selected as PEAP.</summary>
        public bool? PerformServerValidation {
            get { return BackingStore?.Get<bool?>("performServerValidation"); }
            set { BackingStore?.Set("performServerValidation", value); }
        }
        /// <summary>Specify whether the wifi connection should prompt for additional authentication credentials.</summary>
        public bool? PromptForAdditionalAuthenticationCredentials {
            get { return BackingStore?.Get<bool?>("promptForAdditionalAuthenticationCredentials"); }
            set { BackingStore?.Set("promptForAdditionalAuthenticationCredentials", value); }
        }
        /// <summary>Specify whether to enable cryptographic binding when EAP type is selected as PEAP.</summary>
        public bool? RequireCryptographicBinding {
            get { return BackingStore?.Get<bool?>("requireCryptographicBinding"); }
            set { BackingStore?.Set("requireCryptographicBinding", value); }
        }
        /// <summary>Specify root certificate for client validation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Windows81TrustedRootCertificate? RootCertificateForClientValidation {
            get { return BackingStore?.Get<Windows81TrustedRootCertificate?>("rootCertificateForClientValidation"); }
            set { BackingStore?.Set("rootCertificateForClientValidation", value); }
        }
#nullable restore
#else
        public Windows81TrustedRootCertificate RootCertificateForClientValidation {
            get { return BackingStore?.Get<Windows81TrustedRootCertificate>("rootCertificateForClientValidation"); }
            set { BackingStore?.Set("rootCertificateForClientValidation", value); }
        }
#endif
        /// <summary>Specify root certificate for server validation. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Windows81TrustedRootCertificate>? RootCertificatesForServerValidation {
            get { return BackingStore?.Get<List<Windows81TrustedRootCertificate>?>("rootCertificatesForServerValidation"); }
            set { BackingStore?.Set("rootCertificatesForServerValidation", value); }
        }
#nullable restore
#else
        public List<Windows81TrustedRootCertificate> RootCertificatesForServerValidation {
            get { return BackingStore?.Get<List<Windows81TrustedRootCertificate>>("rootCertificatesForServerValidation"); }
            set { BackingStore?.Set("rootCertificatesForServerValidation", value); }
        }
#endif
        /// <summary>Specify trusted server certificate names.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? TrustedServerCertificateNames {
            get { return BackingStore?.Get<List<string>?>("trustedServerCertificateNames"); }
            set { BackingStore?.Set("trustedServerCertificateNames", value); }
        }
#nullable restore
#else
        public List<string> TrustedServerCertificateNames {
            get { return BackingStore?.Get<List<string>>("trustedServerCertificateNames"); }
            set { BackingStore?.Set("trustedServerCertificateNames", value); }
        }
#endif
        /// <summary>Specifiy whether to change the virtual LAN used by the device based on the user’s credentials. Cannot be used when NetworkSingleSignOnType is set to ​Disabled.</summary>
        public bool? UserBasedVirtualLan {
            get { return BackingStore?.Get<bool?>("userBasedVirtualLan"); }
            set { BackingStore?.Set("userBasedVirtualLan", value); }
        }
        /// <summary>
        /// Instantiates a new windowsWifiEnterpriseEAPConfiguration and sets the default values.
        /// </summary>
        public WindowsWifiEnterpriseEAPConfiguration() : base() {
            OdataType = "#microsoft.graph.windowsWifiEnterpriseEAPConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsWifiEnterpriseEAPConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsWifiEnterpriseEAPConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"authenticationMethod", n => { AuthenticationMethod = n.GetEnumValue<WiFiAuthenticationMethod>(); } },
                {"authenticationPeriodInSeconds", n => { AuthenticationPeriodInSeconds = n.GetIntValue(); } },
                {"authenticationRetryDelayPeriodInSeconds", n => { AuthenticationRetryDelayPeriodInSeconds = n.GetIntValue(); } },
                {"authenticationType", n => { AuthenticationType = n.GetEnumValue<WifiAuthenticationType>(); } },
                {"cacheCredentials", n => { CacheCredentials = n.GetBoolValue(); } },
                {"disableUserPromptForServerValidation", n => { DisableUserPromptForServerValidation = n.GetBoolValue(); } },
                {"eapolStartPeriodInSeconds", n => { EapolStartPeriodInSeconds = n.GetIntValue(); } },
                {"eapType", n => { EapType = n.GetEnumValue<EapType>(); } },
                {"enablePairwiseMasterKeyCaching", n => { EnablePairwiseMasterKeyCaching = n.GetBoolValue(); } },
                {"enablePreAuthentication", n => { EnablePreAuthentication = n.GetBoolValue(); } },
                {"identityCertificateForClientAuthentication", n => { IdentityCertificateForClientAuthentication = n.GetObjectValue<WindowsCertificateProfileBase>(WindowsCertificateProfileBase.CreateFromDiscriminatorValue); } },
                {"innerAuthenticationProtocolForEAPTTLS", n => { InnerAuthenticationProtocolForEAPTTLS = n.GetEnumValue<NonEapAuthenticationMethodForEapTtlsType>(); } },
                {"maximumAuthenticationFailures", n => { MaximumAuthenticationFailures = n.GetIntValue(); } },
                {"maximumAuthenticationTimeoutInSeconds", n => { MaximumAuthenticationTimeoutInSeconds = n.GetIntValue(); } },
                {"maximumEAPOLStartMessages", n => { MaximumEAPOLStartMessages = n.GetIntValue(); } },
                {"maximumNumberOfPairwiseMasterKeysInCache", n => { MaximumNumberOfPairwiseMasterKeysInCache = n.GetIntValue(); } },
                {"maximumPairwiseMasterKeyCacheTimeInMinutes", n => { MaximumPairwiseMasterKeyCacheTimeInMinutes = n.GetIntValue(); } },
                {"maximumPreAuthenticationAttempts", n => { MaximumPreAuthenticationAttempts = n.GetIntValue(); } },
                {"networkSingleSignOn", n => { NetworkSingleSignOn = n.GetEnumValue<NetworkSingleSignOnType>(); } },
                {"outerIdentityPrivacyTemporaryValue", n => { OuterIdentityPrivacyTemporaryValue = n.GetStringValue(); } },
                {"performServerValidation", n => { PerformServerValidation = n.GetBoolValue(); } },
                {"promptForAdditionalAuthenticationCredentials", n => { PromptForAdditionalAuthenticationCredentials = n.GetBoolValue(); } },
                {"requireCryptographicBinding", n => { RequireCryptographicBinding = n.GetBoolValue(); } },
                {"rootCertificateForClientValidation", n => { RootCertificateForClientValidation = n.GetObjectValue<Windows81TrustedRootCertificate>(Windows81TrustedRootCertificate.CreateFromDiscriminatorValue); } },
                {"rootCertificatesForServerValidation", n => { RootCertificatesForServerValidation = n.GetCollectionOfObjectValues<Windows81TrustedRootCertificate>(Windows81TrustedRootCertificate.CreateFromDiscriminatorValue)?.ToList(); } },
                {"trustedServerCertificateNames", n => { TrustedServerCertificateNames = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"userBasedVirtualLan", n => { UserBasedVirtualLan = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<WiFiAuthenticationMethod>("authenticationMethod", AuthenticationMethod);
            writer.WriteIntValue("authenticationPeriodInSeconds", AuthenticationPeriodInSeconds);
            writer.WriteIntValue("authenticationRetryDelayPeriodInSeconds", AuthenticationRetryDelayPeriodInSeconds);
            writer.WriteEnumValue<WifiAuthenticationType>("authenticationType", AuthenticationType);
            writer.WriteBoolValue("cacheCredentials", CacheCredentials);
            writer.WriteBoolValue("disableUserPromptForServerValidation", DisableUserPromptForServerValidation);
            writer.WriteIntValue("eapolStartPeriodInSeconds", EapolStartPeriodInSeconds);
            writer.WriteEnumValue<EapType>("eapType", EapType);
            writer.WriteBoolValue("enablePairwiseMasterKeyCaching", EnablePairwiseMasterKeyCaching);
            writer.WriteBoolValue("enablePreAuthentication", EnablePreAuthentication);
            writer.WriteObjectValue<WindowsCertificateProfileBase>("identityCertificateForClientAuthentication", IdentityCertificateForClientAuthentication);
            writer.WriteEnumValue<NonEapAuthenticationMethodForEapTtlsType>("innerAuthenticationProtocolForEAPTTLS", InnerAuthenticationProtocolForEAPTTLS);
            writer.WriteIntValue("maximumAuthenticationFailures", MaximumAuthenticationFailures);
            writer.WriteIntValue("maximumAuthenticationTimeoutInSeconds", MaximumAuthenticationTimeoutInSeconds);
            writer.WriteIntValue("maximumEAPOLStartMessages", MaximumEAPOLStartMessages);
            writer.WriteIntValue("maximumNumberOfPairwiseMasterKeysInCache", MaximumNumberOfPairwiseMasterKeysInCache);
            writer.WriteIntValue("maximumPairwiseMasterKeyCacheTimeInMinutes", MaximumPairwiseMasterKeyCacheTimeInMinutes);
            writer.WriteIntValue("maximumPreAuthenticationAttempts", MaximumPreAuthenticationAttempts);
            writer.WriteEnumValue<NetworkSingleSignOnType>("networkSingleSignOn", NetworkSingleSignOn);
            writer.WriteStringValue("outerIdentityPrivacyTemporaryValue", OuterIdentityPrivacyTemporaryValue);
            writer.WriteBoolValue("performServerValidation", PerformServerValidation);
            writer.WriteBoolValue("promptForAdditionalAuthenticationCredentials", PromptForAdditionalAuthenticationCredentials);
            writer.WriteBoolValue("requireCryptographicBinding", RequireCryptographicBinding);
            writer.WriteObjectValue<Windows81TrustedRootCertificate>("rootCertificateForClientValidation", RootCertificateForClientValidation);
            writer.WriteCollectionOfObjectValues<Windows81TrustedRootCertificate>("rootCertificatesForServerValidation", RootCertificatesForServerValidation);
            writer.WriteCollectionOfPrimitiveValues<string>("trustedServerCertificateNames", TrustedServerCertificateNames);
            writer.WriteBoolValue("userBasedVirtualLan", UserBasedVirtualLan);
        }
    }
}
