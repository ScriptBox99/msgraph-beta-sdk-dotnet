// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Enrollment Profile used to enroll Android Enterprise devices using Google&apos;s Cloud Management.
    /// </summary>
    public class AndroidDeviceOwnerEnrollmentProfile : Entity, IParsable {
        /// <summary>Tenant GUID the enrollment profile belongs to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountId {
            get { return BackingStore?.Get<string?>("accountId"); }
            set { BackingStore?.Set("accountId", value); }
        }
#nullable restore
#else
        public string AccountId {
            get { return BackingStore?.Get<string>("accountId"); }
            set { BackingStore?.Set("accountId", value); }
        }
#endif
        /// <summary>Boolean that indicates that the Wi-Fi network should be configured during device provisioning. When set to TRUE, device provisioning will use Wi-Fi related properties to automatically connect to Wi-Fi networks. When set to FALSE or undefined, other Wi-Fi related properties will be ignored. Default value is TRUE. Returned by default.</summary>
        public bool? ConfigureWifi {
            get { return BackingStore?.Get<bool?>("configureWifi"); }
            set { BackingStore?.Set("configureWifi", value); }
        }
        /// <summary>Date time the enrollment profile was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Description for the enrollment profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>Display name for the enrollment profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Total number of Android devices that have enrolled using this enrollment profile.</summary>
        public int? EnrolledDeviceCount {
            get { return BackingStore?.Get<int?>("enrolledDeviceCount"); }
            set { BackingStore?.Set("enrolledDeviceCount", value); }
        }
        /// <summary>The enrollment mode for an enrollment profile.</summary>
        public AndroidDeviceOwnerEnrollmentMode? EnrollmentMode {
            get { return BackingStore?.Get<AndroidDeviceOwnerEnrollmentMode?>("enrollmentMode"); }
            set { BackingStore?.Set("enrollmentMode", value); }
        }
        /// <summary>The enrollment token type for an enrollment profile.</summary>
        public AndroidDeviceOwnerEnrollmentTokenType? EnrollmentTokenType {
            get { return BackingStore?.Get<AndroidDeviceOwnerEnrollmentTokenType?>("enrollmentTokenType"); }
            set { BackingStore?.Set("enrollmentTokenType", value); }
        }
        /// <summary>Total number of AOSP devices that have enrolled using the current token.</summary>
        public int? EnrollmentTokenUsageCount {
            get { return BackingStore?.Get<int?>("enrollmentTokenUsageCount"); }
            set { BackingStore?.Set("enrollmentTokenUsageCount", value); }
        }
        /// <summary>Boolean indicating if this profile is an Android AOSP for Teams device profile.</summary>
        public bool? IsTeamsDeviceProfile {
            get { return BackingStore?.Get<bool?>("isTeamsDeviceProfile"); }
            set { BackingStore?.Set("isTeamsDeviceProfile", value); }
        }
        /// <summary>Date time the enrollment profile was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>String used to generate a QR code for the token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? QrCodeContent {
            get { return BackingStore?.Get<string?>("qrCodeContent"); }
            set { BackingStore?.Set("qrCodeContent", value); }
        }
#nullable restore
#else
        public string QrCodeContent {
            get { return BackingStore?.Get<string>("qrCodeContent"); }
            set { BackingStore?.Set("qrCodeContent", value); }
        }
#endif
        /// <summary>String used to generate a QR code for the token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MimeContent? QrCodeImage {
            get { return BackingStore?.Get<MimeContent?>("qrCodeImage"); }
            set { BackingStore?.Set("qrCodeImage", value); }
        }
#nullable restore
#else
        public MimeContent QrCodeImage {
            get { return BackingStore?.Get<MimeContent>("qrCodeImage"); }
            set { BackingStore?.Set("qrCodeImage", value); }
        }
#endif
        /// <summary>List of Scope Tags for this Entity instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>?>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
#nullable restore
#else
        public List<string> RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
#endif
        /// <summary>Date time the most recently created token was created.</summary>
        public DateTimeOffset? TokenCreationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("tokenCreationDateTime"); }
            set { BackingStore?.Set("tokenCreationDateTime", value); }
        }
        /// <summary>Date time the most recently created token will expire.</summary>
        public DateTimeOffset? TokenExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("tokenExpirationDateTime"); }
            set { BackingStore?.Set("tokenExpirationDateTime", value); }
        }
        /// <summary>Value of the most recently created token for this enrollment profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TokenValue {
            get { return BackingStore?.Get<string?>("tokenValue"); }
            set { BackingStore?.Set("tokenValue", value); }
        }
