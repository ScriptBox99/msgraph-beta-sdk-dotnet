using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Device : DirectoryObject, IParsable {
        /// <summary>true if the account is enabled; otherwise, false. Default is true.  Supports $filter (eq, ne, not, in). Only callers in Global Administrator and Cloud Device Administrator roles can set this property.</summary>
        public bool? AccountEnabled {
            get { return BackingStore?.Get<bool?>("accountEnabled"); }
            set { BackingStore?.Set("accountEnabled", value); }
        }
        /// <summary>For internal use only. Not nullable. Supports $filter (eq, not, ge, le).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AlternativeSecurityId>? AlternativeSecurityIds {
            get { return BackingStore?.Get<List<AlternativeSecurityId>?>("alternativeSecurityIds"); }
            set { BackingStore?.Set("alternativeSecurityIds", value); }
        }
#nullable restore
#else
        public List<AlternativeSecurityId> AlternativeSecurityIds {
            get { return BackingStore?.Get<List<AlternativeSecurityId>>("alternativeSecurityIds"); }
            set { BackingStore?.Set("alternativeSecurityIds", value); }
        }
#endif
        /// <summary>The timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only. Supports $filter (eq, ne, not, ge, le, and eq on null values) and $orderBy.</summary>
        public DateTimeOffset? ApproximateLastSignInDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("approximateLastSignInDateTime"); }
            set { BackingStore?.Set("approximateLastSignInDateTime", value); }
        }
        /// <summary>Set of commands sent to this device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Command>? Commands {
            get { return BackingStore?.Get<List<Command>?>("commands"); }
            set { BackingStore?.Set("commands", value); }
        }
#nullable restore
#else
        public List<Command> Commands {
            get { return BackingStore?.Get<List<Command>>("commands"); }
            set { BackingStore?.Set("commands", value); }
        }
#endif
        /// <summary>The timestamp when the device is no longer deemed compliant. The timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? ComplianceExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("complianceExpirationDateTime"); }
            set { BackingStore?.Set("complianceExpirationDateTime", value); }
        }
        /// <summary>User-defined property set by Intune to automatically add devices to groups and simplify managing devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceCategory {
            get { return BackingStore?.Get<string?>("deviceCategory"); }
            set { BackingStore?.Set("deviceCategory", value); }
        }
#nullable restore
#else
        public string DeviceCategory {
            get { return BackingStore?.Get<string>("deviceCategory"); }
            set { BackingStore?.Set("deviceCategory", value); }
        }
#endif
        /// <summary>Unique Identifier set by Azure Device Registration Service at the time of registration. This is an alternate key that can be used to reference the device object. Also Supports $filter (eq, ne, not, startsWith).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceId {
            get { return BackingStore?.Get<string?>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#nullable restore
#else
        public string DeviceId {
            get { return BackingStore?.Get<string>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#endif
        /// <summary>For internal use only. Set to null.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceMetadata {
            get { return BackingStore?.Get<string?>("deviceMetadata"); }
            set { BackingStore?.Set("deviceMetadata", value); }
        }
#nullable restore
#else
        public string DeviceMetadata {
            get { return BackingStore?.Get<string>("deviceMetadata"); }
            set { BackingStore?.Set("deviceMetadata", value); }
        }
#endif
        /// <summary>Ownership of the device. This property is set by Intune. Possible values are: unknown, company, personal.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceOwnership {
            get { return BackingStore?.Get<string?>("deviceOwnership"); }
            set { BackingStore?.Set("deviceOwnership", value); }
        }
#nullable restore
#else
        public string DeviceOwnership {
            get { return BackingStore?.Get<string>("deviceOwnership"); }
            set { BackingStore?.Set("deviceOwnership", value); }
        }
#endif
        /// <summary>For internal use only.</summary>
        public int? DeviceVersion {
            get { return BackingStore?.Get<int?>("deviceVersion"); }
            set { BackingStore?.Set("deviceVersion", value); }
        }
        /// <summary>The display name for the device. Required. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values), $search, and $orderBy.</summary>
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
        /// <summary>The on-premises domain name of Hybrid Azure AD joined devices. This property is set by Intune.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DomainName {
            get { return BackingStore?.Get<string?>("domainName"); }
            set { BackingStore?.Set("domainName", value); }
        }
