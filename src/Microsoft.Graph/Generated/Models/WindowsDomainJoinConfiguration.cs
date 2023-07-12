using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Windows Domain Join device configuration.
    /// </summary>
    public class WindowsDomainJoinConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Active Directory domain name to join.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActiveDirectoryDomainName {
            get { return BackingStore?.Get<string?>("activeDirectoryDomainName"); }
            set { BackingStore?.Set("activeDirectoryDomainName", value); }
        }
#nullable restore
#else
        public string ActiveDirectoryDomainName {
            get { return BackingStore?.Get<string>("activeDirectoryDomainName"); }
            set { BackingStore?.Set("activeDirectoryDomainName", value); }
        }
#endif
        /// <summary>Fixed prefix to be used for computer name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ComputerNameStaticPrefix {
            get { return BackingStore?.Get<string?>("computerNameStaticPrefix"); }
            set { BackingStore?.Set("computerNameStaticPrefix", value); }
        }
#nullable restore
#else
        public string ComputerNameStaticPrefix {
            get { return BackingStore?.Get<string>("computerNameStaticPrefix"); }
            set { BackingStore?.Set("computerNameStaticPrefix", value); }
        }
#endif
        /// <summary>Dynamically generated characters used as suffix for computer name. Valid values 3 to 14</summary>
        public int? ComputerNameSuffixRandomCharCount {
            get { return BackingStore?.Get<int?>("computerNameSuffixRandomCharCount"); }
            set { BackingStore?.Set("computerNameSuffixRandomCharCount", value); }
        }
        /// <summary>Reference to device configurations required for network connectivity</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceConfiguration>? NetworkAccessConfigurations {
            get { return BackingStore?.Get<List<DeviceConfiguration>?>("networkAccessConfigurations"); }
            set { BackingStore?.Set("networkAccessConfigurations", value); }
        }
#nullable restore
#else
        public List<DeviceConfiguration> NetworkAccessConfigurations {
            get { return BackingStore?.Get<List<DeviceConfiguration>>("networkAccessConfigurations"); }
            set { BackingStore?.Set("networkAccessConfigurations", value); }
        }
#endif
        /// <summary>Organizational unit (OU) where the computer account will be created. If this parameter is NULL, the well known computer object container will be used as published in the domain.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrganizationalUnit {
            get { return BackingStore?.Get<string?>("organizationalUnit"); }
            set { BackingStore?.Set("organizationalUnit", value); }
        }
#nullable restore
#else
        public string OrganizationalUnit {
            get { return BackingStore?.Get<string>("organizationalUnit"); }
            set { BackingStore?.Set("organizationalUnit", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new windowsDomainJoinConfiguration and sets the default values.
        /// </summary>
        public WindowsDomainJoinConfiguration() : base() {
            OdataType = "#microsoft.graph.windowsDomainJoinConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsDomainJoinConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsDomainJoinConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activeDirectoryDomainName", n => { ActiveDirectoryDomainName = n.GetStringValue(); } },
                {"computerNameStaticPrefix", n => { ComputerNameStaticPrefix = n.GetStringValue(); } },
                {"computerNameSuffixRandomCharCount", n => { ComputerNameSuffixRandomCharCount = n.GetIntValue(); } },
                {"networkAccessConfigurations", n => { NetworkAccessConfigurations = n.GetCollectionOfObjectValues<DeviceConfiguration>(DeviceConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"organizationalUnit", n => { OrganizationalUnit = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("activeDirectoryDomainName", ActiveDirectoryDomainName);
            writer.WriteStringValue("computerNameStaticPrefix", ComputerNameStaticPrefix);
            writer.WriteIntValue("computerNameSuffixRandomCharCount", ComputerNameSuffixRandomCharCount);
            writer.WriteCollectionOfObjectValues<DeviceConfiguration>("networkAccessConfigurations", NetworkAccessConfigurations);
            writer.WriteStringValue("organizationalUnit", OrganizationalUnit);
        }
    }
}