#nullable restore
#else
        public string TokenValue {
            get { return BackingStore?.Get<string>("tokenValue"); }
            set { BackingStore?.Set("tokenValue", value); }
        }
#endif
        /// <summary>Boolean that indicates if hidden wifi networks are enabled</summary>
        public bool? WifiHidden {
            get { return BackingStore?.Get<bool?>("wifiHidden"); }
            set { BackingStore?.Set("wifiHidden", value); }
        }
        /// <summary>String that contains the wi-fi login password</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WifiPassword {
            get { return BackingStore?.Get<string?>("wifiPassword"); }
            set { BackingStore?.Set("wifiPassword", value); }
        }
#nullable restore
#else
        public string WifiPassword {
            get { return BackingStore?.Get<string>("wifiPassword"); }
            set { BackingStore?.Set("wifiPassword", value); }
        }
#endif
        /// <summary>This enum represents Wi-Fi Security Types for Android Device Owner AOSP Scenarios.</summary>
        public AospWifiSecurityType? WifiSecurityType {
            get { return BackingStore?.Get<AospWifiSecurityType?>("wifiSecurityType"); }
            set { BackingStore?.Set("wifiSecurityType", value); }
        }
        /// <summary>String that contains the wi-fi login ssid</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WifiSsid {
            get { return BackingStore?.Get<string?>("wifiSsid"); }
            set { BackingStore?.Set("wifiSsid", value); }
        }
#nullable restore
#else
        public string WifiSsid {
            get { return BackingStore?.Get<string>("wifiSsid"); }
            set { BackingStore?.Set("wifiSsid", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AndroidDeviceOwnerEnrollmentProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidDeviceOwnerEnrollmentProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accountId", n => { AccountId = n.GetStringValue(); } },
                {"configureWifi", n => { ConfigureWifi = n.GetBoolValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"enrolledDeviceCount", n => { EnrolledDeviceCount = n.GetIntValue(); } },
                {"enrollmentMode", n => { EnrollmentMode = n.GetEnumValue<AndroidDeviceOwnerEnrollmentMode>(); } },
                {"enrollmentTokenType", n => { EnrollmentTokenType = n.GetEnumValue<AndroidDeviceOwnerEnrollmentTokenType>(); } },
                {"enrollmentTokenUsageCount", n => { EnrollmentTokenUsageCount = n.GetIntValue(); } },
                {"isTeamsDeviceProfile", n => { IsTeamsDeviceProfile = n.GetBoolValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"qrCodeContent", n => { QrCodeContent = n.GetStringValue(); } },
                {"qrCodeImage", n => { QrCodeImage = n.GetObjectValue<MimeContent>(MimeContent.CreateFromDiscriminatorValue); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"tokenCreationDateTime", n => { TokenCreationDateTime = n.GetDateTimeOffsetValue(); } },
                {"tokenExpirationDateTime", n => { TokenExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"tokenValue", n => { TokenValue = n.GetStringValue(); } },
                {"wifiHidden", n => { WifiHidden = n.GetBoolValue(); } },
                {"wifiPassword", n => { WifiPassword = n.GetStringValue(); } },
                {"wifiSecurityType", n => { WifiSecurityType = n.GetEnumValue<AospWifiSecurityType>(); } },
                {"wifiSsid", n => { WifiSsid = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("accountId", AccountId);
            writer.WriteBoolValue("configureWifi", ConfigureWifi);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteIntValue("enrolledDeviceCount", EnrolledDeviceCount);
            writer.WriteEnumValue<AndroidDeviceOwnerEnrollmentMode>("enrollmentMode", EnrollmentMode);
            writer.WriteEnumValue<AndroidDeviceOwnerEnrollmentTokenType>("enrollmentTokenType", EnrollmentTokenType);
            writer.WriteIntValue("enrollmentTokenUsageCount", EnrollmentTokenUsageCount);
            writer.WriteBoolValue("isTeamsDeviceProfile", IsTeamsDeviceProfile);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("qrCodeContent", QrCodeContent);
            writer.WriteObjectValue<MimeContent>("qrCodeImage", QrCodeImage);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteDateTimeOffsetValue("tokenCreationDateTime", TokenCreationDateTime);
            writer.WriteDateTimeOffsetValue("tokenExpirationDateTime", TokenExpirationDateTime);
            writer.WriteStringValue("tokenValue", TokenValue);
            writer.WriteBoolValue("wifiHidden", WifiHidden);
            writer.WriteStringValue("wifiPassword", WifiPassword);
            writer.WriteEnumValue<AospWifiSecurityType>("wifiSecurityType", WifiSecurityType);
            writer.WriteStringValue("wifiSsid", WifiSsid);
        }
    }
}