#nullable restore
#else
        public string DomainName {
            get { return BackingStore?.Get<string>("domainName"); }
            set { BackingStore?.Set("domainName", value); }
        }
#endif
        /// <summary>Enrollment profile applied to the device. For example, Apple Device Enrollment Profile, Device enrollment - Corporate device identifiers, or Windows Autopilot profile name. This property is set by Intune.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EnrollmentProfileName {
            get { return BackingStore?.Get<string?>("enrollmentProfileName"); }
            set { BackingStore?.Set("enrollmentProfileName", value); }
        }
#nullable restore
#else
        public string EnrollmentProfileName {
            get { return BackingStore?.Get<string>("enrollmentProfileName"); }
            set { BackingStore?.Set("enrollmentProfileName", value); }
        }
#endif
        /// <summary>Enrollment type of the device. This property is set by Intune. Possible values are: unknown, userEnrollment, deviceEnrollmentManager, appleBulkWithUser, appleBulkWithoutUser, windowsAzureADJoin, windowsBulkUserless, windowsAutoEnrollment, windowsBulkAzureDomainJoin, windowsCoManagement.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EnrollmentType {
            get { return BackingStore?.Get<string?>("enrollmentType"); }
            set { BackingStore?.Set("enrollmentType", value); }
        }
#nullable restore
#else
        public string EnrollmentType {
            get { return BackingStore?.Get<string>("enrollmentType"); }
            set { BackingStore?.Set("enrollmentType", value); }
        }
#endif
        /// <summary>Contains extension attributes 1-15 for the device. The individual extension attributes are not selectable. These properties are mastered in cloud and can be set during creation or update of a device object in Azure AD. Supports $filter (eq, not, startsWith, and eq on null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OnPremisesExtensionAttributes? ExtensionAttributes {
            get { return BackingStore?.Get<OnPremisesExtensionAttributes?>("extensionAttributes"); }
            set { BackingStore?.Set("extensionAttributes", value); }
        }
#nullable restore
#else
        public OnPremisesExtensionAttributes ExtensionAttributes {
            get { return BackingStore?.Get<OnPremisesExtensionAttributes>("extensionAttributes"); }
            set { BackingStore?.Set("extensionAttributes", value); }
        }
#endif
        /// <summary>The collection of open extensions defined for the device. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Extension>? Extensions {
            get { return BackingStore?.Get<List<Extension>?>("extensions"); }
            set { BackingStore?.Set("extensions", value); }
        }
#nullable restore
#else
        public List<Extension> Extensions {
            get { return BackingStore?.Get<List<Extension>>("extensions"); }
            set { BackingStore?.Set("extensions", value); }
        }
#endif
        /// <summary>List of hostNames for the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Hostnames {
            get { return BackingStore?.Get<List<string>?>("hostnames"); }
            set { BackingStore?.Set("hostnames", value); }
        }
#nullable restore
#else
        public List<string> Hostnames {
            get { return BackingStore?.Get<List<string>>("hostnames"); }
            set { BackingStore?.Set("hostnames", value); }
        }
#endif
        /// <summary>true if the device complies with Mobile Device Management (MDM) policies; otherwise, false. Read-only. This can only be updated by Intune for any device OS type or by an approved MDM app for Windows OS devices. Supports $filter (eq, ne, not).</summary>
        public bool? IsCompliant {
            get { return BackingStore?.Get<bool?>("isCompliant"); }
            set { BackingStore?.Set("isCompliant", value); }
        }
        /// <summary>true if the device is managed by a Mobile Device Management (MDM) app; otherwise, false. This can only be updated by Intune for any device OS type or by an approved MDM app for Windows OS devices. Supports $filter (eq, ne, not).</summary>
        public bool? IsManaged {
            get { return BackingStore?.Get<bool?>("isManaged"); }
            set { BackingStore?.Set("isManaged", value); }
        }
        /// <summary>The isManagementRestricted property</summary>
        public bool? IsManagementRestricted {
            get { return BackingStore?.Get<bool?>("isManagementRestricted"); }
            set { BackingStore?.Set("isManagementRestricted", value); }
        }
        /// <summary>true if device is rooted; false if device is jail-broken. This can only be updated by Intune.</summary>
        public bool? IsRooted {
            get { return BackingStore?.Get<bool?>("isRooted"); }
            set { BackingStore?.Set("isRooted", value); }
        }
        /// <summary>Form factor of device. Only returned if user signs in with a Microsoft account as part of Project Rome.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Kind {
            get { return BackingStore?.Get<string?>("kind"); }
            set { BackingStore?.Set("kind", value); }
        }
