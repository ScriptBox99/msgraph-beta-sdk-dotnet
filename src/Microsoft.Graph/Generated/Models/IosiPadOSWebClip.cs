using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Contains properties and inherited properties for iOS web apps.
    /// </summary>
    public class IosiPadOSWebClip : MobileApp, IParsable {
        /// <summary>Indicates iOS/iPadOS web clip app URL. Example: &apos;https://www.contoso.com&apos;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppUrl {
            get { return BackingStore?.Get<string?>("appUrl"); }
            set { BackingStore?.Set("appUrl", value); }
        }
#nullable restore
#else
        public string AppUrl {
            get { return BackingStore?.Get<string>("appUrl"); }
            set { BackingStore?.Set("appUrl", value); }
        }
#endif
        /// <summary>Whether or not to open the web clip as a full-screen web app. Defaults to false. If TRUE, opens the web clip as a full-screen web app. If FALSE, the web clip opens inside of another app, such as Safari or the app specified with targetApplicationBundleIdentifier.</summary>
        public bool? FullScreenEnabled {
            get { return BackingStore?.Get<bool?>("fullScreenEnabled"); }
            set { BackingStore?.Set("fullScreenEnabled", value); }
        }
        /// <summary>Whether or not a full screen web clip can navigate to an external web site without showing the Safari UI. Defaults to false. If FALSE, the Safari UI appears when navigating away. If TRUE, the Safari UI will not be shown.</summary>
        public bool? IgnoreManifestScope {
            get { return BackingStore?.Get<bool?>("ignoreManifestScope"); }
            set { BackingStore?.Set("ignoreManifestScope", value); }
        }
        /// <summary>Whether or not the icon for the app is precomosed. Defaults to false. If TRUE, prevents SpringBoard from adding &apos;shine&apos; to the icon. If FALSE, SpringBoard can add &apos;shine&apos;.</summary>
        public bool? PreComposedIconEnabled {
            get { return BackingStore?.Get<bool?>("preComposedIconEnabled"); }
            set { BackingStore?.Set("preComposedIconEnabled", value); }
        }
        /// <summary>Specifies the application bundle identifier which opens the URL. Available in iOS 14 and later.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetApplicationBundleIdentifier {
            get { return BackingStore?.Get<string?>("targetApplicationBundleIdentifier"); }
            set { BackingStore?.Set("targetApplicationBundleIdentifier", value); }
        }
#nullable restore
#else
        public string TargetApplicationBundleIdentifier {
            get { return BackingStore?.Get<string>("targetApplicationBundleIdentifier"); }
            set { BackingStore?.Set("targetApplicationBundleIdentifier", value); }
        }
#endif
        /// <summary>Whether or not to use managed browser. When TRUE, the app will be required to be opened in Microsoft Edge. When FALSE, the app will not be required to be opened in Microsoft Edge. By default, this property is set to FALSE.</summary>
        public bool? UseManagedBrowser {
            get { return BackingStore?.Get<bool?>("useManagedBrowser"); }
            set { BackingStore?.Set("useManagedBrowser", value); }
        }
        /// <summary>
        /// Instantiates a new iosiPadOSWebClip and sets the default values.
        /// </summary>
        public IosiPadOSWebClip() : base() {
            OdataType = "#microsoft.graph.iosiPadOSWebClip";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IosiPadOSWebClip CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosiPadOSWebClip();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appUrl", n => { AppUrl = n.GetStringValue(); } },
                {"fullScreenEnabled", n => { FullScreenEnabled = n.GetBoolValue(); } },
                {"ignoreManifestScope", n => { IgnoreManifestScope = n.GetBoolValue(); } },
                {"preComposedIconEnabled", n => { PreComposedIconEnabled = n.GetBoolValue(); } },
                {"targetApplicationBundleIdentifier", n => { TargetApplicationBundleIdentifier = n.GetStringValue(); } },
                {"useManagedBrowser", n => { UseManagedBrowser = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appUrl", AppUrl);
            writer.WriteBoolValue("fullScreenEnabled", FullScreenEnabled);
            writer.WriteBoolValue("ignoreManifestScope", IgnoreManifestScope);
            writer.WriteBoolValue("preComposedIconEnabled", PreComposedIconEnabled);
            writer.WriteStringValue("targetApplicationBundleIdentifier", TargetApplicationBundleIdentifier);
            writer.WriteBoolValue("useManagedBrowser", UseManagedBrowser);
        }
    }
}
