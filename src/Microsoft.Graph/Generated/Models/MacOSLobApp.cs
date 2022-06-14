using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MacOSLobApp : MobileLobApp, IParsable {
        /// <summary>The build number of MacOS Line of Business (LoB) app.</summary>
        public string BuildNumber {
            get { return BackingStore?.Get<string>(nameof(BuildNumber)); }
            set { BackingStore?.Set(nameof(BuildNumber), value); }
        }
        /// <summary>The bundle id.</summary>
        public string BundleId {
            get { return BackingStore?.Get<string>(nameof(BundleId)); }
            set { BackingStore?.Set(nameof(BundleId), value); }
        }
        /// <summary>The app list in this bundle package</summary>
        public List<MacOSLobChildApp> ChildApps {
            get { return BackingStore?.Get<List<MacOSLobChildApp>>(nameof(ChildApps)); }
            set { BackingStore?.Set(nameof(ChildApps), value); }
        }
        /// <summary>The identity version.</summary>
        public string IdentityVersion {
            get { return BackingStore?.Get<string>(nameof(IdentityVersion)); }
            set { BackingStore?.Set(nameof(IdentityVersion), value); }
        }
        /// <summary>A boolean to control whether the app&apos;s version will be used to detect the app after it is installed on a device. Set this to true for macOS Line of Business (LoB) apps that use a self update feature.</summary>
        public bool? IgnoreVersionDetection {
            get { return BackingStore?.Get<bool?>(nameof(IgnoreVersionDetection)); }
            set { BackingStore?.Set(nameof(IgnoreVersionDetection), value); }
        }
        /// <summary>A boolean to control whether the app will be installed as managed (requires macOS 11.0 and other PKG restrictions).</summary>
        public bool? InstallAsManaged {
            get { return BackingStore?.Get<bool?>(nameof(InstallAsManaged)); }
            set { BackingStore?.Set(nameof(InstallAsManaged), value); }
        }
        /// <summary>The MD5 hash codes</summary>
        public List<string> Md5Hash {
            get { return BackingStore?.Get<List<string>>(nameof(Md5Hash)); }
            set { BackingStore?.Set(nameof(Md5Hash), value); }
        }
        /// <summary>The chunk size for MD5 hash</summary>
        public int? Md5HashChunkSize {
            get { return BackingStore?.Get<int?>(nameof(Md5HashChunkSize)); }
            set { BackingStore?.Set(nameof(Md5HashChunkSize), value); }
        }
        /// <summary>The value for the minimum applicable operating system.</summary>
        public MacOSMinimumOperatingSystem MinimumSupportedOperatingSystem {
            get { return BackingStore?.Get<MacOSMinimumOperatingSystem>(nameof(MinimumSupportedOperatingSystem)); }
            set { BackingStore?.Set(nameof(MinimumSupportedOperatingSystem), value); }
        }
        /// <summary>The version number of MacOS Line of Business (LoB) app.</summary>
        public string VersionNumber {
            get { return BackingStore?.Get<string>(nameof(VersionNumber)); }
            set { BackingStore?.Set(nameof(VersionNumber), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MacOSLobApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSLobApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"buildNumber", n => { BuildNumber = n.GetStringValue(); } },
                {"bundleId", n => { BundleId = n.GetStringValue(); } },
                {"childApps", n => { ChildApps = n.GetCollectionOfObjectValues<MacOSLobChildApp>(MacOSLobChildApp.CreateFromDiscriminatorValue).ToList(); } },
                {"identityVersion", n => { IdentityVersion = n.GetStringValue(); } },
                {"ignoreVersionDetection", n => { IgnoreVersionDetection = n.GetBoolValue(); } },
                {"installAsManaged", n => { InstallAsManaged = n.GetBoolValue(); } },
                {"md5Hash", n => { Md5Hash = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"md5HashChunkSize", n => { Md5HashChunkSize = n.GetIntValue(); } },
                {"minimumSupportedOperatingSystem", n => { MinimumSupportedOperatingSystem = n.GetObjectValue<MacOSMinimumOperatingSystem>(MacOSMinimumOperatingSystem.CreateFromDiscriminatorValue); } },
                {"versionNumber", n => { VersionNumber = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("buildNumber", BuildNumber);
            writer.WriteStringValue("bundleId", BundleId);
            writer.WriteCollectionOfObjectValues<MacOSLobChildApp>("childApps", ChildApps);
            writer.WriteStringValue("identityVersion", IdentityVersion);
            writer.WriteBoolValue("ignoreVersionDetection", IgnoreVersionDetection);
            writer.WriteBoolValue("installAsManaged", InstallAsManaged);
            writer.WriteCollectionOfPrimitiveValues<string>("md5Hash", Md5Hash);
            writer.WriteIntValue("md5HashChunkSize", Md5HashChunkSize);
            writer.WriteObjectValue<MacOSMinimumOperatingSystem>("minimumSupportedOperatingSystem", MinimumSupportedOperatingSystem);
            writer.WriteStringValue("versionNumber", VersionNumber);
        }
    }
}