#nullable restore
#else
        public string Kind {
            get { return BackingStore?.Get<string>("kind"); }
            set { BackingStore?.Set("kind", value); }
        }
#endif
        /// <summary>Management channel of the device.  This property is set by Intune. Possible values are: eas, mdm, easMdm, intuneClient, easIntuneClient, configurationManagerClient, configurationManagerClientMdm, configurationManagerClientMdmEas, unknown, jamf, googleCloudDevicePolicyController.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagementType {
            get { return BackingStore?.Get<string?>("managementType"); }
            set { BackingStore?.Set("managementType", value); }
        }
#nullable restore
#else
        public string ManagementType {
            get { return BackingStore?.Get<string>("managementType"); }
            set { BackingStore?.Set("managementType", value); }
        }
#endif
        /// <summary>Manufacturer of the device. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Manufacturer {
            get { return BackingStore?.Get<string?>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
#nullable restore
#else
        public string Manufacturer {
            get { return BackingStore?.Get<string>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
#endif
        /// <summary>Application identifier used to register device into MDM. Read-only. Supports $filter (eq, ne, not, startsWith).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MdmAppId {
            get { return BackingStore?.Get<string?>("mdmAppId"); }
            set { BackingStore?.Set("mdmAppId", value); }
        }
#nullable restore
#else
        public string MdmAppId {
            get { return BackingStore?.Get<string>("mdmAppId"); }
            set { BackingStore?.Set("mdmAppId", value); }
        }
#endif
        /// <summary>Groups and administrative units that this device is a member of. Read-only. Nullable. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? MemberOf {
            get { return BackingStore?.Get<List<DirectoryObject>?>("memberOf"); }
            set { BackingStore?.Set("memberOf", value); }
        }
#nullable restore
#else
        public List<DirectoryObject> MemberOf {
            get { return BackingStore?.Get<List<DirectoryObject>>("memberOf"); }
            set { BackingStore?.Set("memberOf", value); }
        }
#endif
        /// <summary>Model of the device. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Model {
            get { return BackingStore?.Get<string?>("model"); }
            set { BackingStore?.Set("model", value); }
        }
#nullable restore
#else
        public string Model {
            get { return BackingStore?.Get<string>("model"); }
            set { BackingStore?.Set("model", value); }
        }
#endif
        /// <summary>Friendly name of a device. Only returned if user signs in with a Microsoft account as part of Project Rome.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The last time at which the object was synced with the on-premises directory. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z Read-only. Supports $filter (eq, ne, not, ge, le, in).</summary>
        public DateTimeOffset? OnPremisesLastSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("onPremisesLastSyncDateTime"); }
            set { BackingStore?.Set("onPremisesLastSyncDateTime", value); }
        }
        /// <summary>true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced; null if this object has never been synced from an on-premises directory (default). Read-only. Supports $filter (eq, ne, not, in, and eq on null values).</summary>
        public bool? OnPremisesSyncEnabled {
            get { return BackingStore?.Get<bool?>("onPremisesSyncEnabled"); }
            set { BackingStore?.Set("onPremisesSyncEnabled", value); }
        }
        /// <summary>The type of operating system on the device. Required. Supports $filter (eq, ne, not, ge, le, startsWith, and eq on null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OperatingSystem {
            get { return BackingStore?.Get<string?>("operatingSystem"); }
            set { BackingStore?.Set("operatingSystem", value); }
        }
