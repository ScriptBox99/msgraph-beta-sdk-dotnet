using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The base class for a type of apps
    /// </summary>
    public class WindowsKioskDesktopApp : WindowsKioskAppBase, IParsable {
        /// <summary>Define the DesktopApplicationID of the app</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DesktopApplicationId {
            get { return BackingStore?.Get<string?>("desktopApplicationId"); }
            set { BackingStore?.Set("desktopApplicationId", value); }
        }
#nullable restore
#else
        public string DesktopApplicationId {
            get { return BackingStore?.Get<string>("desktopApplicationId"); }
            set { BackingStore?.Set("desktopApplicationId", value); }
        }
#endif
        /// <summary>Define the DesktopApplicationLinkPath of the app</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DesktopApplicationLinkPath {
            get { return BackingStore?.Get<string?>("desktopApplicationLinkPath"); }
            set { BackingStore?.Set("desktopApplicationLinkPath", value); }
        }
#nullable restore
#else
        public string DesktopApplicationLinkPath {
            get { return BackingStore?.Get<string>("desktopApplicationLinkPath"); }
            set { BackingStore?.Set("desktopApplicationLinkPath", value); }
        }
#endif
        /// <summary>Define the path of a desktop app</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Path {
            get { return BackingStore?.Get<string?>("path"); }
            set { BackingStore?.Set("path", value); }
        }
#nullable restore
#else
        public string Path {
            get { return BackingStore?.Get<string>("path"); }
            set { BackingStore?.Set("path", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new windowsKioskDesktopApp and sets the default values.
        /// </summary>
        public WindowsKioskDesktopApp() : base() {
            OdataType = "#microsoft.graph.windowsKioskDesktopApp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsKioskDesktopApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsKioskDesktopApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"desktopApplicationId", n => { DesktopApplicationId = n.GetStringValue(); } },
                {"desktopApplicationLinkPath", n => { DesktopApplicationLinkPath = n.GetStringValue(); } },
                {"path", n => { Path = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("desktopApplicationId", DesktopApplicationId);
            writer.WriteStringValue("desktopApplicationLinkPath", DesktopApplicationLinkPath);
            writer.WriteStringValue("path", Path);
        }
    }
}
