using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Windows10DeviceFirmwareConfigurationInterface : DeviceConfiguration, IParsable {
        /// <summary>Possible values of a property</summary>
        public Enablement? Bluetooth {
            get { return BackingStore?.Get<Enablement?>("bluetooth"); }
            set { BackingStore?.Set("bluetooth", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? BootFromBuiltInNetworkAdapters {
            get { return BackingStore?.Get<Enablement?>("bootFromBuiltInNetworkAdapters"); }
            set { BackingStore?.Set("bootFromBuiltInNetworkAdapters", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? BootFromExternalMedia {
            get { return BackingStore?.Get<Enablement?>("bootFromExternalMedia"); }
            set { BackingStore?.Set("bootFromExternalMedia", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? Cameras {
            get { return BackingStore?.Get<Enablement?>("cameras"); }
            set { BackingStore?.Set("cameras", value); }
        }
        /// <summary>Defines the permission level granted to users to enable them change Uefi settings</summary>
        public Microsoft.Graph.Beta.Models.ChangeUefiSettingsPermission? ChangeUefiSettingsPermission {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ChangeUefiSettingsPermission?>("changeUefiSettingsPermission"); }
            set { BackingStore?.Set("changeUefiSettingsPermission", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? FrontCamera {
            get { return BackingStore?.Get<Enablement?>("frontCamera"); }
            set { BackingStore?.Set("frontCamera", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? InfraredCamera {
            get { return BackingStore?.Get<Enablement?>("infraredCamera"); }
            set { BackingStore?.Set("infraredCamera", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? Microphone {
            get { return BackingStore?.Get<Enablement?>("microphone"); }
            set { BackingStore?.Set("microphone", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? MicrophonesAndSpeakers {
            get { return BackingStore?.Get<Enablement?>("microphonesAndSpeakers"); }
            set { BackingStore?.Set("microphonesAndSpeakers", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? NearFieldCommunication {
            get { return BackingStore?.Get<Enablement?>("nearFieldCommunication"); }
            set { BackingStore?.Set("nearFieldCommunication", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? Radios {
            get { return BackingStore?.Get<Enablement?>("radios"); }
            set { BackingStore?.Set("radios", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? RearCamera {
            get { return BackingStore?.Get<Enablement?>("rearCamera"); }
            set { BackingStore?.Set("rearCamera", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? SdCard {
            get { return BackingStore?.Get<Enablement?>("sdCard"); }
            set { BackingStore?.Set("sdCard", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? SimultaneousMultiThreading {
            get { return BackingStore?.Get<Enablement?>("simultaneousMultiThreading"); }
            set { BackingStore?.Set("simultaneousMultiThreading", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? UsbTypeAPort {
            get { return BackingStore?.Get<Enablement?>("usbTypeAPort"); }
            set { BackingStore?.Set("usbTypeAPort", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? VirtualizationOfCpuAndIO {
            get { return BackingStore?.Get<Enablement?>("virtualizationOfCpuAndIO"); }
            set { BackingStore?.Set("virtualizationOfCpuAndIO", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? WakeOnLAN {
            get { return BackingStore?.Get<Enablement?>("wakeOnLAN"); }
            set { BackingStore?.Set("wakeOnLAN", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? WakeOnPower {
            get { return BackingStore?.Get<Enablement?>("wakeOnPower"); }
            set { BackingStore?.Set("wakeOnPower", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? WiFi {
            get { return BackingStore?.Get<Enablement?>("wiFi"); }
            set { BackingStore?.Set("wiFi", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? WindowsPlatformBinaryTable {
            get { return BackingStore?.Get<Enablement?>("windowsPlatformBinaryTable"); }
            set { BackingStore?.Set("windowsPlatformBinaryTable", value); }
        }
        /// <summary>Possible values of a property</summary>
        public Enablement? WirelessWideAreaNetwork {
            get { return BackingStore?.Get<Enablement?>("wirelessWideAreaNetwork"); }
            set { BackingStore?.Set("wirelessWideAreaNetwork", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Windows10DeviceFirmwareConfigurationInterface CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows10DeviceFirmwareConfigurationInterface();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"bluetooth", n => { Bluetooth = n.GetEnumValue<Enablement>(); } },
                {"bootFromBuiltInNetworkAdapters", n => { BootFromBuiltInNetworkAdapters = n.GetEnumValue<Enablement>(); } },
                {"bootFromExternalMedia", n => { BootFromExternalMedia = n.GetEnumValue<Enablement>(); } },
                {"cameras", n => { Cameras = n.GetEnumValue<Enablement>(); } },
                {"changeUefiSettingsPermission", n => { ChangeUefiSettingsPermission = n.GetEnumValue<ChangeUefiSettingsPermission>(); } },
                {"frontCamera", n => { FrontCamera = n.GetEnumValue<Enablement>(); } },
                {"infraredCamera", n => { InfraredCamera = n.GetEnumValue<Enablement>(); } },
                {"microphone", n => { Microphone = n.GetEnumValue<Enablement>(); } },
                {"microphonesAndSpeakers", n => { MicrophonesAndSpeakers = n.GetEnumValue<Enablement>(); } },
                {"nearFieldCommunication", n => { NearFieldCommunication = n.GetEnumValue<Enablement>(); } },
                {"radios", n => { Radios = n.GetEnumValue<Enablement>(); } },
                {"rearCamera", n => { RearCamera = n.GetEnumValue<Enablement>(); } },
                {"sdCard", n => { SdCard = n.GetEnumValue<Enablement>(); } },
                {"simultaneousMultiThreading", n => { SimultaneousMultiThreading = n.GetEnumValue<Enablement>(); } },
                {"usbTypeAPort", n => { UsbTypeAPort = n.GetEnumValue<Enablement>(); } },
                {"virtualizationOfCpuAndIO", n => { VirtualizationOfCpuAndIO = n.GetEnumValue<Enablement>(); } },
                {"wakeOnLAN", n => { WakeOnLAN = n.GetEnumValue<Enablement>(); } },
                {"wakeOnPower", n => { WakeOnPower = n.GetEnumValue<Enablement>(); } },
                {"wiFi", n => { WiFi = n.GetEnumValue<Enablement>(); } },
                {"windowsPlatformBinaryTable", n => { WindowsPlatformBinaryTable = n.GetEnumValue<Enablement>(); } },
                {"wirelessWideAreaNetwork", n => { WirelessWideAreaNetwork = n.GetEnumValue<Enablement>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<Enablement>("bluetooth", Bluetooth);
            writer.WriteEnumValue<Enablement>("bootFromBuiltInNetworkAdapters", BootFromBuiltInNetworkAdapters);
            writer.WriteEnumValue<Enablement>("bootFromExternalMedia", BootFromExternalMedia);
            writer.WriteEnumValue<Enablement>("cameras", Cameras);
            writer.WriteEnumValue<ChangeUefiSettingsPermission>("changeUefiSettingsPermission", ChangeUefiSettingsPermission);
            writer.WriteEnumValue<Enablement>("frontCamera", FrontCamera);
            writer.WriteEnumValue<Enablement>("infraredCamera", InfraredCamera);
            writer.WriteEnumValue<Enablement>("microphone", Microphone);
            writer.WriteEnumValue<Enablement>("microphonesAndSpeakers", MicrophonesAndSpeakers);
            writer.WriteEnumValue<Enablement>("nearFieldCommunication", NearFieldCommunication);
            writer.WriteEnumValue<Enablement>("radios", Radios);
            writer.WriteEnumValue<Enablement>("rearCamera", RearCamera);
            writer.WriteEnumValue<Enablement>("sdCard", SdCard);
            writer.WriteEnumValue<Enablement>("simultaneousMultiThreading", SimultaneousMultiThreading);
            writer.WriteEnumValue<Enablement>("usbTypeAPort", UsbTypeAPort);
            writer.WriteEnumValue<Enablement>("virtualizationOfCpuAndIO", VirtualizationOfCpuAndIO);
            writer.WriteEnumValue<Enablement>("wakeOnLAN", WakeOnLAN);
            writer.WriteEnumValue<Enablement>("wakeOnPower", WakeOnPower);
            writer.WriteEnumValue<Enablement>("wiFi", WiFi);
            writer.WriteEnumValue<Enablement>("windowsPlatformBinaryTable", WindowsPlatformBinaryTable);
            writer.WriteEnumValue<Enablement>("wirelessWideAreaNetwork", WirelessWideAreaNetwork);
        }
    }
}