#nullable restore
#else
        public string OperatingSystem {
            get { return BackingStore?.Get<string>("operatingSystem"); }
            set { BackingStore?.Set("operatingSystem", value); }
        }
#endif
        /// <summary>Operating system version of the device. Required. Supports $filter (eq, ne, not, ge, le, startsWith, and eq on null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OperatingSystemVersion {
            get { return BackingStore?.Get<string?>("operatingSystemVersion"); }
            set { BackingStore?.Set("operatingSystemVersion", value); }
        }
#nullable restore
#else
        public string OperatingSystemVersion {
            get { return BackingStore?.Get<string>("operatingSystemVersion"); }
            set { BackingStore?.Set("operatingSystemVersion", value); }
        }
#endif
        /// <summary>For internal use only. Not nullable. Supports $filter (eq, not, ge, le, startsWith, /$count eq 0, /$count ne 0.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? PhysicalIds {
            get { return BackingStore?.Get<List<string>?>("physicalIds"); }
            set { BackingStore?.Set("physicalIds", value); }
        }
#nullable restore
#else
        public List<string> PhysicalIds {
            get { return BackingStore?.Get<List<string>>("physicalIds"); }
            set { BackingStore?.Set("physicalIds", value); }
        }
#endif
        /// <summary>Platform of device. Only returned if user signs in with a Microsoft account as part of Project Rome. Only returned if user signs in with a Microsoft account as part of Project Rome.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Platform {
            get { return BackingStore?.Get<string?>("platform"); }
            set { BackingStore?.Set("platform", value); }
        }
#nullable restore
#else
        public string Platform {
            get { return BackingStore?.Get<string>("platform"); }
            set { BackingStore?.Set("platform", value); }
        }
#endif
        /// <summary>The profile type of the device. Possible values: RegisteredDevice (default), SecureVM, Printer, Shared, IoT.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProfileType {
            get { return BackingStore?.Get<string?>("profileType"); }
            set { BackingStore?.Set("profileType", value); }
        }
#nullable restore
#else
        public string ProfileType {
            get { return BackingStore?.Get<string>("profileType"); }
            set { BackingStore?.Set("profileType", value); }
        }
#endif
        /// <summary>The user that cloud joined the device or registered their personal device. The registered owner is set at the time of registration. Currently, there can be only one owner. Read-only. Nullable. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? RegisteredOwners {
            get { return BackingStore?.Get<List<DirectoryObject>?>("registeredOwners"); }
            set { BackingStore?.Set("registeredOwners", value); }
        }
#nullable restore
#else
        public List<DirectoryObject> RegisteredOwners {
            get { return BackingStore?.Get<List<DirectoryObject>>("registeredOwners"); }
            set { BackingStore?.Set("registeredOwners", value); }
        }
#endif
        /// <summary>Collection of registered users of the device. For cloud joined devices and registered personal devices, registered users are set to the same value as registered owners at the time of registration. Read-only. Nullable. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? RegisteredUsers {
            get { return BackingStore?.Get<List<DirectoryObject>?>("registeredUsers"); }
            set { BackingStore?.Set("registeredUsers", value); }
        }
#nullable restore
#else
        public List<DirectoryObject> RegisteredUsers {
            get { return BackingStore?.Get<List<DirectoryObject>>("registeredUsers"); }
            set { BackingStore?.Set("registeredUsers", value); }
        }
