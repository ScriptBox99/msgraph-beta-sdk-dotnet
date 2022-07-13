using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class KerberosSingleSignOnExtension : SingleSignOnExtension, IParsable {
        /// <summary>Gets or sets the Active Directory site.</summary>
        public string ActiveDirectorySiteCode {
            get { return BackingStore?.Get<string>("activeDirectorySiteCode"); }
            set { BackingStore?.Set("activeDirectorySiteCode", value); }
        }
        /// <summary>Enables or disables whether the Kerberos extension can automatically determine its site name.</summary>
        public bool? BlockActiveDirectorySiteAutoDiscovery {
            get { return BackingStore?.Get<bool?>("blockActiveDirectorySiteAutoDiscovery"); }
            set { BackingStore?.Set("blockActiveDirectorySiteAutoDiscovery", value); }
        }
        /// <summary>Enables or disables Keychain usage.</summary>
        public bool? BlockAutomaticLogin {
            get { return BackingStore?.Get<bool?>("blockAutomaticLogin"); }
            set { BackingStore?.Set("blockAutomaticLogin", value); }
        }
        /// <summary>Gets or sets the Generic Security Services name of the Kerberos cache to use for this profile.</summary>
        public string CacheName {
            get { return BackingStore?.Get<string>("cacheName"); }
            set { BackingStore?.Set("cacheName", value); }
        }
        /// <summary>Gets or sets a list of app Bundle IDs allowed to access the Kerberos Ticket Granting Ticket.</summary>
        public List<string> CredentialBundleIdAccessControlList {
            get { return BackingStore?.Get<List<string>>("credentialBundleIdAccessControlList"); }
            set { BackingStore?.Set("credentialBundleIdAccessControlList", value); }
        }
        /// <summary>Gets or sets a list of realms for custom domain-realm mapping. Realms are case sensitive.</summary>
        public List<string> DomainRealms {
            get { return BackingStore?.Get<List<string>>("domainRealms"); }
            set { BackingStore?.Set("domainRealms", value); }
        }
        /// <summary>Gets or sets a list of hosts or domain names for which the app extension performs SSO.</summary>
        public List<string> Domains {
            get { return BackingStore?.Get<List<string>>("domains"); }
            set { BackingStore?.Set("domains", value); }
        }
        /// <summary>When true, this profile&apos;s realm will be selected as the default. Necessary if multiple Kerberos-type profiles are configured.</summary>
        public bool? IsDefaultRealm {
            get { return BackingStore?.Get<bool?>("isDefaultRealm"); }
            set { BackingStore?.Set("isDefaultRealm", value); }
        }
        /// <summary>Enables or disables password changes.</summary>
        public bool? PasswordBlockModification {
            get { return BackingStore?.Get<bool?>("passwordBlockModification"); }
            set { BackingStore?.Set("passwordBlockModification", value); }
        }
        /// <summary>Gets or sets the URL that the user will be sent to when they initiate a password change.</summary>
        public string PasswordChangeUrl {
            get { return BackingStore?.Get<string>("passwordChangeUrl"); }
            set { BackingStore?.Set("passwordChangeUrl", value); }
        }
        /// <summary>Enables or disables password syncing. This won&apos;t affect users logged in with a mobile account on macOS.</summary>
        public bool? PasswordEnableLocalSync {
            get { return BackingStore?.Get<bool?>("passwordEnableLocalSync"); }
            set { BackingStore?.Set("passwordEnableLocalSync", value); }
        }
        /// <summary>Overrides the default password expiration in days. For most domains, this value is calculated automatically.</summary>
        public int? PasswordExpirationDays {
            get { return BackingStore?.Get<int?>("passwordExpirationDays"); }
            set { BackingStore?.Set("passwordExpirationDays", value); }
        }
        /// <summary>Gets or sets the number of days until the user is notified that their password will expire (default is 15).</summary>
        public int? PasswordExpirationNotificationDays {
            get { return BackingStore?.Get<int?>("passwordExpirationNotificationDays"); }
            set { BackingStore?.Set("passwordExpirationNotificationDays", value); }
        }
        /// <summary>Gets or sets the minimum number of days until a user can change their password again.</summary>
        public int? PasswordMinimumAgeDays {
            get { return BackingStore?.Get<int?>("passwordMinimumAgeDays"); }
            set { BackingStore?.Set("passwordMinimumAgeDays", value); }
        }
        /// <summary>Gets or sets the minimum length of a password.</summary>
        public int? PasswordMinimumLength {
            get { return BackingStore?.Get<int?>("passwordMinimumLength"); }
            set { BackingStore?.Set("passwordMinimumLength", value); }
        }
        /// <summary>Gets or sets the number of previous passwords to block.</summary>
        public int? PasswordPreviousPasswordBlockCount {
            get { return BackingStore?.Get<int?>("passwordPreviousPasswordBlockCount"); }
            set { BackingStore?.Set("passwordPreviousPasswordBlockCount", value); }
        }
        /// <summary>Enables or disables whether passwords must meet Active Directory&apos;s complexity requirements.</summary>
        public bool? PasswordRequireActiveDirectoryComplexity {
            get { return BackingStore?.Get<bool?>("passwordRequireActiveDirectoryComplexity"); }
            set { BackingStore?.Set("passwordRequireActiveDirectoryComplexity", value); }
        }
        /// <summary>Gets or sets a description of the password complexity requirements.</summary>
        public string PasswordRequirementsDescription {
            get { return BackingStore?.Get<string>("passwordRequirementsDescription"); }
            set { BackingStore?.Set("passwordRequirementsDescription", value); }
        }
        /// <summary>Gets or sets the case-sensitive realm name for this profile.</summary>
        public string Realm {
            get { return BackingStore?.Get<string>("realm"); }
            set { BackingStore?.Set("realm", value); }
        }
        /// <summary>Gets or sets whether to require authentication via Touch ID, Face ID, or a passcode to access the keychain entry.</summary>
        public bool? RequireUserPresence {
            get { return BackingStore?.Get<bool?>("requireUserPresence"); }
            set { BackingStore?.Set("requireUserPresence", value); }
        }
        /// <summary>Gets or sets the principle user name to use for this profile. The realm name does not need to be included.</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new KerberosSingleSignOnExtension CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KerberosSingleSignOnExtension();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activeDirectorySiteCode", n => { ActiveDirectorySiteCode = n.GetStringValue(); } },
                {"blockActiveDirectorySiteAutoDiscovery", n => { BlockActiveDirectorySiteAutoDiscovery = n.GetBoolValue(); } },
                {"blockAutomaticLogin", n => { BlockAutomaticLogin = n.GetBoolValue(); } },
                {"cacheName", n => { CacheName = n.GetStringValue(); } },
                {"credentialBundleIdAccessControlList", n => { CredentialBundleIdAccessControlList = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"domainRealms", n => { DomainRealms = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"domains", n => { Domains = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"isDefaultRealm", n => { IsDefaultRealm = n.GetBoolValue(); } },
                {"passwordBlockModification", n => { PasswordBlockModification = n.GetBoolValue(); } },
                {"passwordChangeUrl", n => { PasswordChangeUrl = n.GetStringValue(); } },
                {"passwordEnableLocalSync", n => { PasswordEnableLocalSync = n.GetBoolValue(); } },
                {"passwordExpirationDays", n => { PasswordExpirationDays = n.GetIntValue(); } },
                {"passwordExpirationNotificationDays", n => { PasswordExpirationNotificationDays = n.GetIntValue(); } },
                {"passwordMinimumAgeDays", n => { PasswordMinimumAgeDays = n.GetIntValue(); } },
                {"passwordMinimumLength", n => { PasswordMinimumLength = n.GetIntValue(); } },
                {"passwordPreviousPasswordBlockCount", n => { PasswordPreviousPasswordBlockCount = n.GetIntValue(); } },
                {"passwordRequireActiveDirectoryComplexity", n => { PasswordRequireActiveDirectoryComplexity = n.GetBoolValue(); } },
                {"passwordRequirementsDescription", n => { PasswordRequirementsDescription = n.GetStringValue(); } },
                {"realm", n => { Realm = n.GetStringValue(); } },
                {"requireUserPresence", n => { RequireUserPresence = n.GetBoolValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("activeDirectorySiteCode", ActiveDirectorySiteCode);
            writer.WriteBoolValue("blockActiveDirectorySiteAutoDiscovery", BlockActiveDirectorySiteAutoDiscovery);
            writer.WriteBoolValue("blockAutomaticLogin", BlockAutomaticLogin);
            writer.WriteStringValue("cacheName", CacheName);
            writer.WriteCollectionOfPrimitiveValues<string>("credentialBundleIdAccessControlList", CredentialBundleIdAccessControlList);
            writer.WriteCollectionOfPrimitiveValues<string>("domainRealms", DomainRealms);
            writer.WriteCollectionOfPrimitiveValues<string>("domains", Domains);
            writer.WriteBoolValue("isDefaultRealm", IsDefaultRealm);
            writer.WriteBoolValue("passwordBlockModification", PasswordBlockModification);
            writer.WriteStringValue("passwordChangeUrl", PasswordChangeUrl);
            writer.WriteBoolValue("passwordEnableLocalSync", PasswordEnableLocalSync);
            writer.WriteIntValue("passwordExpirationDays", PasswordExpirationDays);
            writer.WriteIntValue("passwordExpirationNotificationDays", PasswordExpirationNotificationDays);
            writer.WriteIntValue("passwordMinimumAgeDays", PasswordMinimumAgeDays);
            writer.WriteIntValue("passwordMinimumLength", PasswordMinimumLength);
            writer.WriteIntValue("passwordPreviousPasswordBlockCount", PasswordPreviousPasswordBlockCount);
            writer.WriteBoolValue("passwordRequireActiveDirectoryComplexity", PasswordRequireActiveDirectoryComplexity);
            writer.WriteStringValue("passwordRequirementsDescription", PasswordRequirementsDescription);
            writer.WriteStringValue("realm", Realm);
            writer.WriteBoolValue("requireUserPresence", RequireUserPresence);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
