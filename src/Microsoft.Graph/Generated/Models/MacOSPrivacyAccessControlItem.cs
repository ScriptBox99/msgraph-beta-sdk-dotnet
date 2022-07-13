using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Represents per-process privacy preferences.</summary>
    public class MacOSPrivacyAccessControlItem : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Possible values of a property</summary>
        public Enablement? Accessibility {
            get { return BackingStore?.Get<Enablement?>("accessibility"); }
            set { BackingStore?.Set("accessibility", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? AddressBook {
            get { return BackingStore?.Get<Enablement?>("addressBook"); }
            set { BackingStore?.Set("addressBook", value); }
        }
        /// <summary>Allow or deny the app or process to send a restricted Apple event to another app or process. You will need to know the identifier, identifier type, and code requirement of the receiving app or process. This collection can contain a maximum of 500 elements.</summary>
        public List<MacOSAppleEventReceiver> AppleEventsAllowedReceivers {
            get { return BackingStore?.Get<List<MacOSAppleEventReceiver>>("appleEventsAllowedReceivers"); }
            set { BackingStore?.Set("appleEventsAllowedReceivers", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Block access to camera app.</summary>
        public bool? BlockCamera {
            get { return BackingStore?.Get<bool?>("blockCamera"); }
            set { BackingStore?.Set("blockCamera", value); }
        }
        /// <summary>Block the app or process from listening to events from input devices such as mouse, keyboard, and trackpad.Requires macOS 10.15 or later.</summary>
        public bool? BlockListenEvent {
            get { return BackingStore?.Get<bool?>("blockListenEvent"); }
            set { BackingStore?.Set("blockListenEvent", value); }
        }
        /// <summary>Block access to microphone.</summary>
        public bool? BlockMicrophone {
            get { return BackingStore?.Get<bool?>("blockMicrophone"); }
            set { BackingStore?.Set("blockMicrophone", value); }
        }
        /// <summary>Block app from capturing contents of system display. Requires macOS 10.15 or later.</summary>
        public bool? BlockScreenCapture {
            get { return BackingStore?.Get<bool?>("blockScreenCapture"); }
            set { BackingStore?.Set("blockScreenCapture", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? Calendar {
            get { return BackingStore?.Get<Enablement?>("calendar"); }
            set { BackingStore?.Set("calendar", value); }
        }
        /// <summary>Enter the code requirement, which can be obtained with the command &apos;codesign –display -r –&apos; in the Terminal app. Include everything after &apos;=&gt;&apos;.</summary>
        public string CodeRequirement {
            get { return BackingStore?.Get<string>("codeRequirement"); }
            set { BackingStore?.Set("codeRequirement", value); }
        }
        /// <summary>The display name of the app, process, or executable.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? FileProviderPresence {
            get { return BackingStore?.Get<Enablement?>("fileProviderPresence"); }
            set { BackingStore?.Set("fileProviderPresence", value); }
        }
        /// <summary>The bundle ID or path of the app, process, or executable.</summary>
        public string Identifier {
            get { return BackingStore?.Get<string>("identifier"); }
            set { BackingStore?.Set("identifier", value); }
        }
        /// <summary>Process identifier types for MacOS Privacy Preferences</summary>
        public MacOSProcessIdentifierType? IdentifierType {
            get { return BackingStore?.Get<MacOSProcessIdentifierType?>("identifierType"); }
            set { BackingStore?.Set("identifierType", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? MediaLibrary {
            get { return BackingStore?.Get<Enablement?>("mediaLibrary"); }
            set { BackingStore?.Set("mediaLibrary", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? Photos {
            get { return BackingStore?.Get<Enablement?>("photos"); }
            set { BackingStore?.Set("photos", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? PostEvent {
            get { return BackingStore?.Get<Enablement?>("postEvent"); }
            set { BackingStore?.Set("postEvent", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? Reminders {
            get { return BackingStore?.Get<Enablement?>("reminders"); }
            set { BackingStore?.Set("reminders", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? SpeechRecognition {
            get { return BackingStore?.Get<Enablement?>("speechRecognition"); }
            set { BackingStore?.Set("speechRecognition", value); }
        }
        /// <summary>Statically validates the code requirement. Use this setting if the process invalidates its dynamic code signature.</summary>
        public bool? StaticCodeValidation {
            get { return BackingStore?.Get<bool?>("staticCodeValidation"); }
            set { BackingStore?.Set("staticCodeValidation", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? SystemPolicyAllFiles {
            get { return BackingStore?.Get<Enablement?>("systemPolicyAllFiles"); }
            set { BackingStore?.Set("systemPolicyAllFiles", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? SystemPolicyDesktopFolder {
            get { return BackingStore?.Get<Enablement?>("systemPolicyDesktopFolder"); }
            set { BackingStore?.Set("systemPolicyDesktopFolder", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? SystemPolicyDocumentsFolder {
            get { return BackingStore?.Get<Enablement?>("systemPolicyDocumentsFolder"); }
            set { BackingStore?.Set("systemPolicyDocumentsFolder", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? SystemPolicyDownloadsFolder {
            get { return BackingStore?.Get<Enablement?>("systemPolicyDownloadsFolder"); }
            set { BackingStore?.Set("systemPolicyDownloadsFolder", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? SystemPolicyNetworkVolumes {
            get { return BackingStore?.Get<Enablement?>("systemPolicyNetworkVolumes"); }
            set { BackingStore?.Set("systemPolicyNetworkVolumes", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? SystemPolicyRemovableVolumes {
            get { return BackingStore?.Get<Enablement?>("systemPolicyRemovableVolumes"); }
            set { BackingStore?.Set("systemPolicyRemovableVolumes", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? SystemPolicySystemAdminFiles {
            get { return BackingStore?.Get<Enablement?>("systemPolicySystemAdminFiles"); }
            set { BackingStore?.Set("systemPolicySystemAdminFiles", value); }
        }
        /// <summary>
        /// Instantiates a new macOSPrivacyAccessControlItem and sets the default values.
        /// </summary>
        public MacOSPrivacyAccessControlItem() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MacOSPrivacyAccessControlItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSPrivacyAccessControlItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"accessibility", n => { Accessibility = n.GetEnumValue<Enablement>(); } },
                {"addressBook", n => { AddressBook = n.GetEnumValue<Enablement>(); } },
                {"appleEventsAllowedReceivers", n => { AppleEventsAllowedReceivers = n.GetCollectionOfObjectValues<MacOSAppleEventReceiver>(MacOSAppleEventReceiver.CreateFromDiscriminatorValue).ToList(); } },
                {"blockCamera", n => { BlockCamera = n.GetBoolValue(); } },
                {"blockListenEvent", n => { BlockListenEvent = n.GetBoolValue(); } },
                {"blockMicrophone", n => { BlockMicrophone = n.GetBoolValue(); } },
                {"blockScreenCapture", n => { BlockScreenCapture = n.GetBoolValue(); } },
                {"calendar", n => { Calendar = n.GetEnumValue<Enablement>(); } },
                {"codeRequirement", n => { CodeRequirement = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"fileProviderPresence", n => { FileProviderPresence = n.GetEnumValue<Enablement>(); } },
                {"identifier", n => { Identifier = n.GetStringValue(); } },
                {"identifierType", n => { IdentifierType = n.GetEnumValue<MacOSProcessIdentifierType>(); } },
                {"mediaLibrary", n => { MediaLibrary = n.GetEnumValue<Enablement>(); } },
                {"photos", n => { Photos = n.GetEnumValue<Enablement>(); } },
                {"postEvent", n => { PostEvent = n.GetEnumValue<Enablement>(); } },
                {"reminders", n => { Reminders = n.GetEnumValue<Enablement>(); } },
                {"speechRecognition", n => { SpeechRecognition = n.GetEnumValue<Enablement>(); } },
                {"staticCodeValidation", n => { StaticCodeValidation = n.GetBoolValue(); } },
                {"systemPolicyAllFiles", n => { SystemPolicyAllFiles = n.GetEnumValue<Enablement>(); } },
                {"systemPolicyDesktopFolder", n => { SystemPolicyDesktopFolder = n.GetEnumValue<Enablement>(); } },
                {"systemPolicyDocumentsFolder", n => { SystemPolicyDocumentsFolder = n.GetEnumValue<Enablement>(); } },
                {"systemPolicyDownloadsFolder", n => { SystemPolicyDownloadsFolder = n.GetEnumValue<Enablement>(); } },
                {"systemPolicyNetworkVolumes", n => { SystemPolicyNetworkVolumes = n.GetEnumValue<Enablement>(); } },
                {"systemPolicyRemovableVolumes", n => { SystemPolicyRemovableVolumes = n.GetEnumValue<Enablement>(); } },
                {"systemPolicySystemAdminFiles", n => { SystemPolicySystemAdminFiles = n.GetEnumValue<Enablement>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<Enablement>("accessibility", Accessibility);
            writer.WriteEnumValue<Enablement>("addressBook", AddressBook);
            writer.WriteCollectionOfObjectValues<MacOSAppleEventReceiver>("appleEventsAllowedReceivers", AppleEventsAllowedReceivers);
            writer.WriteBoolValue("blockCamera", BlockCamera);
            writer.WriteBoolValue("blockListenEvent", BlockListenEvent);
            writer.WriteBoolValue("blockMicrophone", BlockMicrophone);
            writer.WriteBoolValue("blockScreenCapture", BlockScreenCapture);
            writer.WriteEnumValue<Enablement>("calendar", Calendar);
            writer.WriteStringValue("codeRequirement", CodeRequirement);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<Enablement>("fileProviderPresence", FileProviderPresence);
            writer.WriteStringValue("identifier", Identifier);
            writer.WriteEnumValue<MacOSProcessIdentifierType>("identifierType", IdentifierType);
            writer.WriteEnumValue<Enablement>("mediaLibrary", MediaLibrary);
            writer.WriteEnumValue<Enablement>("photos", Photos);
            writer.WriteEnumValue<Enablement>("postEvent", PostEvent);
            writer.WriteEnumValue<Enablement>("reminders", Reminders);
            writer.WriteEnumValue<Enablement>("speechRecognition", SpeechRecognition);
            writer.WriteBoolValue("staticCodeValidation", StaticCodeValidation);
            writer.WriteEnumValue<Enablement>("systemPolicyAllFiles", SystemPolicyAllFiles);
            writer.WriteEnumValue<Enablement>("systemPolicyDesktopFolder", SystemPolicyDesktopFolder);
            writer.WriteEnumValue<Enablement>("systemPolicyDocumentsFolder", SystemPolicyDocumentsFolder);
            writer.WriteEnumValue<Enablement>("systemPolicyDownloadsFolder", SystemPolicyDownloadsFolder);
            writer.WriteEnumValue<Enablement>("systemPolicyNetworkVolumes", SystemPolicyNetworkVolumes);
            writer.WriteEnumValue<Enablement>("systemPolicyRemovableVolumes", SystemPolicyRemovableVolumes);
            writer.WriteEnumValue<Enablement>("systemPolicySystemAdminFiles", SystemPolicySystemAdminFiles);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