#endif
        /// <summary>Date and time of when the device was registered. The timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? RegistrationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("registrationDateTime"); }
            set { BackingStore?.Set("registrationDateTime", value); }
        }
        /// <summary>Device is online or offline. Only returned if user signs in with a Microsoft account as part of Project Rome.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status {
            get { return BackingStore?.Get<string?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#nullable restore
#else
        public string Status {
            get { return BackingStore?.Get<string>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#endif
        /// <summary>List of labels applied to the device by the system. Supports $filter (/$count eq 0, /$count ne 0).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SystemLabels {
            get { return BackingStore?.Get<List<string>?>("systemLabels"); }
            set { BackingStore?.Set("systemLabels", value); }
        }
#nullable restore
#else
        public List<string> SystemLabels {
            get { return BackingStore?.Get<List<string>>("systemLabels"); }
            set { BackingStore?.Set("systemLabels", value); }
        }
#endif
        /// <summary>Groups and administrative units that this device is a member of. This operation is transitive. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? TransitiveMemberOf {
            get { return BackingStore?.Get<List<DirectoryObject>?>("transitiveMemberOf"); }
            set { BackingStore?.Set("transitiveMemberOf", value); }
        }
#nullable restore
#else
        public List<DirectoryObject> TransitiveMemberOf {
            get { return BackingStore?.Get<List<DirectoryObject>>("transitiveMemberOf"); }
            set { BackingStore?.Set("transitiveMemberOf", value); }
        }
#endif
        /// <summary>Type of trust for the joined device. Read-only. Possible values: Workplace (indicates bring your own personal devices), AzureAd (Cloud only joined devices), ServerAd (on-premises domain joined devices joined to Azure AD). For more details, see Introduction to device management in Azure Active Directory</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TrustType {
            get { return BackingStore?.Get<string?>("trustType"); }
            set { BackingStore?.Set("trustType", value); }
        }
#nullable restore
#else
        public string TrustType {
            get { return BackingStore?.Get<string>("trustType"); }
            set { BackingStore?.Set("trustType", value); }
        }
#endif
        /// <summary>Represents the usage rights a device has been granted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UsageRight>? UsageRights {
            get { return BackingStore?.Get<List<UsageRight>?>("usageRights"); }
            set { BackingStore?.Set("usageRights", value); }
        }
