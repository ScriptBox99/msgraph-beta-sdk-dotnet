using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// intuneBrand contains data which is used in customizing the appearance of the Company Portal applications as well as the end user web portal.
    /// </summary>
    public class IntuneBrand : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Collection of blocked actions on the company portal as per platform and device ownership types.</summary>
        public List<CompanyPortalBlockedAction> CompanyPortalBlockedActions {
            get { return BackingStore?.Get<List<CompanyPortalBlockedAction>>("companyPortalBlockedActions"); }
            set { BackingStore?.Set("companyPortalBlockedActions", value); }
        }
        /// <summary>Email address of the person/organization responsible for IT support.</summary>
        public string ContactITEmailAddress {
            get { return BackingStore?.Get<string>("contactITEmailAddress"); }
            set { BackingStore?.Set("contactITEmailAddress", value); }
        }
        /// <summary>Name of the person/organization responsible for IT support.</summary>
        public string ContactITName {
            get { return BackingStore?.Get<string>("contactITName"); }
            set { BackingStore?.Set("contactITName", value); }
        }
        /// <summary>Text comments regarding the person/organization responsible for IT support.</summary>
        public string ContactITNotes {
            get { return BackingStore?.Get<string>("contactITNotes"); }
            set { BackingStore?.Set("contactITNotes", value); }
        }
        /// <summary>Phone number of the person/organization responsible for IT support.</summary>
        public string ContactITPhoneNumber {
            get { return BackingStore?.Get<string>("contactITPhoneNumber"); }
            set { BackingStore?.Set("contactITPhoneNumber", value); }
        }
        /// <summary>The custom privacy message used to explain what the organization can see and do on managed devices.</summary>
        public string CustomCanSeePrivacyMessage {
            get { return BackingStore?.Get<string>("customCanSeePrivacyMessage"); }
            set { BackingStore?.Set("customCanSeePrivacyMessage", value); }
        }
        /// <summary>The custom privacy message used to explain what the organization can’t see or do on managed devices.</summary>
        public string CustomCantSeePrivacyMessage {
            get { return BackingStore?.Get<string>("customCantSeePrivacyMessage"); }
            set { BackingStore?.Set("customCantSeePrivacyMessage", value); }
        }
        /// <summary>The custom privacy message used to explain what the organization can’t see or do on managed devices.</summary>
        public string CustomPrivacyMessage {
            get { return BackingStore?.Get<string>("customPrivacyMessage"); }
            set { BackingStore?.Set("customPrivacyMessage", value); }
        }
        /// <summary>Logo image displayed in Company Portal apps which have a dark background behind the logo.</summary>
        public MimeContent DarkBackgroundLogo {
            get { return BackingStore?.Get<MimeContent>("darkBackgroundLogo"); }
            set { BackingStore?.Set("darkBackgroundLogo", value); }
        }
        /// <summary>Applies to telemetry sent from all clients to the Intune service. When disabled, all proactive troubleshooting and issue warnings within the client are turned off, and telemetry settings appear inactive or hidden to the device user.</summary>
        public bool? DisableClientTelemetry {
            get { return BackingStore?.Get<bool?>("disableClientTelemetry"); }
            set { BackingStore?.Set("disableClientTelemetry", value); }
        }
        /// <summary>Company/organization name that is displayed to end users.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>Options available for enrollment flow customization</summary>
        public EnrollmentAvailabilityOptions? EnrollmentAvailability {
            get { return BackingStore?.Get<EnrollmentAvailabilityOptions?>("enrollmentAvailability"); }
            set { BackingStore?.Set("enrollmentAvailability", value); }
        }
        /// <summary>Boolean that represents whether the adminsistrator has disabled the &apos;Factory Reset&apos; action on corporate owned devices.</summary>
        public bool? IsFactoryResetDisabled {
            get { return BackingStore?.Get<bool?>("isFactoryResetDisabled"); }
            set { BackingStore?.Set("isFactoryResetDisabled", value); }
        }
        /// <summary>Boolean that represents whether the adminsistrator has disabled the &apos;Remove Device&apos; action on corporate owned devices.</summary>
        public bool? IsRemoveDeviceDisabled {
            get { return BackingStore?.Get<bool?>("isRemoveDeviceDisabled"); }
            set { BackingStore?.Set("isRemoveDeviceDisabled", value); }
        }
        /// <summary>Customized image displayed in Company Portal app landing page</summary>
        public MimeContent LandingPageCustomizedImage {
            get { return BackingStore?.Get<MimeContent>("landingPageCustomizedImage"); }
            set { BackingStore?.Set("landingPageCustomizedImage", value); }
        }
        /// <summary>Logo image displayed in Company Portal apps which have a light background behind the logo.</summary>
        public MimeContent LightBackgroundLogo {
            get { return BackingStore?.Get<MimeContent>("lightBackgroundLogo"); }
            set { BackingStore?.Set("lightBackgroundLogo", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Display name of the company/organization’s IT helpdesk site.</summary>
        public string OnlineSupportSiteName {
            get { return BackingStore?.Get<string>("onlineSupportSiteName"); }
            set { BackingStore?.Set("onlineSupportSiteName", value); }
        }
        /// <summary>URL to the company/organization’s IT helpdesk site.</summary>
        public string OnlineSupportSiteUrl {
            get { return BackingStore?.Get<string>("onlineSupportSiteUrl"); }
            set { BackingStore?.Set("onlineSupportSiteUrl", value); }
        }
        /// <summary>URL to the company/organization’s privacy policy.</summary>
        public string PrivacyUrl {
            get { return BackingStore?.Get<string>("privacyUrl"); }
            set { BackingStore?.Set("privacyUrl", value); }
        }
        /// <summary>List of scope tags assigned to the default branding profile</summary>
        public List<string> RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
        /// <summary>Boolean that indicates if a push notification is sent to users when their device ownership type changes from personal to corporate</summary>
        public bool? SendDeviceOwnershipChangePushNotification {
            get { return BackingStore?.Get<bool?>("sendDeviceOwnershipChangePushNotification"); }
            set { BackingStore?.Set("sendDeviceOwnershipChangePushNotification", value); }
        }
        /// <summary>Boolean that indicates if AzureAD Enterprise Apps will be shown in Company Portal</summary>
        public bool? ShowAzureADEnterpriseApps {
            get { return BackingStore?.Get<bool?>("showAzureADEnterpriseApps"); }
            set { BackingStore?.Set("showAzureADEnterpriseApps", value); }
        }
        /// <summary>Boolean that indicates if ConfigurationManagerApps will be shown in Company Portal</summary>
        public bool? ShowConfigurationManagerApps {
            get { return BackingStore?.Get<bool?>("showConfigurationManagerApps"); }
            set { BackingStore?.Set("showConfigurationManagerApps", value); }
        }
        /// <summary>Boolean that represents whether the administrator-supplied display name will be shown next to the logo image.</summary>
        public bool? ShowDisplayNameNextToLogo {
            get { return BackingStore?.Get<bool?>("showDisplayNameNextToLogo"); }
            set { BackingStore?.Set("showDisplayNameNextToLogo", value); }
        }
        /// <summary>Boolean that represents whether the administrator-supplied logo images are shown or not shown.</summary>
        public bool? ShowLogo {
            get { return BackingStore?.Get<bool?>("showLogo"); }
            set { BackingStore?.Set("showLogo", value); }
        }
        /// <summary>Boolean that represents whether the administrator-supplied display name will be shown next to the logo image.</summary>
        public bool? ShowNameNextToLogo {
            get { return BackingStore?.Get<bool?>("showNameNextToLogo"); }
            set { BackingStore?.Set("showNameNextToLogo", value); }
        }
        /// <summary>Boolean that indicates if Office WebApps will be shown in Company Portal</summary>
        public bool? ShowOfficeWebApps {
            get { return BackingStore?.Get<bool?>("showOfficeWebApps"); }
            set { BackingStore?.Set("showOfficeWebApps", value); }
        }
        /// <summary>Primary theme color used in the Company Portal applications and web portal.</summary>
        public RgbColor ThemeColor {
            get { return BackingStore?.Get<RgbColor>("themeColor"); }
            set { BackingStore?.Set("themeColor", value); }
        }
        /// <summary>
        /// Instantiates a new intuneBrand and sets the default values.
        /// </summary>
        public IntuneBrand() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static IntuneBrand CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IntuneBrand();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"companyPortalBlockedActions", n => { CompanyPortalBlockedActions = n.GetCollectionOfObjectValues<CompanyPortalBlockedAction>(CompanyPortalBlockedAction.CreateFromDiscriminatorValue)?.ToList(); } },
                {"contactITEmailAddress", n => { ContactITEmailAddress = n.GetStringValue(); } },
                {"contactITName", n => { ContactITName = n.GetStringValue(); } },
                {"contactITNotes", n => { ContactITNotes = n.GetStringValue(); } },
                {"contactITPhoneNumber", n => { ContactITPhoneNumber = n.GetStringValue(); } },
                {"customCanSeePrivacyMessage", n => { CustomCanSeePrivacyMessage = n.GetStringValue(); } },
                {"customCantSeePrivacyMessage", n => { CustomCantSeePrivacyMessage = n.GetStringValue(); } },
                {"customPrivacyMessage", n => { CustomPrivacyMessage = n.GetStringValue(); } },
                {"darkBackgroundLogo", n => { DarkBackgroundLogo = n.GetObjectValue<MimeContent>(MimeContent.CreateFromDiscriminatorValue); } },
                {"disableClientTelemetry", n => { DisableClientTelemetry = n.GetBoolValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"enrollmentAvailability", n => { EnrollmentAvailability = n.GetEnumValue<EnrollmentAvailabilityOptions>(); } },
                {"isFactoryResetDisabled", n => { IsFactoryResetDisabled = n.GetBoolValue(); } },
                {"isRemoveDeviceDisabled", n => { IsRemoveDeviceDisabled = n.GetBoolValue(); } },
                {"landingPageCustomizedImage", n => { LandingPageCustomizedImage = n.GetObjectValue<MimeContent>(MimeContent.CreateFromDiscriminatorValue); } },
                {"lightBackgroundLogo", n => { LightBackgroundLogo = n.GetObjectValue<MimeContent>(MimeContent.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"onlineSupportSiteName", n => { OnlineSupportSiteName = n.GetStringValue(); } },
                {"onlineSupportSiteUrl", n => { OnlineSupportSiteUrl = n.GetStringValue(); } },
                {"privacyUrl", n => { PrivacyUrl = n.GetStringValue(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"sendDeviceOwnershipChangePushNotification", n => { SendDeviceOwnershipChangePushNotification = n.GetBoolValue(); } },
                {"showAzureADEnterpriseApps", n => { ShowAzureADEnterpriseApps = n.GetBoolValue(); } },
                {"showConfigurationManagerApps", n => { ShowConfigurationManagerApps = n.GetBoolValue(); } },
                {"showDisplayNameNextToLogo", n => { ShowDisplayNameNextToLogo = n.GetBoolValue(); } },
                {"showLogo", n => { ShowLogo = n.GetBoolValue(); } },
                {"showNameNextToLogo", n => { ShowNameNextToLogo = n.GetBoolValue(); } },
                {"showOfficeWebApps", n => { ShowOfficeWebApps = n.GetBoolValue(); } },
                {"themeColor", n => { ThemeColor = n.GetObjectValue<RgbColor>(RgbColor.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<CompanyPortalBlockedAction>("companyPortalBlockedActions", CompanyPortalBlockedActions);
            writer.WriteStringValue("contactITEmailAddress", ContactITEmailAddress);
            writer.WriteStringValue("contactITName", ContactITName);
            writer.WriteStringValue("contactITNotes", ContactITNotes);
            writer.WriteStringValue("contactITPhoneNumber", ContactITPhoneNumber);
            writer.WriteStringValue("customCanSeePrivacyMessage", CustomCanSeePrivacyMessage);
            writer.WriteStringValue("customCantSeePrivacyMessage", CustomCantSeePrivacyMessage);
            writer.WriteStringValue("customPrivacyMessage", CustomPrivacyMessage);
            writer.WriteObjectValue<MimeContent>("darkBackgroundLogo", DarkBackgroundLogo);
            writer.WriteBoolValue("disableClientTelemetry", DisableClientTelemetry);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<EnrollmentAvailabilityOptions>("enrollmentAvailability", EnrollmentAvailability);
            writer.WriteBoolValue("isFactoryResetDisabled", IsFactoryResetDisabled);
            writer.WriteBoolValue("isRemoveDeviceDisabled", IsRemoveDeviceDisabled);
            writer.WriteObjectValue<MimeContent>("landingPageCustomizedImage", LandingPageCustomizedImage);
            writer.WriteObjectValue<MimeContent>("lightBackgroundLogo", LightBackgroundLogo);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("onlineSupportSiteName", OnlineSupportSiteName);
            writer.WriteStringValue("onlineSupportSiteUrl", OnlineSupportSiteUrl);
            writer.WriteStringValue("privacyUrl", PrivacyUrl);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteBoolValue("sendDeviceOwnershipChangePushNotification", SendDeviceOwnershipChangePushNotification);
            writer.WriteBoolValue("showAzureADEnterpriseApps", ShowAzureADEnterpriseApps);
            writer.WriteBoolValue("showConfigurationManagerApps", ShowConfigurationManagerApps);
            writer.WriteBoolValue("showDisplayNameNextToLogo", ShowDisplayNameNextToLogo);
            writer.WriteBoolValue("showLogo", ShowLogo);
            writer.WriteBoolValue("showNameNextToLogo", ShowNameNextToLogo);
            writer.WriteBoolValue("showOfficeWebApps", ShowOfficeWebApps);
            writer.WriteObjectValue<RgbColor>("themeColor", ThemeColor);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
