using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Contains PowerShell script properties to detect a Win32 App
    /// </summary>
    public class Win32LobAppPowerShellScriptDetection : Win32LobAppDetection, IParsable {
        /// <summary>A value indicating whether signature check is enforced</summary>
        public bool? EnforceSignatureCheck {
            get { return BackingStore?.Get<bool?>("enforceSignatureCheck"); }
            set { BackingStore?.Set("enforceSignatureCheck", value); }
        }
        /// <summary>A value indicating whether this script should run as 32-bit</summary>
        public bool? RunAs32Bit {
            get { return BackingStore?.Get<bool?>("runAs32Bit"); }
            set { BackingStore?.Set("runAs32Bit", value); }
        }
        /// <summary>The base64 encoded script content to detect Win32 Line of Business (LoB) app</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ScriptContent {
            get { return BackingStore?.Get<string?>("scriptContent"); }
            set { BackingStore?.Set("scriptContent", value); }
        }
#nullable restore
#else
        public string ScriptContent {
            get { return BackingStore?.Get<string>("scriptContent"); }
            set { BackingStore?.Set("scriptContent", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new win32LobAppPowerShellScriptDetection and sets the default values.
        /// </summary>
        public Win32LobAppPowerShellScriptDetection() : base() {
            OdataType = "#microsoft.graph.win32LobAppPowerShellScriptDetection";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Win32LobAppPowerShellScriptDetection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Win32LobAppPowerShellScriptDetection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"enforceSignatureCheck", n => { EnforceSignatureCheck = n.GetBoolValue(); } },
                {"runAs32Bit", n => { RunAs32Bit = n.GetBoolValue(); } },
                {"scriptContent", n => { ScriptContent = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("enforceSignatureCheck", EnforceSignatureCheck);
            writer.WriteBoolValue("runAs32Bit", RunAs32Bit);
            writer.WriteStringValue("scriptContent", ScriptContent);
        }
    }
}