#nullable restore
#else
        public List<UsageRight> UsageRights {
            get { return BackingStore?.Get<List<UsageRight>>("usageRights"); }
            set { BackingStore?.Set("usageRights", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new Device and sets the default values.
        /// </summary>
        public Device() : base() {
            OdataType = "#microsoft.graph.device";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Device CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Device();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accountEnabled", n => { AccountEnabled = n.GetBoolValue(); } },
                {"alternativeSecurityIds", n => { AlternativeSecurityIds = n.GetCollectionOfObjectValues<AlternativeSecurityId>(AlternativeSecurityId.CreateFromDiscriminatorValue)?.ToList(); } },
                {"approximateLastSignInDateTime", n => { ApproximateLastSignInDateTime = n.GetDateTimeOffsetValue(); } },
                {"commands", n => { Commands = n.GetCollectionOfObjectValues<Command>(Command.CreateFromDiscriminatorValue)?.ToList(); } },
                {"complianceExpirationDateTime", n => { ComplianceExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"deviceCategory", n => { DeviceCategory = n.GetStringValue(); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"deviceMetadata", n => { DeviceMetadata = n.GetStringValue(); } },
                {"deviceOwnership", n => { DeviceOwnership = n.GetStringValue(); } },
                {"deviceVersion", n => { DeviceVersion = n.GetIntValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"domainName", n => { DomainName = n.GetStringValue(); } },
                {"enrollmentProfileName", n => { EnrollmentProfileName = n.GetStringValue(); } },
                {"enrollmentType", n => { EnrollmentType = n.GetStringValue(); } },
                {"extensionAttributes", n => { ExtensionAttributes = n.GetObjectValue<OnPremisesExtensionAttributes>(OnPremisesExtensionAttributes.CreateFromDiscriminatorValue); } },
                {"extensions", n => { Extensions = n.GetCollectionOfObjectValues<Extension>(Extension.CreateFromDiscriminatorValue)?.ToList(); } },
                {"hostnames", n => { Hostnames = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"isCompliant", n => { IsCompliant = n.GetBoolValue(); } },
                {"isManaged", n => { IsManaged = n.GetBoolValue(); } },
                {"isManagementRestricted", n => { IsManagementRestricted = n.GetBoolValue(); } },
                {"isRooted", n => { IsRooted = n.GetBoolValue(); } },
                {"kind", n => { Kind = n.GetStringValue(); } },
                {"managementType", n => { ManagementType = n.GetStringValue(); } },
                {"manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                {"mdmAppId", n => { MdmAppId = n.GetStringValue(); } },
                {"memberOf", n => { MemberOf = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"onPremisesLastSyncDateTime", n => { OnPremisesLastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"onPremisesSyncEnabled", n => { OnPremisesSyncEnabled = n.GetBoolValue(); } },
                {"operatingSystem", n => { OperatingSystem = n.GetStringValue(); } },
                {"operatingSystemVersion", n => { OperatingSystemVersion = n.GetStringValue(); } },
                {"physicalIds", n => { PhysicalIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"platform", n => { Platform = n.GetStringValue(); } },
                {"profileType", n => { ProfileType = n.GetStringValue(); } },
                {"registeredOwners", n => { RegisteredOwners = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"registeredUsers", n => { RegisteredUsers = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"registrationDateTime", n => { RegistrationDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", n => { Status = n.GetStringValue(); } },
                {"systemLabels", n => { SystemLabels = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"transitiveMemberOf", n => { TransitiveMemberOf = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"trustType", n => { TrustType = n.GetStringValue(); } },
                {"usageRights", n => { UsageRights = n.GetCollectionOfObjectValues<UsageRight>(UsageRight.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("accountEnabled", AccountEnabled);
            writer.WriteCollectionOfObjectValues<AlternativeSecurityId>("alternativeSecurityIds", AlternativeSecurityIds);
            writer.WriteDateTimeOffsetValue("approximateLastSignInDateTime", ApproximateLastSignInDateTime);
            writer.WriteCollectionOfObjectValues<Command>("commands", Commands);
            writer.WriteDateTimeOffsetValue("complianceExpirationDateTime", ComplianceExpirationDateTime);
            writer.WriteStringValue("deviceCategory", DeviceCategory);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("deviceMetadata", DeviceMetadata);
            writer.WriteStringValue("deviceOwnership", DeviceOwnership);
            writer.WriteIntValue("deviceVersion", DeviceVersion);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("domainName", DomainName);
            writer.WriteStringValue("enrollmentProfileName", EnrollmentProfileName);
            writer.WriteStringValue("enrollmentType", EnrollmentType);
            writer.WriteObjectValue<OnPremisesExtensionAttributes>("extensionAttributes", ExtensionAttributes);
            writer.WriteCollectionOfObjectValues<Extension>("extensions", Extensions);
            writer.WriteCollectionOfPrimitiveValues<string>("hostnames", Hostnames);
            writer.WriteBoolValue("isCompliant", IsCompliant);
            writer.WriteBoolValue("isManaged", IsManaged);
            writer.WriteBoolValue("isManagementRestricted", IsManagementRestricted);
            writer.WriteBoolValue("isRooted", IsRooted);
            writer.WriteStringValue("kind", Kind);
            writer.WriteStringValue("managementType", ManagementType);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("mdmAppId", MdmAppId);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("memberOf", MemberOf);
            writer.WriteStringValue("model", Model);
            writer.WriteStringValue("name", Name);
            writer.WriteDateTimeOffsetValue("onPremisesLastSyncDateTime", OnPremisesLastSyncDateTime);
            writer.WriteBoolValue("onPremisesSyncEnabled", OnPremisesSyncEnabled);
            writer.WriteStringValue("operatingSystem", OperatingSystem);
            writer.WriteStringValue("operatingSystemVersion", OperatingSystemVersion);
            writer.WriteCollectionOfPrimitiveValues<string>("physicalIds", PhysicalIds);
            writer.WriteStringValue("platform", Platform);
            writer.WriteStringValue("profileType", ProfileType);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("registeredOwners", RegisteredOwners);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("registeredUsers", RegisteredUsers);
            writer.WriteDateTimeOffsetValue("registrationDateTime", RegistrationDateTime);
            writer.WriteStringValue("status", Status);
            writer.WriteCollectionOfPrimitiveValues<string>("systemLabels", SystemLabels);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("transitiveMemberOf", TransitiveMemberOf);
            writer.WriteStringValue("trustType", TrustType);
            writer.WriteCollectionOfObjectValues<UsageRight>("usageRights", UsageRights);
        }
    }
}
