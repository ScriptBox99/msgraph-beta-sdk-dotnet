using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// By providing the configurations in this profile you can instruct the Windows 8.1 (and later) devices to connect to desired VPN endpoint. By specifying the authentication method and security types expected by VPN endpoint you can make the VPN connection seamless for end user.
    /// </summary>
    public class Windows81VpnConfiguration : WindowsVpnConfiguration, IParsable {
        /// <summary>Value indicating whether this policy only applies to Windows 8.1. This property is read-only.</summary>
        public bool? ApplyOnlyToWindows81 {
            get { return BackingStore?.Get<bool?>("applyOnlyToWindows81"); }
            set { BackingStore?.Set("applyOnlyToWindows81", value); }
        }
        /// <summary>Windows VPN connection type.</summary>
        public WindowsVpnConnectionType? ConnectionType {
            get { return BackingStore?.Get<WindowsVpnConnectionType?>("connectionType"); }
            set { BackingStore?.Set("connectionType", value); }
        }
        /// <summary>Enable split tunneling for the VPN.</summary>
        public bool? EnableSplitTunneling {
            get { return BackingStore?.Get<bool?>("enableSplitTunneling"); }
            set { BackingStore?.Set("enableSplitTunneling", value); }
        }
        /// <summary>Login group or domain when connection type is set to Dell SonicWALL Mobile Connection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LoginGroupOrDomain {
            get { return BackingStore?.Get<string?>("loginGroupOrDomain"); }
            set { BackingStore?.Set("loginGroupOrDomain", value); }
        }
#nullable restore
#else
        public string LoginGroupOrDomain {
            get { return BackingStore?.Get<string>("loginGroupOrDomain"); }
            set { BackingStore?.Set("loginGroupOrDomain", value); }
        }
#endif
        /// <summary>Proxy Server.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Windows81VpnProxyServer? ProxyServer {
            get { return BackingStore?.Get<Windows81VpnProxyServer?>("proxyServer"); }
            set { BackingStore?.Set("proxyServer", value); }
        }
#nullable restore
#else
        public Windows81VpnProxyServer ProxyServer {
            get { return BackingStore?.Get<Windows81VpnProxyServer>("proxyServer"); }
            set { BackingStore?.Set("proxyServer", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new windows81VpnConfiguration and sets the default values.
        /// </summary>
        public Windows81VpnConfiguration() : base() {
            OdataType = "#microsoft.graph.windows81VpnConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Windows81VpnConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.windowsPhone81VpnConfiguration" => new WindowsPhone81VpnConfiguration(),
                _ => new Windows81VpnConfiguration(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applyOnlyToWindows81", n => { ApplyOnlyToWindows81 = n.GetBoolValue(); } },
                {"connectionType", n => { ConnectionType = n.GetEnumValue<WindowsVpnConnectionType>(); } },
                {"enableSplitTunneling", n => { EnableSplitTunneling = n.GetBoolValue(); } },
                {"loginGroupOrDomain", n => { LoginGroupOrDomain = n.GetStringValue(); } },
                {"proxyServer", n => { ProxyServer = n.GetObjectValue<Windows81VpnProxyServer>(Windows81VpnProxyServer.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<WindowsVpnConnectionType>("connectionType", ConnectionType);
            writer.WriteBoolValue("enableSplitTunneling", EnableSplitTunneling);
            writer.WriteStringValue("loginGroupOrDomain", LoginGroupOrDomain);
            writer.WriteObjectValue<Windows81VpnProxyServer>("proxyServer", ProxyServer);
        }
    }
}
