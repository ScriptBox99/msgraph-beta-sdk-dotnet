using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsPhone81VpnConfiguration : Windows81VpnConfiguration, IParsable {
        /// <summary>VPN Authentication Method.</summary>
        public VpnAuthenticationMethod? AuthenticationMethod {
            get { return BackingStore?.Get<VpnAuthenticationMethod?>("authenticationMethod"); }
            set { BackingStore?.Set("authenticationMethod", value); }
        }
        /// <summary>Bypass VPN on company Wi-Fi.</summary>
        public bool? BypassVpnOnCompanyWifi {
            get { return BackingStore?.Get<bool?>("bypassVpnOnCompanyWifi"); }
            set { BackingStore?.Set("bypassVpnOnCompanyWifi", value); }
        }
        /// <summary>Bypass VPN on home Wi-Fi.</summary>
        public bool? BypassVpnOnHomeWifi {
            get { return BackingStore?.Get<bool?>("bypassVpnOnHomeWifi"); }
            set { BackingStore?.Set("bypassVpnOnHomeWifi", value); }
        }
        /// <summary>DNS suffix search list.</summary>
        public List<string> DnsSuffixSearchList {
            get { return BackingStore?.Get<List<string>>("dnsSuffixSearchList"); }
            set { BackingStore?.Set("dnsSuffixSearchList", value); }
        }
        /// <summary>Identity certificate for client authentication when authentication method is certificate.</summary>
        public WindowsPhone81CertificateProfileBase IdentityCertificate {
            get { return BackingStore?.Get<WindowsPhone81CertificateProfileBase>("identityCertificate"); }
            set { BackingStore?.Set("identityCertificate", value); }
        }
        /// <summary>Remember user credentials.</summary>
        public bool? RememberUserCredentials {
            get { return BackingStore?.Get<bool?>("rememberUserCredentials"); }
            set { BackingStore?.Set("rememberUserCredentials", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsPhone81VpnConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsPhone81VpnConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"authenticationMethod", n => { AuthenticationMethod = n.GetEnumValue<VpnAuthenticationMethod>(); } },
                {"bypassVpnOnCompanyWifi", n => { BypassVpnOnCompanyWifi = n.GetBoolValue(); } },
                {"bypassVpnOnHomeWifi", n => { BypassVpnOnHomeWifi = n.GetBoolValue(); } },
                {"dnsSuffixSearchList", n => { DnsSuffixSearchList = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"identityCertificate", n => { IdentityCertificate = n.GetObjectValue<WindowsPhone81CertificateProfileBase>(WindowsPhone81CertificateProfileBase.CreateFromDiscriminatorValue); } },
                {"rememberUserCredentials", n => { RememberUserCredentials = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<VpnAuthenticationMethod>("authenticationMethod", AuthenticationMethod);
            writer.WriteBoolValue("bypassVpnOnCompanyWifi", BypassVpnOnCompanyWifi);
            writer.WriteBoolValue("bypassVpnOnHomeWifi", BypassVpnOnHomeWifi);
            writer.WriteCollectionOfPrimitiveValues<string>("dnsSuffixSearchList", DnsSuffixSearchList);
            writer.WriteObjectValue<WindowsPhone81CertificateProfileBase>("identityCertificate", IdentityCertificate);
            writer.WriteBoolValue("rememberUserCredentials", RememberUserCredentials);
        }
    }
}
